using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithAspnetUdemy.Model.Base
{
    public class BaseEntity
    {
        [Column("ID")]
        public long Id { get; set; }
    }
}
