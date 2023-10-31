
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TravelTripProject.Data.Entities
{
	public class Blog
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Başlık Boş geçilemez")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Tarih boş geçilemez")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Açıklama Boş geçilemez")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen Blog linki ekleyin")]
        public string BlogImage { get; set; }
        //[AllowNull]
        public List <Comment>? Comments { get; set; }
    }
}
