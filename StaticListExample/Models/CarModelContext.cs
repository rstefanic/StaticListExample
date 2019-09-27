using Microsoft.EntityFrameworkCore;

namespace StaticListExample.Models
{
	public class CarModelContext : DbContext
	{
		public DbSet<CarModel> CarModels { get; set; }

		public CarModelContext(DbContextOptions<CarModelContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CarModel>(sli =>
			{
				sli.Property(x => x.id).ValueGeneratedOnAdd();
				sli.Property(x => x.name).IsRequired();
				sli.Property(x => x.DateAdded).HasDefaultValueSql("getdate()");
			});
		}
	}
}
