using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Data.Entities
{
	public class HomePage
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Başlık Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Açıklama Giriniz")]
        public string Description { get; set; }
    }
}
