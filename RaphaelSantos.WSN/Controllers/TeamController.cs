using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WSN.Infra;
using WSN.Models;

namespace WSN.Controllers
{
	/// <summary>
	/// Team controller
	/// </summary>
	[Route("api/[controller]")]
	[EnableCors("SiteCorsPolicy")]
	public class TeamController : Controller
	{
		private ApplicationContext _db;

		/// <summary>
		/// Constructor of Team Controller
		/// </summary>
		/// <param name="db"></param>
		public TeamController(ApplicationContext db)
		{
			_db = db;
		}

		/// <summary>
		/// Get all Teams
		/// </summary>
		/// <returns>List of teams</returns>
		[HttpGet]
		// GET: api/Team
		public IActionResult Get()
		{
			var list = _db.Teams.OrderBy(x => x.Name).ToList();

			return Ok(list);
		}

		/// <summary>
		/// Get Team by Id
		/// </summary>
		/// <param name="id">Id</param>
		/// <returns>Team</returns>
		[HttpGet("{id}")]
		// GET: api/Team/5
		public IActionResult Get(int id)
		{
			var obj = _db.Teams.Where(x => x.Id == id).FirstOrDefault();

			if (obj == null)
				return NotFound();

			return Ok(obj);
		}

		/// <summary>
		/// Save new Team
		/// </summary>
		/// <param name="team">Team</param>
		/// <returns>Team</returns>
		[HttpPost]
		// POST: api/Team
		public IActionResult Post([FromBody] Team team)
		{
			_db.Teams.Add(team);
			_db.SaveChanges();

			return Ok(team);
		}

		/// <summary>
		/// Update Team by id
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="team">Team</param>
		/// <returns>Team</returns>
		[HttpPut("{id}")]
		// PUT: api/Team/5
		public IActionResult Put(int id, [FromBody]Team team)
		{
			_db.Teams.Update(team);
			_db.SaveChanges();

			return Ok(team);
		}

		/// <summary>
		/// Delete team by Id
		/// </summary>
		/// <param name="id">Id</param>
		/// <returns>ok</returns>
		[HttpDelete("{id}")]
		// DELETE: api/Team/5
		public IActionResult Delete(int id)
		{
			var obj = _db.Teams.Where(x => x.Id == id).FirstOrDefault();

			_db.Teams.Remove(obj);

			return Ok();
		}
	}
}
