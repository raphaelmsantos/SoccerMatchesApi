using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WSN.Models;

namespace WSN.Mappings
{
	public class TeamMap : IEntityTypeConfiguration<Team>
	{
		public void Configure(EntityTypeBuilder<Team> builder)
		{
			builder.ToTable("Team");
			builder.HasKey(c => c.Id);
		}
	}
}
