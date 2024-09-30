using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TATU.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MasterId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Masters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkExperience = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDismissed = table.Column<bool>(type: "bit", nullable: false),
                    PhotoAvatarLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotosWorksLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masters", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MasterId",
                table: "Orders",
                column: "MasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Masters_MasterId",
                table: "Orders",
                column: "MasterId",
                principalTable: "Masters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Masters_MasterId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Masters");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MasterId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MasterId",
                table: "Orders");
        }
    }
}
