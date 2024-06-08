using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDapperModels
{
    public abstract class Person : Generic
    {
        [Key]
        int _id {  get; set; }
        int _personType { get; set; }
        string _name { get; set; }
        Address _address { get; set; }
        string _cellphoneNumber { get; set; }
        string _email { get; set; }
    }
}
