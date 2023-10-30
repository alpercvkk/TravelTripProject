
using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Data.Entities
{
	public class Blog
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Başlık Boş geçilemez")]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Açıklama Boş geçilemez")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen Blog linki ekleyin")]
        public string BlogImage { get; set; }
        public List <Comment> Comments { get; set; }
    }
}
