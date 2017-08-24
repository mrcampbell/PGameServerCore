using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PGameServerCore.RestAPI.Migrations
{
    public partial class create_user_update_poke_and_trnr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "EV_ATK",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "EV_DEF",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "EV_HP",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "EV_SPEC_ATK",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "EV_SPEC_DEF",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "EV_SPEED",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IV_ATK",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IV_DEF",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IV_HP",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IV_SPEC_ATK",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IV_SPEC_DEF",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "IV_SPEED",
                table: "Pokemon",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<Guid>(
                name: "Trainer",
                table: "Pokemon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TrainerId",
                table: "Pokemon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EV_ATK",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "EV_DEF",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "EV_HP",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "EV_SPEC_ATK",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "EV_SPEC_DEF",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "EV_SPEED",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "IV_ATK",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "IV_DEF",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "IV_HP",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "IV_SPEC_ATK",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "IV_SPEC_DEF",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "IV_SPEED",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "Trainer",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Pokemon");
        }
    }
}
