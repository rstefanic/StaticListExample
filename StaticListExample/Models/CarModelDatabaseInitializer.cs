using System.Collections.Generic;
using System.Linq;

namespace StaticListExample.Models
{
	public class CarModelDatabaseInitializer
	{
		public static void Seed(CarModelContext context)
		{
			context.Database.EnsureCreated();
			if (context.CarModels.Any())
			{
				return;
			}

			getDefaultItems().ForEach(x => context.CarModels.Add(x));
			context.SaveChanges();
		}

		private static List<CarModel> getDefaultItems()
		{
			return new List<CarModel>
			{
				new CarModel { name = "Acura" },
				new CarModel { name = "Alfa Romeo" },
				new CarModel { name = "Audi" },
				new CarModel { name = "BMW" },
				new CarModel { name = "Bentley" },
				new CarModel { name = "Buick" },
				new CarModel { name = "Cadillac" },
				new CarModel { name = "Chevrolet" },
				new CarModel { name = "Chrysler" },
				new CarModel { name = "Dodge" },
				new CarModel { name = "Fiat" },
				new CarModel { name = "Ford" },
				new CarModel { name = "GMC" },
				new CarModel { name = "Genesis" },
				new CarModel { name = "Honda" },
				new CarModel { name = "Hyundai" },
				new CarModel { name = "Infiniti" },
				new CarModel { name = "Jaguar" },
				new CarModel { name = "Jeep" },
				new CarModel { name = "Kia" },
				new CarModel { name = "Land Rover" },
				new CarModel { name = "Lexus" },
				new CarModel { name = "Lincoln" },
				new CarModel { name = "Maserati" },
				new CarModel { name = "Mazda" },
				new CarModel { name = "Mercedes-Benz" },
				new CarModel { name = "Mercury" },
				new CarModel { name = "Mini" },
				new CarModel { name = "Mitsubishi" },
				new CarModel { name = "Nissan" },
				new CarModel { name = "Polestar" },
				new CarModel { name = "Pontiac" },
				new CarModel { name = "Porsche" },
				new CarModel { name = "Ram" },
				new CarModel { name = "Saab" },
				new CarModel { name = "Saturn" },
				new CarModel { name = "Scion" },
				new CarModel { name = "Smart" },
				new CarModel { name = "Subaru" },
				new CarModel { name = "Suzuki" },
				new CarModel { name = "Tesla" },
				new CarModel { name = "Toyota" },
				new CarModel { name = "Volkswagen" },
				new CarModel { name = "Volvo" }
			};
		}
	}
}
