using Backend.Entities;
using Backend.Enums;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Ticket> Tickets { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seeding 100 ticket
        var tickets = new Ticket[100];
        for (int i = 0; i < 100; i++)
        {
            tickets[i] = new Ticket
            {
                Description = GetDescription(i),
                Status = (i % 2 == 0) ? Status.Open : Status.Closed,
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays((i % 2 == 0) ? 2 : 3))
            };
        }
        modelBuilder.Entity<Ticket>().HasData(tickets);
    }
    
    // get one Descriptions array
    private string GetDescription(int index) {
        string[] descriptions = new[]
        {
                "Promotion code issued",
                "Additional user account",
                "Change payment method",
                "Activate account",
                "Great job",
                "Another great job",
                "Help with login",
                "Password reset requested",
                "Feedback on new feature",
                "Report a bug in the system",
                "Account deactivation request",
                "Request for feature enhancement",
                "Question about billing",
                "Technical support needed",
                "Inquiry about service availability",
                "Request for a refund",
                "Issue with mobile app",
                "Feedback on customer service",
                "Request to change username",
                "Clarification on terms of service",
                "Inquiry about data privacy",
                "Help with navigation on site",
                "Request to merge accounts",
                "Suggestion for product improvement",
                "Notification of suspicious activity",
                "Request for API access",
                "Report missing items from order",
                "Issue with payment processing",
                "Account verification needed",
                "Inquiry about subscription plans",
                "Request for training materials",
                "Bug in checkout process",
                "Feedback on recent update",
                "Help with account recovery",
                "Request for historical data",
                "Notification of account changes",
                "Request for appointment scheduling",
                "Question about loyalty program",
                "Change of address request",
                "Report an outage",
                "Request for user permissions",
                "Help with email notifications",
                "Feedback on promotional offers",
                "Inquiry about technical specifications",
                "Request for data export",
                "Change in service terms",
                "Issue with third-party integration",
                "Request to change billing address",
                "Feedback on usability",
                "Request for product demonstration",
                "Inquiry about warranty",
                "Help with system compatibility",
                "Report incorrect information on profile",
                "Request for consultation",
                "Feedback on user interface",
                "Request for partnership",
                "Inquiry about corporate accounts",
                "Request for marketing materials",
                "Help with device setup",
                "Feedback on sales process",
                "Question about industry trends",
                "Request for testimonials",
                "Notification of policy changes",
                "Request for community guidelines",
                "Feedback on email campaigns",
                "Inquiry about service levels",
                "Help with feature usage",
                "Request for additional storage",
                "Question about security measures",
                "Feedback on training sessions",
                "Help with troubleshooting",
                "Inquiry about integration services",
                "Request for user group membership",
                "Feedback on website content",
                "Request for account statement",
                "Question about product features",
                "Help with user permissions",
                "Request for support documentation",
                "Inquiry about pricing",
                "Feedback on new product release",
                "Request for system updates",
                "Notification of billing issues",
                "Help with payment options",
                "Request for historical reports",
                "Inquiry about upcoming features",
                "Request for API documentation",
                "Feedback on user experience",
                "Question about software updates",
                "Help with licensing",
                "Request for troubleshooting assistance",
                "Feedback on user feedback",
                "Inquiry about online resources",
                "Help with setting up notifications",
                "Request for usage statistics",
                "Question about product comparisons",
                "Feedback on support channels",
                "Help with accessing reports",
                "Request for data accuracy check",
                "Inquiry about team accounts",
                "Feedback on technical documentation"
            };
        return descriptions[index];
    }
}