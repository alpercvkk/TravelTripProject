namespace TravelTripProject.Data.Entities
{
	public class Comment
	{
        public int Id{ get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Remark { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
