using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Data.Entities
{
	public class AboutUs
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen Görsel Linki Giriniz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Lütfen Açıklama Giriniz")]
        public string Description { get; set; } 
    }
}
