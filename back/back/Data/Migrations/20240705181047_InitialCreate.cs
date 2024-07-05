using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Polls",
                columns: table => new
                {
                    PollId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowComments = table.Column<bool>(type: "bit", nullable: false),
                    PollType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls", x => x.PollId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedSettings",
                columns: table => new
                {
                    PollId = table.Column<int>(type: "int", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowComments = table.Column<bool>(type: "bit", nullable: false),
                    HideShareButton = table.Column<bool>(type: "bit", nullable: false),
                    ResultVisibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VotingSecurity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EditVotePermissions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedSettings", x => x.PollId);
                    table.ForeignKey(
                        name: "FK_AdvancedSettings_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageSettings",
                columns: table => new
                {
                    PollId = table.Column<int>(type: "int", nullable: false),
                    RequireName = table.Column<bool>(type: "bit", nullable: false),
                    VotingSecurity = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageSettings", x => x.PollId);
                    table.ForeignKey(
                        name: "FK_ImageSettings_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetingSettings",
                columns: table => new
                {
                    PollId = table.Column<int>(type: "int", nullable: false),
                    FixedTimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeedAnswer = table.Column<bool>(type: "bit", nullable: false),
                    OneOptionOnly = table.Column<bool>(type: "bit", nullable: false),
                    HideUnavailableOptions = table.Column<bool>(type: "bit", nullable: false),
                    CustomOptionLimits = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingSettings", x => x.PollId);
                    table.ForeignKey(
                        name: "FK_MeetingSettings_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MultipleChoiceSettings",
                columns: table => new
                {
                    PollId = table.Column<int>(type: "int", nullable: false),
                    RequireName = table.Column<bool>(type: "bit", nullable: false),
                    VotingSecurity = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultipleChoiceSettings", x => x.PollId);
                    table.ForeignKey(
                        name: "FK_MultipleChoiceSettings_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PollId = table.Column<int>(type: "int", nullable: false),
                    OptionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    OptionImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OptionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankingOption_OptionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankValue = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OptionId);
                    table.ForeignKey(
                        name: "FK_Options_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RankingSettings",
                columns: table => new
                {
                    PollId = table.Column<int>(type: "int", nullable: false),
                    RandomOrder = table.Column<bool>(type: "bit", nullable: false),
                    MaxPoints = table.Column<int>(type: "int", nullable: false),
                    RequireName = table.Column<bool>(type: "bit", nullable: false),
                    VotingSecurity = table.Column<int>(type: "int", nullable: false),
                    BlockVpnUsers = table.Column<bool>(type: "bit", nullable: false),
                    UseRecaptcha = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankingSettings", x => x.PollId);
                    table.ForeignKey(
                        name: "FK_RankingSettings_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    VoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VotedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.VoteId);
                    table.ForeignKey(
                        name: "FK_Votes_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "OptionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Votes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_PollId",
                table: "Options",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_OptionId",
                table: "Votes",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PollId",
                table: "Votes",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_UserId",
                table: "Votes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancedSettings");

            migrationBuilder.DropTable(
                name: "ImageSettings");

            migrationBuilder.DropTable(
                name: "MeetingSettings");

            migrationBuilder.DropTable(
                name: "MultipleChoiceSettings");

            migrationBuilder.DropTable(
                name: "RankingSettings");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Polls");
        }
    }
}
