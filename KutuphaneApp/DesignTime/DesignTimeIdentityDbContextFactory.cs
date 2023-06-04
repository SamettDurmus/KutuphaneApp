using KutuphaneApp.Business.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KutuphaneApp.DesignTime
{
	public class DesignTimeIdentityDbContextFactory : IDesignTimeDbContextFactory<KutuphaneAppContext>
	{
		public KutuphaneAppContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();

			var builder = new DbContextOptionsBuilder<KutuphaneAppContext>();
			var connectionstring = configuration.GetConnectionString("sqlConnection");
			builder.UseSqlServer(connectionstring);
			return new KutuphaneAppContext(builder.Options);
		}
	}
}
