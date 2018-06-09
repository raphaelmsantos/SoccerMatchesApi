using Microsoft.EntityFrameworkCore;
using WSN.Mappings;
using WSN.Models;

namespace WSN.Infra
{
	/// <summary>
	/// Application context
	/// </summary>
	public class ApplicationContext : DbContext
	{
		/// <summary>
		/// Constructor of application context
		/// </summary>
		/// <param name="options"></param>
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
		}

		/// <summary>
		/// Teams
		/// </summary>
		public DbSet<Team> Teams { get; set; }

		/// <summary>
		/// Matches
		/// </summary>
		public DbSet<Match> Matches { get; set; }

		/// <summary>
		/// On model creating
		/// </summary>
		/// <param name="modelBuilder"></param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new TeamMap());
			modelBuilder.ApplyConfiguration(new MatchMap());

		}

	}
}
