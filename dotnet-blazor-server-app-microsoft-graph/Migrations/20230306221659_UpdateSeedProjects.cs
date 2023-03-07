using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductiGraph.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Project");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A hackathon to learn about Microsoft Graph using .NET", "Microsoft Graph .NET hackathon" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Microsoft's annual hackathon to build a solution using Microsoft Azure", "Microsoft Imagine Cup" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Do cool things with Microsoft as a student", "Microsoft Learn Student Ambassadors" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Get advice about anything from a Microsoft MVP", "Microsoft MVP Mentoring" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Build something for the Microsoft Community", "Social Impact Project" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Project",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Completed", "Description", "Name", "Status" },
                values: new object[] { false, "I need a personal second brain to take care of my workflow efficiently", "Build Personal Productivity Machine", "Just created" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Completed", "Description", "Name", "Status" },
                values: new object[] { false, "Learn about system design", "Mentoring with Sam", "Just created" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Completed", "Description", "Name", "Status" },
                values: new object[] { false, "Thinking of making a gamified system for smart glasses", "Collab with Cayden", "Just created" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Completed", "Description", "Name", "Status" },
                values: new object[] { false, "Learn about human centered design", "Research with Jina", "Just created" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Completed", "Description", "Name", "Status" },
                values: new object[] { false, "We need to start getting UK ambassadors engaged with extra activities", "Plan Gold Engagement with Jennifer", "Just created" });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Completed", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { 6, false, "GTA is the best grinding simulator", "Bring GTA UI to life", "Just created" },
                    { 7, false, "AI and ML is the future, time to pick up some skills", "Learn AI and ML", "Just created" },
                    { 8, false, "Get involved with the community", "Prepare content with Baki", "Just created" }
                });
        }
    }
}
