using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models;

public class Message
{
	public int MessageId { get; set; }
	[Required]
	[StringLength(20)]
	public string Username { get; set; }
	[Required]
	[StringLength(400)]
	public string Content { get; set; }
	[Required]
	[DataType(DataType.DateTime)]
	public DateTime PostedOn { get; set; }
	public int BoardId { get; set; }
	public Board Board { get; set; }
}
