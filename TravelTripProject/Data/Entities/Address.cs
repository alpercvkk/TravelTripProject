using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Data.Entities
{
	public class Address
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen Başlık Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama Giriniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen Adres Giriniz")]
        public string FirstAddress { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon numaranızı Giriniz")]
        public string PhoneNumbrer { get; set; }
        [Required(ErrorMessage = "Lütfen konum Giriniz")]
        public string Location { get; set; }
    }
}
