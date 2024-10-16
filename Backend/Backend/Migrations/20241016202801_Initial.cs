using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "Date", "Description", "Status" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 10, 18), "Promotion code issued", 0 },
                    { 2, new DateOnly(2024, 10, 19), "Additional user account", 1 },
                    { 3, new DateOnly(2024, 10, 18), "Change payment method", 0 },
                    { 4, new DateOnly(2024, 10, 19), "Activate account", 1 },
                    { 5, new DateOnly(2024, 10, 18), "Great job", 0 },
                    { 6, new DateOnly(2024, 10, 19), "Another great job", 1 },
                    { 7, new DateOnly(2024, 10, 18), "Help with login", 0 },
                    { 8, new DateOnly(2024, 10, 19), "Password reset requested", 1 },
                    { 9, new DateOnly(2024, 10, 18), "Feedback on new feature", 0 },
                    { 10, new DateOnly(2024, 10, 19), "Report a bug in the system", 1 },
                    { 11, new DateOnly(2024, 10, 18), "Account deactivation request", 0 },
                    { 12, new DateOnly(2024, 10, 19), "Request for feature enhancement", 1 },
                    { 13, new DateOnly(2024, 10, 18), "Question about billing", 0 },
                    { 14, new DateOnly(2024, 10, 19), "Technical support needed", 1 },
                    { 15, new DateOnly(2024, 10, 18), "Inquiry about service availability", 0 },
                    { 16, new DateOnly(2024, 10, 19), "Request for a refund", 1 },
                    { 17, new DateOnly(2024, 10, 18), "Issue with mobile app", 0 },
                    { 18, new DateOnly(2024, 10, 19), "Feedback on customer service", 1 },
                    { 19, new DateOnly(2024, 10, 18), "Request to change username", 0 },
                    { 20, new DateOnly(2024, 10, 19), "Clarification on terms of service", 1 },
                    { 21, new DateOnly(2024, 10, 18), "Inquiry about data privacy", 0 },
                    { 22, new DateOnly(2024, 10, 19), "Help with navigation on site", 1 },
                    { 23, new DateOnly(2024, 10, 18), "Request to merge accounts", 0 },
                    { 24, new DateOnly(2024, 10, 19), "Suggestion for product improvement", 1 },
                    { 25, new DateOnly(2024, 10, 18), "Notification of suspicious activity", 0 },
                    { 26, new DateOnly(2024, 10, 19), "Request for API access", 1 },
                    { 27, new DateOnly(2024, 10, 18), "Report missing items from order", 0 },
                    { 28, new DateOnly(2024, 10, 19), "Issue with payment processing", 1 },
                    { 29, new DateOnly(2024, 10, 18), "Account verification needed", 0 },
                    { 30, new DateOnly(2024, 10, 19), "Inquiry about subscription plans", 1 },
                    { 31, new DateOnly(2024, 10, 18), "Request for training materials", 0 },
                    { 32, new DateOnly(2024, 10, 19), "Bug in checkout process", 1 },
                    { 33, new DateOnly(2024, 10, 18), "Feedback on recent update", 0 },
                    { 34, new DateOnly(2024, 10, 19), "Help with account recovery", 1 },
                    { 35, new DateOnly(2024, 10, 18), "Request for historical data", 0 },
                    { 36, new DateOnly(2024, 10, 19), "Notification of account changes", 1 },
                    { 37, new DateOnly(2024, 10, 18), "Request for appointment scheduling", 0 },
                    { 38, new DateOnly(2024, 10, 19), "Question about loyalty program", 1 },
                    { 39, new DateOnly(2024, 10, 18), "Change of address request", 0 },
                    { 40, new DateOnly(2024, 10, 19), "Report an outage", 1 },
                    { 41, new DateOnly(2024, 10, 18), "Request for user permissions", 0 },
                    { 42, new DateOnly(2024, 10, 19), "Help with email notifications", 1 },
                    { 43, new DateOnly(2024, 10, 18), "Feedback on promotional offers", 0 },
                    { 44, new DateOnly(2024, 10, 19), "Inquiry about technical specifications", 1 },
                    { 45, new DateOnly(2024, 10, 18), "Request for data export", 0 },
                    { 46, new DateOnly(2024, 10, 19), "Change in service terms", 1 },
                    { 47, new DateOnly(2024, 10, 18), "Issue with third-party integration", 0 },
                    { 48, new DateOnly(2024, 10, 19), "Request to change billing address", 1 },
                    { 49, new DateOnly(2024, 10, 18), "Feedback on usability", 0 },
                    { 50, new DateOnly(2024, 10, 19), "Request for product demonstration", 1 },
                    { 51, new DateOnly(2024, 10, 18), "Inquiry about warranty", 0 },
                    { 52, new DateOnly(2024, 10, 19), "Help with system compatibility", 1 },
                    { 53, new DateOnly(2024, 10, 18), "Report incorrect information on profile", 0 },
                    { 54, new DateOnly(2024, 10, 19), "Request for consultation", 1 },
                    { 55, new DateOnly(2024, 10, 18), "Feedback on user interface", 0 },
                    { 56, new DateOnly(2024, 10, 19), "Request for partnership", 1 },
                    { 57, new DateOnly(2024, 10, 18), "Inquiry about corporate accounts", 0 },
                    { 58, new DateOnly(2024, 10, 19), "Request for marketing materials", 1 },
                    { 59, new DateOnly(2024, 10, 18), "Help with device setup", 0 },
                    { 60, new DateOnly(2024, 10, 19), "Feedback on sales process", 1 },
                    { 61, new DateOnly(2024, 10, 18), "Question about industry trends", 0 },
                    { 62, new DateOnly(2024, 10, 19), "Request for testimonials", 1 },
                    { 63, new DateOnly(2024, 10, 18), "Notification of policy changes", 0 },
                    { 64, new DateOnly(2024, 10, 19), "Request for community guidelines", 1 },
                    { 65, new DateOnly(2024, 10, 18), "Feedback on email campaigns", 0 },
                    { 66, new DateOnly(2024, 10, 19), "Inquiry about service levels", 1 },
                    { 67, new DateOnly(2024, 10, 18), "Help with feature usage", 0 },
                    { 68, new DateOnly(2024, 10, 19), "Request for additional storage", 1 },
                    { 69, new DateOnly(2024, 10, 18), "Question about security measures", 0 },
                    { 70, new DateOnly(2024, 10, 19), "Feedback on training sessions", 1 },
                    { 71, new DateOnly(2024, 10, 18), "Help with troubleshooting", 0 },
                    { 72, new DateOnly(2024, 10, 19), "Inquiry about integration services", 1 },
                    { 73, new DateOnly(2024, 10, 18), "Request for user group membership", 0 },
                    { 74, new DateOnly(2024, 10, 19), "Feedback on website content", 1 },
                    { 75, new DateOnly(2024, 10, 18), "Request for account statement", 0 },
                    { 76, new DateOnly(2024, 10, 19), "Question about product features", 1 },
                    { 77, new DateOnly(2024, 10, 18), "Help with user permissions", 0 },
                    { 78, new DateOnly(2024, 10, 19), "Request for support documentation", 1 },
                    { 79, new DateOnly(2024, 10, 18), "Inquiry about pricing", 0 },
                    { 80, new DateOnly(2024, 10, 19), "Feedback on new product release", 1 },
                    { 81, new DateOnly(2024, 10, 18), "Request for system updates", 0 },
                    { 82, new DateOnly(2024, 10, 19), "Notification of billing issues", 1 },
                    { 83, new DateOnly(2024, 10, 18), "Help with payment options", 0 },
                    { 84, new DateOnly(2024, 10, 19), "Request for historical reports", 1 },
                    { 85, new DateOnly(2024, 10, 18), "Inquiry about upcoming features", 0 },
                    { 86, new DateOnly(2024, 10, 19), "Request for API documentation", 1 },
                    { 87, new DateOnly(2024, 10, 18), "Feedback on user experience", 0 },
                    { 88, new DateOnly(2024, 10, 19), "Question about software updates", 1 },
                    { 89, new DateOnly(2024, 10, 18), "Help with licensing", 0 },
                    { 90, new DateOnly(2024, 10, 19), "Request for troubleshooting assistance", 1 },
                    { 91, new DateOnly(2024, 10, 18), "Feedback on user feedback", 0 },
                    { 92, new DateOnly(2024, 10, 19), "Inquiry about online resources", 1 },
                    { 93, new DateOnly(2024, 10, 18), "Help with setting up notifications", 0 },
                    { 94, new DateOnly(2024, 10, 19), "Request for usage statistics", 1 },
                    { 95, new DateOnly(2024, 10, 18), "Question about product comparisons", 0 },
                    { 96, new DateOnly(2024, 10, 19), "Feedback on support channels", 1 },
                    { 97, new DateOnly(2024, 10, 18), "Help with accessing reports", 0 },
                    { 98, new DateOnly(2024, 10, 19), "Request for data accuracy check", 1 },
                    { 99, new DateOnly(2024, 10, 18), "Inquiry about team accounts", 0 },
                    { 100, new DateOnly(2024, 10, 19), "Feedback on technical documentation", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
