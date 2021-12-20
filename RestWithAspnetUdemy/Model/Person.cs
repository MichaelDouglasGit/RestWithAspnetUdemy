using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspnetUdemy.Model
{
    [Table("person")]
    public class Person
    {
        [Column("ID")]
        public long Id { get; set; }
        [Column("FIRST_NAME")]
        public string FistName { get; set; }
        [Column("LAST_NAME")]
        public string LastName { get; set; }
        [Column("ADDRESS")]
        public string Address { get; set; }
        [Column("GENDER")]
        public string Gender { get; set; }
    }
}
