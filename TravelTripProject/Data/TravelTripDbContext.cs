using Microsoft.EntityFrameworkCore;
using TravelTripProject.Data.Entities;

namespace TravelTripProject.Data
{
	public class TravelTripDbContext : DbContext
	{

		public	DbSet<HomePage> HomePages { get; set; }
		public	DbSet<AboutUs> AboutUs { get; set; }
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public	DbSet<Contact> Contacts { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
         

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer("Server=DESKTOP-FAFVSUB;Database=TravelTripDb;Trusted_Connection=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<HomePage>().HasKey(x => x.Id);
			modelBuilder.Entity<AboutUs>().HasKey(x => x.Id);
			modelBuilder.Entity<Admin>().HasKey(x => x.Id);
			modelBuilder.Entity<Blog>().HasKey(x => x.Id);
			modelBuilder.Entity<Comment>().HasKey(x => x.Id);
			modelBuilder.Entity<Contact>().HasKey(x => x.Id);
			modelBuilder.Entity<Address>().HasKey(x => x.Id);

			modelBuilder.Entity<Blog>().HasMany(x => x.Comments).WithOne(x => x.Blog).HasForeignKey(x => x.BlogId);

			base.OnModelCreating(modelBuilder);
		}
	}
}
