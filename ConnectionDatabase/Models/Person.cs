using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionDatabase.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Firstname { get; set; }
        [MaxLength(50)]
        public string Lastname { get; set; }
        public int Age { get; set; }
        public bool IsPlayer { get; set; }
    }
}
