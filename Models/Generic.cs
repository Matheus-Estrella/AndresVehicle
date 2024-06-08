using Dapper;
using System.Reflection;
using System.Text;

namespace Models
{
    public abstract class Generic
    {
        // Para o gerador de arquivos json desta classe
        readonly string path = @"C:\Users\Matheus\TrabalhosEstagio\AndresVehicles";
        readonly string file;
        readonly string class_name;
        // Para manipular a tabela do banco de dados sql
        readonly string _tableName;
        readonly string _inforRestrained;

        public virtual string GetPath() { return this.path; }
        public virtual string GetFile() { return string.Empty; }
        public virtual string GetTableName() { return string.Empty; }
        public virtual string GetRestrained() { return string.Empty; }


        // PROBLEMA --> Não funciona este método com atributos aninhados (ou seja, classes que conhenham classes)

        public static DynamicParameters GetParameters<T>(T obj)
        {
            DynamicParameters _parameters = new DynamicParameters();
            PropertyInfo[] _properties = obj.GetType().GetProperties();

            foreach (var _property in _properties)
            {
                _parameters.Add($"@{_property.Name}", _property.GetValue(obj));
            }
            return _parameters;
        }
        public static string GenerateInsertCommand<T>(T obj, string _tableName, string _inforRestrained) 
        {
            PropertyInfo[] _properties = obj.GetType().GetProperties().ToArray();

            string _Cols = string.Join(", ", _properties.Where(o => o.Name != _inforRestrained).Select(o => o.Name));
            string _parameters = string.Join(", ", _properties.Where(o => o.Name != _inforRestrained).Select(o => $"@{o.Name}"));

            return $"INSERT INTO {_tableName} ({_Cols}) VALUES ({_parameters})";
        }
        public static string GenerateCreateTableCommand<T>(T obj, string _tableName, string _primaryKey)
        {
            PropertyInfo[] _properties = obj.GetType().GetProperties();
            string _end = "";
            StringBuilder _builderTable = new StringBuilder();
            _builderTable.Append($"CREATE TABLE {_tableName} (");

            foreach (var _prop in _properties)
            {
                string _propertyType = GetSqlType(_prop.PropertyType);
                if(_propertyType != null)
                {
                    string _propertyName = _prop.Name;
                    bool _isPK = _propertyName == _primaryKey;

                    // Define PK
                    if (_isPK)
                    {
                        _builderTable.Append($"{_propertyName} {_propertyType} IDENTITY(1,1), ");
                        _end = $"PRIMARY KEY ({_propertyName}) );";
                    }
                    else
                    {
                        _builderTable.Append($"{_propertyName} {_propertyType}, ");
                    }
                }
            }
            _builderTable.Append(_end);

            return _builderTable.ToString();
        }
        public static string GetSqlType(Type type)
        {
            if (type == typeof(int))
            {
                return "INT";
            }
            else if (type == typeof(string))
            {
                return "NVARCHAR(100)";
            }
            else if (type == typeof(DateOnly))
            {
                return "DATE";
            }
            else if (type == typeof(decimal))
            {
                return "DECIMAL(8,2)"; // Pode ajustar a precisão com "DECIMAL(x,parcial)"
            }
            else if (type == typeof(DateTime))
            {
                return "DATETIME";
            }
            else if (type == typeof(bool))
            {
                return "BIT";
            }
            else
            {
                return null;
            }
            // Adicionar mais tipos se necessário
        }

    }
}
