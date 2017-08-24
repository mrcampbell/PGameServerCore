using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PGameServerCore.RestAPI.Migrations
{
    public partial class fix_trainer_field_in_pokemon_from_guid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trainer",
                table: "Pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_TrainerId",
                table: "Pokemon",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Trainer_TrainerId",
                table: "Pokemon",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Trainer_TrainerId",
                table: "Pokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_TrainerId",
                table: "Pokemon");

            migrationBuilder.AddColumn<Guid>(
                name: "Trainer",
                table: "Pokemon",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
