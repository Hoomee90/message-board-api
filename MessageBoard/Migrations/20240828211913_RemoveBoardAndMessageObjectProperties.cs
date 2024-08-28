using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageBoard.Migrations
{
    public partial class RemoveBoardAndMessageObjectProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Boards_BoardId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_BoardId",
                table: "Messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Messages_BoardId",
                table: "Messages",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Boards_BoardId",
                table: "Messages",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "BoardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
