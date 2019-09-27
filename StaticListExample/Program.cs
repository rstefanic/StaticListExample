using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using StaticListExample.Models;

namespace StaticListExample
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var build = CreateWebHostBuilder(args).Build();

			using (var scope = build.Services.CreateScope())
			{
				var services = scope.ServiceProvider;

				try
				{
					var context = services.GetRequiredService<CarModelContext>();
					CarModelDatabaseInitializer.Seed(context);
				}
				catch (Exception e)
				{
					var logger = services.GetRequiredService<ILogger<Program>> ();
					logger.LogError(e, "An error occurred seeding the database.");	
				}
			}

			build.Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
				WebHost.CreateDefaultBuilder(args)
						.UseStartup<Startup>();
	}
}
