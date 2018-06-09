using System;

namespace WSN.Models
{
	/// <summary>
	/// Match
	/// </summary>
	public class Match
    {
		/// <summary>
		/// Id
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Date
		/// </summary>
		public DateTime Date { get; set; }

		/// <summary>
		/// Home team id
		/// </summary>
		public int HomeTeamId { get; set; }

		/// <summary>
		/// Home Team
		/// </summary>
		public Team HomeTeam { get; set; }

		/// <summary>
		/// Home team score
		/// </summary>
		public int HomeTeamScore { get; set; }

		/// <summary>
		/// Away team id
		/// </summary>
		public int AwayTeamId { get; set; }

		/// <summary>
		/// away team
		/// </summary>
		public Team AwayTeam { get; set; }

		/// <summary>
		/// Away team Score
		/// </summary>
		public int AwayTeamScore { get; set; }
	}
}
