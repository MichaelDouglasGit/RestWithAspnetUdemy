using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithAspnetUdemy.Model
{
    [Table("USERS")]
    public class User
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }

        [Column("USER_NAME")]
        public string UserName { get; set; }

        [Column("FULL_NAME")]
        public string FullName { get; set; }

        [Column("PASSWORD")]
        public string Password { get; set; }

        [Column("REFRESH_TOKEN")]
        public string RefreshToken { get; set; }

        [Column("REFRESH_TOKEN_EXPIRY_TIME")]
        public string RefreshTokenExpiryTime { get; set; }
    }
}
