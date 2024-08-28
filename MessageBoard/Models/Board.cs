using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models;

public class Board
{
	public int BoardId { get; set; }
	[Required]
	[StringLength(20)]
	public string Title { get; set; }
	[Required]
	[StringLength(100)]
	public string Description { get; set; }
}
