using DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OneToBarDB.DBUtility
{
      		
    public static class SqlConnectionExtension
    {
        //数据库连接字符串(web.config来配置)，多数据库可使用DbHelperSQLP来实现.
        public static string connectionString = PubConstant.ConnectionString;   

        /// <summary>
        /// 使用 SqlBulkCopy 向 destinationTableName 表插入数据
        /// </summary>
        /// <typeparam name="TModel">必须拥有与目标表所有字段对应属性</typeparam>
        /// <param name="conn"></param>
        /// <param name="modelList">要插入的数据</param>
        /// <param name="batchSize">SqlBulkCopy.BatchSize</param>
        /// <param name="destinationTableName">如果为 null，则使用 TModel 名称作为 destinationTableName</param>
        /// <param name="bulkCopyTimeout">SqlBulkCopy.BulkCopyTimeout</param>
        /// <param name="externalTransaction">要使用的事务</param>
        public static void BulkCopy<TModel>(this SqlConnection conn, List<TModel> modelList, int batchSize, string destinationTableName = null, int? bulkCopyTimeout = null, SqlTransaction externalTransaction = null)
        {
            bool shouldCloseConnection = false;

            if (string.IsNullOrEmpty(destinationTableName))
                destinationTableName = typeof(TModel).Name;

            DataTable dtToWrite = ToSqlBulkCopyDataTable(modelList, conn, destinationTableName);

            SqlBulkCopy sbc = null;

            try
            {
                if (externalTransaction != null)
                    sbc = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, externalTransaction);
                else
                    sbc = new SqlBulkCopy(conn);

                using (sbc)
                {
                    sbc.BatchSize = batchSize;
                    sbc.DestinationTableName = destinationTableName;

                    if (bulkCopyTimeout != null)
                        sbc.BulkCopyTimeout = bulkCopyTimeout.Value;

                    if (conn.State != ConnectionState.Open)
                    {
                        shouldCloseConnection = true;
                        conn.Open();
                    }

                    sbc.WriteToServer(dtToWrite);
                }
            }
            finally
            {
                if (shouldCloseConnection && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public static DataTable ToSqlBulkCopyDataTable<TModel>(List<TModel> modelList, SqlConnection conn, string tableName)
        {
            DataTable dt = new DataTable();

            Type modelType = typeof(TModel);

            List<SysColumn> columns = GetTableColumns(conn, tableName);
            List<PropertyInfo> mappingProps = new List<PropertyInfo>();

            var props = modelType.GetProperties();
            for (int i = 0; i < columns.Count; i++)
            {
                var column = columns[i];
                PropertyInfo mappingProp = props.Where(a => a.Name == column.Name).FirstOrDefault();
                if (mappingProp == null)
                    throw new Exception(string.Format("model 类型 '{0}'未定义与表 '{1}' 列名为 '{2}' 映射的属性", modelType.FullName, tableName, column.Name));

                mappingProps.Add(mappingProp);
                Type dataType = GetUnderlyingType(mappingProp.PropertyType);
                if (dataType.IsEnum)
                    dataType = typeof(int);
                dt.Columns.Add(new DataColumn(column.Name, dataType));
            }

            foreach (var model in modelList)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < mappingProps.Count; i++)
                {
                    PropertyInfo prop = mappingProps[i];
                    object value = prop.GetValue(model,null);

                    if (GetUnderlyingType(prop.PropertyType).IsEnum)
                    {
                        if (value != null)
                            value = (int)value;
                    }

                    dr[i] = value ?? DBNull.Value;
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }
        static List<SysColumn> GetTableColumns(SqlConnection sourceConn, string tableName)
        {
            string sql = string.Format("select * from syscolumns inner join sysobjects on syscolumns.id=sysobjects.id where sysobjects.xtype='U' and sysobjects.name='{0}' order by syscolumns.colid asc", tableName);

            List<SysColumn> columns = new List<SysColumn>();
            using (SqlConnection conn = (SqlConnection)((ICloneable)sourceConn).Clone())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SysColumn column = new SysColumn();
                            column.Name = reader.GetSqlValue(0).ToString();//.GetDbValue("name");
                            column.ColOrder = int.Parse(reader.GetSqlValue(1).ToString());//.GetDbValue("colorder");

                            columns.Add(column);
                        }
                    }
                    conn.Close();
                }
            }

            return columns;
        }

        static Type GetUnderlyingType(Type type)
        {
            Type unType = Nullable.GetUnderlyingType(type); ;
            if (unType == null)
                unType = type;

            return unType;
        }

        class SysColumn
        {
            public string Name { get; set; }
            public int ColOrder { get; set; }
        }
    }
}
