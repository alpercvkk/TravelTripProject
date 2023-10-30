using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Data.Entities
{
	public class Contact
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "E-posta Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Konu  Giriniz")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Mesajınızı Giriniz")]
        public string Message { get; set; }

    }
}
