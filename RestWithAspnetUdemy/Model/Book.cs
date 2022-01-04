using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspnetUdemy.Model
{
    [Table("BOOKS")]
    public class Book
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("AUTHOR")]
        public string Author { get; set; }
        [Column("LAUNCH_DATE")]
        public DateTime LaunchDate { get; set; }
        [Column("PRICE")]
        public decimal Price { get; set; }
        [Column("TITLE")]
        public string Title { get; set; }

    }
}
