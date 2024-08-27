using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;

namespace MessageBoard.Models;
public class MessageBoardContext : DbContext
{
	public DbSet<Message> Messages { get; set; }
	public MessageBoardContext (DbContextOptions<MessageBoardContext> options) : base(options)
	{
	}
}
