using Microsoft.EntityFrameworkCore.Migrations;

namespace WordOfTheDay.AnaliticsMicroservice.Repository.Migrations
{
    public partial class WordsInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WordInfo",
                table: "WordInfo");

            migrationBuilder.RenameTable(
                name: "WordInfo",
                newName: "WordsInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WordsInfo",
                table: "WordsInfo",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WordsInfo",
                table: "WordsInfo");

            migrationBuilder.RenameTable(
                name: "WordsInfo",
                newName: "WordInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WordInfo",
                table: "WordInfo",
                column: "Id");
        }
    }
}
