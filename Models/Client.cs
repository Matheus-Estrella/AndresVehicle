using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client : Person
    {

        #region Características da classe e construtor

        readonly string file;
        readonly string class_name;
        readonly string _tableName;
        readonly string _inforRestrained = "";

        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }

        public Client()
        {
            class_name = this.GetType().Name;
            file = $@"\{class_name}.json";
            _tableName = $"TB_{class_name}";
        }
        #endregion
        [Key]
        int _id { get; set; }
        decimal _salary { get; set; }
        string _document { get; set; }
    }
}
