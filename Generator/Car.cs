using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Car : Generic
    {
        #region Características para interação com Generic e o sistema
        // Para o gerador de arquivos json desta classe
        readonly string path = @"C:\Users\Matheus\TrabalhosEstagio\AndresVehicles";
        readonly string file = @"\Vehicles.json";
        // Para manipular a tabela do banco de dados sql
        readonly string _tableName = "TB_Garagem";
        readonly string _inforRestrained = "";

        public override string GetPath() { return path; }
        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }
        #endregion

        #region Características da classe e construtor
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
        }
        public Car()
        {
            
        }
        #endregion
    }
}
