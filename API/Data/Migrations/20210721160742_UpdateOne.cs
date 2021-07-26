using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class UpdateOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_Associates_AssociateId",
                table: "Specializations");

            migrationBuilder.DropIndex(
                name: "IX_Specializations_AssociateId",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "AssociateId",
                table: "Specializations");

            migrationBuilder.AddColumn<int>(
                name: "SpecializationId",
                table: "Associates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Associates_SpecializationId",
                table: "Associates",
                column: "SpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associates_Specializations_SpecializationId",
                table: "Associates",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associates_Specializations_SpecializationId",
                table: "Associates");

            migrationBuilder.DropIndex(
                name: "IX_Associates_SpecializationId",
                table: "Associates");

            migrationBuilder.DropColumn(
                name: "SpecializationId",
                table: "Associates");

            migrationBuilder.AddColumn<int>(
                name: "AssociateId",
                table: "Specializations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_AssociateId",
                table: "Specializations",
                column: "AssociateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_Associates_AssociateId",
                table: "Specializations",
                column: "AssociateId",
                principalTable: "Associates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
