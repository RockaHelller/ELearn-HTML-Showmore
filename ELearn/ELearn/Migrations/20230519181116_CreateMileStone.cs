using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearn.Migrations
{
    public partial class CreateMileStone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorImage");

            migrationBuilder.CreateTable(
                name: "MileStones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MileStones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MileStones");

            migrationBuilder.CreateTable(
                name: "AuthorImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorImage_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorImage_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AuthorImage",
                columns: new[] { "Id", "AuthorId", "CourseId", "Image", "SoftDelete" },
                values: new object[,]
                {
                    { 1, 1, null, "featured_author.jpg", false },
                    { 2, 2, null, "course_author_2.jpg", false },
                    { 3, 3, null, "course_author_3.jpg", false },
                    { 4, 1, null, "featured_author.jpg", false },
                    { 5, 2, null, "course_author_2.jpg", false },
                    { 6, 3, null, "course_author_3.jpg", false },
                    { 7, 1, null, "featured_author.jpg", false },
                    { 8, 2, null, "course_author_2.jpg", false },
                    { 9, 3, null, "course_author_3.jpg", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorImage_AuthorId",
                table: "AuthorImage",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorImage_CourseId",
                table: "AuthorImage",
                column: "CourseId");
        }
    }
}
