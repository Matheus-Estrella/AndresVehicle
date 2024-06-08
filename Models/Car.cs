using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car : Generic
    {

        #region Características da classe e construtor

        readonly string file;
        readonly string class_name;
        readonly string _tableName;
        readonly string _inforRestrained = "";

        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }

        public Car()
        {
            class_name = this.GetType().Name;
            file = $@"\{class_name}.json";
            _tableName = $"TB_{class_name}";
        }
        #endregion

        [Key]
        public string _licensePlate { get; set; }
        public string _name { get; set; }
        public int _modelYear { get; set; }
        public int _makedYear { get; set; }
        public string _color { get; set; }
        public Car(string licensePlate, string name, int modelYear, int makedYear, string color)
        {
            _licensePlate = licensePlate;
            _name = name;
            _modelYear = modelYear;
            _makedYear = makedYear;
            _color = color;
            class_name = this.GetType().Name;
            file = $@"\{class_name}.json";
        }

    }
}
