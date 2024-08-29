using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;

namespace MessageBoard.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessagesController : ControllerBase
	{
		private readonly MessageBoardContext _context;

		public MessagesController(MessageBoardContext context)
		{
			_context = context;
		}

		// GET: api/Messages
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Message>>> GetMessage(string boardId, string startDate, string endDate)
		{
			IQueryable<Message> query = _context.Messages.AsQueryable();
			try
			{
				query = query.Where(entry => boardId == null || entry.BoardId == int.Parse(boardId));
				query = query.Where(entry => startDate == null || entry.PostedOn.CompareTo(DateTime.Parse(startDate)) >= 0);
				query = query.Where(entry => endDate == null || entry.PostedOn.CompareTo(DateTime.Parse(endDate)) <= 0);
			}
			catch (Exception)
			{
				return BadRequest("Invalid date strings");
			}

			return await query.ToListAsync();
		}

		// GET: api/Messages/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Message>> GetMessage(int id)
		{
			var message = await _context.Messages.FindAsync(id);

			if (message == null)
			{
				return NotFound();
			}

			return message;
		}

		// PUT: api/Messages/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutMessage(int id, string username, Message message)
		{
			if (id != message.MessageId)
			{
				return BadRequest();
			}
			if (username != message.Username)
			{
				return Unauthorized();
			}

			_context.Entry(message).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!MessageExists(id))
				{
					return NotFound();
				}
				if (!BoardExists(message.BoardId))
				{
					return BadRequest("A message must have a valid BoardId");
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/Messages
		[HttpPost]
		public async Task<ActionResult<Message>> PostMessage(Message message)
		{
			if (!BoardExists(message.BoardId))
			{
				return BadRequest("A message must have a valid BoardId");
			}
			_context.Messages.Add(message);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetMessage), new { id = message.MessageId }, message);
		}

		// DELETE: api/Messages/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteMessage(int id, string username)
		{
			var message = await _context.Messages.FindAsync(id);
			if (message == null)
			{
				return NotFound();
			}
			if (username != message.Username)
			{
				return Unauthorized();
			}

			_context.Messages.Remove(message);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		private bool MessageExists(int id)
		{
			return _context.Messages.Any(e => e.MessageId == id);
		}

		private bool BoardExists(int id)
		{
			return _context.Boards.Any(e => e.BoardId == id);
		}
	}
}
