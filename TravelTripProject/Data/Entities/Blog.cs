namespace TravelTripProject.Data.Entities
{
	public class Blog
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public List <Comment> Comments { get; set; }
    }
}
