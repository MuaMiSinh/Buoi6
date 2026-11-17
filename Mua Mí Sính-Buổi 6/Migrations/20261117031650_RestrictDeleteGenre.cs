using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mua_Mí_Sính_Buổi_6.Migrations
{
    /// <inheritdoc />
    public partial class RestrictDeleteGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genre_GenreID",
                table: "Movies");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genre_GenreID",
                table: "Movies",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genre_GenreID",
                table: "Movies");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genre_GenreID",
                table: "Movies",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
