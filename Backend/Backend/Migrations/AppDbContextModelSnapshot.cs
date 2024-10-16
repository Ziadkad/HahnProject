﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.Entities.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Promotion code issued",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 2,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Additional user account",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 3,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Change payment method",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 4,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Activate account",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 5,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Great job",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 6,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Another great job",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 7,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with login",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 8,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Password reset requested",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 9,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Feedback on new feature",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 10,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Report a bug in the system",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 11,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Account deactivation request",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 12,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for feature enhancement",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 13,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Question about billing",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 14,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Technical support needed",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 15,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Inquiry about service availability",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 16,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for a refund",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 17,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Issue with mobile app",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 18,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Feedback on customer service",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 19,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request to change username",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 20,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Clarification on terms of service",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 21,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Inquiry about data privacy",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 22,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Help with navigation on site",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 23,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request to merge accounts",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 24,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Suggestion for product improvement",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 25,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Notification of suspicious activity",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 26,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for API access",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 27,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Report missing items from order",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 28,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Issue with payment processing",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 29,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Account verification needed",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 30,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Inquiry about subscription plans",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 31,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request for training materials",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 32,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Bug in checkout process",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 33,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Feedback on recent update",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 34,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Help with account recovery",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 35,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request for historical data",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 36,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Notification of account changes",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 37,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request for appointment scheduling",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 38,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Question about loyalty program",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 39,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Change of address request",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 40,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Report an outage",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 41,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request for user permissions",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 42,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Help with email notifications",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 43,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Feedback on promotional offers",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 44,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Inquiry about technical specifications",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 45,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request for data export",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 46,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Change in service terms",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 47,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Issue with third-party integration",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 48,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request to change billing address",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 49,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Feedback on usability",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 50,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for product demonstration",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 51,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Inquiry about warranty",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 52,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Help with system compatibility",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 53,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Report incorrect information on profile",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 54,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for consultation",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 55,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Feedback on user interface",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 56,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for partnership",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 57,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Inquiry about corporate accounts",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 58,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for marketing materials",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 59,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with device setup",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 60,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Feedback on sales process",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 61,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Question about industry trends",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 62,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for testimonials",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 63,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Notification of policy changes",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 64,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for community guidelines",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 65,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Feedback on email campaigns",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 66,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Inquiry about service levels",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 67,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with feature usage",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 68,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for additional storage",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 69,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Question about security measures",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 70,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Feedback on training sessions",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 71,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with troubleshooting",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 72,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Inquiry about integration services",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 73,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request for user group membership",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 74,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Feedback on website content",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 75,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request for account statement",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 76,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Question about product features",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 77,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with user permissions",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 78,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for support documentation",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 79,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Inquiry about pricing",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 80,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Feedback on new product release",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 81,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Request for system updates",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 82,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Notification of billing issues",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 83,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with payment options",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 84,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for historical reports",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 85,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Inquiry about upcoming features",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 86,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for API documentation",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 87,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Feedback on user experience",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 88,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Question about software updates",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 89,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with licensing",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 90,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for troubleshooting assistance",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 91,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Feedback on user feedback",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 92,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Inquiry about online resources",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 93,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with setting up notifications",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 94,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for usage statistics",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 95,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Question about product comparisons",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 96,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Feedback on support channels",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 97,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Help with accessing reports",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 98,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Request for data accuracy check",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 99,
                            Date = new DateOnly(2024, 10, 18),
                            Description = "Inquiry about team accounts",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 100,
                            Date = new DateOnly(2024, 10, 19),
                            Description = "Feedback on technical documentation",
                            Status = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
