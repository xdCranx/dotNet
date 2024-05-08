using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4_2.Migrations
{
    /// <inheritdoc />
    public partial class Added_Crud4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "releaseDate",
                table: "Games",
                newName: "ReleaseDate");

            migrationBuilder.AddColumn<float>(
                name: "AvgRating",
                table: "Games",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumOfReviews",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgRating",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "NumOfReviews",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Games",
                newName: "releaseDate");
        }
    }
}
