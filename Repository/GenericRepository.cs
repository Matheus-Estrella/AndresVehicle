using Dapper;
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Repository
{
    public class GenericRepository
    {
        private string Conn { get; set; }

        public GenericRepository()
        {
            //Conn = "Data Source = 127.0.0.1; Initial Catalog = x;User Id=sa; Password=SqlServer2019!";  , onde, x é o nome do banco de dados
            Conn = ConfigurationManager.ConnectionStrings["StringConnection_SQLServer"].ConnectionString; // --> Substitui o método da linha acima
        }
        public bool Insert(Generic generic)
        {
            string _tableName = generic.GetTableName();
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                #region Checking if table exists
                string _checkTableQuery = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{_tableName}'";

                using (SqlCommand _cmd = new SqlCommand(_checkTableQuery,db))
                {
                    int tableCount = (int)_cmd.ExecuteScalar();
                    if (tableCount > 0) { } // if table exists
                    else
                    {
                        string _primaryKey = generic.GetRestrained();
                        string _createTableQuery = Generic.GenerateCreateTableCommand(generic, _tableName, _primaryKey);
                        SqlCommand _createTableCMD = new SqlCommand(_createTableQuery, db);
                    }
                }
                #endregion
                string _inforRestrained = generic.GetRestrained();
                string _sqlCommand = Generic.GenerateInsertCommand(generic, _tableName, _inforRestrained);
                var _parameters = Generic.GetParameters(generic);
                db.Execute(_sqlCommand, _parameters);
                status = true;
                db.Close();
            }
            return status;
        }

    }
}
