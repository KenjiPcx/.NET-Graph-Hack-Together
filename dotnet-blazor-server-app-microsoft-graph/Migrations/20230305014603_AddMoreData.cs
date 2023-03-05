using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductiGraph.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "I need a personal second brain to take care of my workflow efficiently", "Build Personal Productivity Machine" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Completed", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { 2, false, "Learn about system design", "Mentoring with Sam", "Just created" },
                    { 3, false, "Thinking of making a gamified system for smart glasses", "Collab with Cayden", "Just created" },
                    { 4, false, "Learn about human centered design", "Research with Jina", "Just created" },
                    { 5, false, "We need to start getting UK ambassadors engaged with extra activities", "Plan Gold Engagement with Jennifer", "Just created" },
                    { 6, false, "GTA is the best grinding simulator", "Bring GTA UI to life", "Just created" },
                    { 7, false, "AI and ML is the future, time to pick up some skills", "Learn AI and ML", "Just created" },
                    { 8, false, "Get involved with the community", "Prepare content with Baki", "Just created" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Project 1", "Project 1" });
        }
    }
}
