using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RehabDataProject.Migrations
{
    /// <inheritdoc />
    public partial class AddPatientOldToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientsOld",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KneeROM = table.Column<double>(type: "float", nullable: false),
                    KneeStrength = table.Column<int>(type: "int", nullable: false),
                    LowerbackExtROM = table.Column<double>(type: "float", nullable: false),
                    LowerBackFlexionROM = table.Column<double>(type: "float", nullable: false),
                    PainFreeWeightLifted = table.Column<int>(type: "int", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsOld", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientsOld");
        }
    }
}
