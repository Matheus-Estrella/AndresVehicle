using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDapperModels
{
    public class Buy : Generic
    {

        #region Características da classe e construtor

        readonly string file;
        readonly string class_name;
        readonly string _tableName;
        readonly string _inforRestrained = "";

        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }

        public Buy()
        {
            class_name = this.GetType().Name;
            file = $@"\{class_name}.json";
            _tableName = $"TB_{class_name}";
        }
        #endregion

        [Key]
        int _id { get; set; }
        Car _car { get; set; }
        decimal _price { get; set; }
        DateTime _buyDate {  get; set; }
    }
}
