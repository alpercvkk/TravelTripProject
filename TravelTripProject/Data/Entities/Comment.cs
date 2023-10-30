using System.ComponentModel.DataAnnotations;

namespace TravelTripProject.Data.Entities
{
	public class Comment
	{
        public int Id{ get; set; }
        [Required(ErrorMessage ="Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "E-posta Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Yorum Giriniz")]
        public string Remark { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
