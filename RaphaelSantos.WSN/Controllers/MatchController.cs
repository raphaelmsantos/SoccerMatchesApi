using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WSN.Infra;
using WSN.Models;

namespace WSN.Controllers
{
	/// <summary>
	/// Match controller
	/// </summary>
	[Route("api/[controller]")]
	[EnableCors("SiteCorsPolicy")]
	public class MatchController : Controller
	{
		private ApplicationContext _db;

		/// <summary>
		/// Constructor of Match Controller
		/// </summary>
		/// <param name="db"></param>
		public MatchController(ApplicationContext db)
		{
			_db = db;
		}

		/// <summary>
		/// Get all Matches
		/// </summary>
		/// <returns>List of Matches</returns>
		[HttpGet]
		// GET: api/Match
		public IActionResult Get()
		{
			var list = _db.Matches.OrderBy(x => x.Date).ToList();

			return Ok(list);
		}

		/// <summary>
		/// Get Match by Id
		/// </summary>
		/// <param name="id">Id</param>
		/// <returns>Match</returns>
		[HttpGet("{id}")]
		// GET: api/Match/5
		public IActionResult Get(int id)
		{
			var obj = _db.Matches.Where(x => x.Id == id).FirstOrDefault();

			if (obj == null)
				return NotFound();

			return Ok(obj);
		}

		/// <summary>
		/// Save new Match
		/// </summary>
		/// <param name="match">Match</param>
		/// <returns>Match</returns>
		[HttpPost]
		// POST: api/Match
		public IActionResult Post([FromBody] Match match)
		{
			_db.Matches.Add(match);
			_db.SaveChanges();

			return Ok(match);
		}

		/// <summary>
		/// Update Match by id
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="match">Match</param>
		/// <returns>Match</returns>
		[HttpPut("{id}")]
		// PUT: api/Match/5
		public IActionResult Put(int id, [FromBody]Match match)
		{
			_db.Matches.Update(match);
			_db.SaveChanges();

			return Ok(match);
		}

		/// <summary>
		/// Delete Match by Id
		/// </summary>
		/// <param name="id">Id</param>
		/// <returns>ok</returns>
		[HttpDelete("{id}")]
		// DELETE: api/Match/5
		public IActionResult Delete(int id)
		{
			var obj = _db.Matches.Where(x => x.Id == id).FirstOrDefault();

			_db.Matches.Remove(obj);

			return Ok();
		}
	}
}
