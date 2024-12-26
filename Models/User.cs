using Registration.Service;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class User
    {
        [Key]
        public int Id = UserID.userID++;

        [Required(ErrorMessage = "Ad boş ola bilməz")]
        [StringLength(10, ErrorMessage = "Ad maksimum 50 simvoldan ibarət ola bilər")]
        [MinLength(3, ErrorMessage = "Ad ən azı 3 simvoldan ibarət olmalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad boş ola bilməz")]
        [StringLength(20, ErrorMessage = "Soyad maksimum 50 simvoldan ibarət ola bilər")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email boş ola bilməz")]
        [EmailAddress(ErrorMessage = "Düzgün email formatı daxil edin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Participe olunmamalıdır")]
        public bool Particibate { get; set; }
    }
}
