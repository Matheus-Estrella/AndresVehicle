using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDapperModels
{
    public class Pix : Generic
    {

        #region Características da classe e construtor

        readonly string file;
        readonly string class_name;
        readonly string _tableName;
        readonly string _inforRestrained = "";

        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }

        public Pix()
        {
            class_name = this.GetType().Name;
            file = $@"\{class_name}.json";
            _tableName = $"TB_{class_name}";
        }
        #endregion
        [Key]
        int _id { get; set; }
        string _pixKey { get; set; }
        PixType _type { get; set; }
        Card _card { get; set; }

    }
}
