using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooAndAnimalFun.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalCategories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalCategories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ZIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "EventCategory",
                columns: table => new
                {
                    EventCategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventCategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AvailableToCustomers = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCategory", x => x.EventCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderID);
                });

            migrationBuilder.CreateTable(
                name: "HealthStatus",
                columns: table => new
                {
                    HealthStatusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HealthDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthStatus", x => x.HealthStatusId);
                });

            migrationBuilder.CreateTable(
                name: "TicketType",
                columns: table => new
                {
                    TicketTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TicketTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketType", x => x.TicketTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpeciesName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EventCategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesID);
                    table.ForeignKey(
                        name: "FK_Species_EventCategory_EventCategoryID",
                        column: x => x.EventCategoryID,
                        principalTable: "EventCategory",
                        principalColumn: "EventCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    AnimalID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GenderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HealthStatusID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpeciesID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.AnimalID);
                    table.ForeignKey(
                        name: "FK_Animal_Gender_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Gender",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_HealthStatus_HealthStatusID",
                        column: x => x.HealthStatusID,
                        principalTable: "HealthStatus",
                        principalColumn: "HealthStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_Species_SpeciesID",
                        column: x => x.SpeciesID,
                        principalTable: "Species",
                        principalColumn: "SpeciesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EventStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventCategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnimalID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Event_Animal_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animal",
                        principalColumn: "AnimalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_EventCategory_EventCategoryID",
                        column: x => x.EventCategoryID,
                        principalTable: "EventCategory",
                        principalColumn: "EventCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    VenueID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VenueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.VenueID);
                    table.ForeignKey(
                        name: "FK_Venue_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    SessionID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VenueID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.SessionID);
                    table.ForeignKey(
                        name: "FK_Session_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Session_Venue_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venue",
                        principalColumn: "VenueID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketSales",
                columns: table => new
                {
                    TicketID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateSold = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicableFor = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TicketTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SessionID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketSales", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_TicketSales_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketSales_Session_SessionID",
                        column: x => x.SessionID,
                        principalTable: "Session",
                        principalColumn: "SessionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketSales_TicketType_TicketTypeID",
                        column: x => x.TicketTypeID,
                        principalTable: "TicketType",
                        principalColumn: "TicketTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_GenderID",
                table: "Animal",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_HealthStatusID",
                table: "Animal",
                column: "HealthStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_SpeciesID",
                table: "Animal",
                column: "SpeciesID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_AnimalID",
                table: "Event",
                column: "AnimalID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventCategoryID",
                table: "Event",
                column: "EventCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Session_EventID",
                table: "Session",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Session_VenueID",
                table: "Session",
                column: "VenueID");

            migrationBuilder.CreateIndex(
                name: "IX_Species_EventCategoryID",
                table: "Species",
                column: "EventCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSales_CustomerID",
                table: "TicketSales",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSales_SessionID",
                table: "TicketSales",
                column: "SessionID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketSales_TicketTypeID",
                table: "TicketSales",
                column: "TicketTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Venue_EventID",
                table: "Venue",
                column: "EventID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalCategories");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "TicketSales");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "TicketType");

            migrationBuilder.DropTable(
                name: "Venue");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "HealthStatus");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "EventCategory");
        }
    }
}
