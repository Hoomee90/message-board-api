using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models;
public class MessageBoardContext : DbContext
{
	public DbSet<Message> Messages { get; set; }
	public DbSet<Board> Boards { get; set; }
	public MessageBoardContext(DbContextOptions<MessageBoardContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Message>()
			.HasData(
				new Message { MessageId = 1, BoardId = 1, Username = "Matilda", Content = "Woolly Mammoth", PostedOn = DateTime.Parse("08/18/2018 07:22:16") },
				new Message { MessageId = 6, BoardId = 2, Username = "Rexie", Content = "Dinosaur", PostedOn = DateTime.Parse("2018-08-18T07:22:16.0000000Z") },
				new Message { MessageId = 3, BoardId = 7, Username = "Matilda", Content = "Dinosaur", PostedOn = DateTime.Parse("Sat, 18 Aug 2018 07:22:16 GMT") },
				new Message { MessageId = 4, BoardId = 1, Username = "Pip", Content = "Shark", PostedOn = DateTime.Parse("08/28/2022 11:22:16") },
				new Message { MessageId = 5, BoardId = 2, Username = "Bartholomew", Content = "Dinosaur", PostedOn = DateTime.Parse("12/1/2010 01:23:50") }
			);
		builder.Entity<Board>()
			.HasData(
				new Board { BoardId = 1, Title = "Writing", Description = "Write write write write" },
				new Board { BoardId = 2, Title = "Art", Description = "Art cool stuff" }
			);
	}
}
