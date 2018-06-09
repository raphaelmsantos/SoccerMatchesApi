using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WSN.Models;

namespace WSN.Mappings
{
	public class MatchMap : IEntityTypeConfiguration<Match>
	{
		public void Configure(EntityTypeBuilder<Match> builder)
		{
			builder.ToTable("Match");
			builder.HasKey(c => c.Id);

			builder.HasOne<Team>(pc => pc.HomeTeam)
				.WithMany(p => p.HomeMatches)
				.HasForeignKey(pc => pc.HomeTeamId).OnDelete(DeleteBehavior.Restrict);

			builder.HasOne<Team>(pc => pc.AwayTeam)
				.WithMany(p => p.AwayMatches)
				.HasForeignKey(pc => pc.AwayTeamId).OnDelete(DeleteBehavior.Restrict);
		}
	}
}
