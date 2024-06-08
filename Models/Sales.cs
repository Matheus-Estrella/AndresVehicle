using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDapperModels
{
    public class Sales : Generic
    {
        [Key]
        int _id { get; set; }
        Card _card { get; set; }
        Ticket _ticket { get; set; }
        Pix _pix { get; set; }
        DateOnly _payDay {  get; set; }

        #region Características da classe e construtor

        readonly string file;
        readonly string class_name;
        readonly string _tableName;
        readonly string _inforRestrained = "";

        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }

        public Sales()
        {
            class_name = this.GetType().Name;
            file = $@"\{class_name}.json";
            _tableName = $"TB_{class_name}";
        }
        #endregion
    }
}
