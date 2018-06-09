using System.Collections.Generic;

namespace WSN.Models
{
	/// <summary>
	/// Team
	/// </summary>
	public class Team
    {
		/// <summary>
		/// Id
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Home matches
		/// </summary>
		public IList<Match> HomeMatches { get; set; }

		/// <summary>
		/// Away matches
		/// </summary>
		public IList<Match> AwayMatches { get; set; }
	}
}
