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
	[DataType(DataType.DateTime, ErrorMessage = "PostedOn must be a valid date time.")]
	public string PostedOn { get; set; }
}
