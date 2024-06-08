using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Person
    {
        [Key]

        int _document { get; set; }
    }
}
