﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDapperModels
{
    public class Card : Generic
    {

        #region Características da classe e construtor

        readonly string file;
        readonly string class_name;
        readonly string _tableName;
        readonly string _inforRestrained = "";

        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }

        public Card()
        {
            class_name = this.GetType().Name;
            file = $@"\{class_name}.json";
            _tableName = $"TB_{class_name}";
        }
        #endregion
        [Key]
        string _cardNumber { get; set; }
        string _securityCode { get; set; }
        string _validDate { get; set; }
        string _cardName { get; set; }

    }
}
