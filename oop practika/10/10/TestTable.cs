using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public class TestTable
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
