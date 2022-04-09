using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroundManagmentSystem.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ISA_Models",
                columns: table => new
                {
                    ISA_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISA_number = table.Column<long>(type: "bigint", nullable: false),
                    ISA_date_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISA_line = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISA_units = table.Column<int>(type: "int", nullable: false),
                    ISA_fba = table.Column<int>(type: "int", nullable: false),
                    ISA_semitrailer = table.Column<int>(type: "int", nullable: false),
                    ISA_fba_sea_container = table.Column<int>(type: "int", nullable: false),
                    ISA_fba_standard = table.Column<int>(type: "int", nullable: false),
                    ISA_lp = table.Column<int>(type: "int", nullable: false),
                    ISA_lp_value = table.Column<int>(type: "int", nullable: false),
                    ISA_parcel = table.Column<int>(type: "int", nullable: false),
                    ISA_parcel_value = table.Column<int>(type: "int", nullable: false),
                    ISA_mono = table.Column<int>(type: "int", nullable: false),
                    ISA_mono_value = table.Column<int>(type: "int", nullable: false),
                    ISA_pax = table.Column<int>(type: "int", nullable: false),
                    ISA_pax_value = table.Column<int>(type: "int", nullable: false),
                    ISA_ra = table.Column<int>(type: "int", nullable: false),
                    ISA_ra_value = table.Column<int>(type: "int", nullable: false),
                    ISA_rb = table.Column<int>(type: "int", nullable: false),
                    ISA_rb_value = table.Column<int>(type: "int", nullable: false),
                    ISA_rh = table.Column<int>(type: "int", nullable: false),
                    ISA_rh_value = table.Column<int>(type: "int", nullable: false),
                    ISA_rap = table.Column<int>(type: "int", nullable: false),
                    ISA_rap_value = table.Column<int>(type: "int", nullable: false),
                    ISA_rbp = table.Column<int>(type: "int", nullable: false),
                    ISA_rbp_value = table.Column<int>(type: "int", nullable: false),
                    ISA_rhp = table.Column<int>(type: "int", nullable: false),
                    ISA_rhp_value = table.Column<int>(type: "int", nullable: false),
                    ISA_ac = table.Column<int>(type: "int", nullable: false),
                    ISA_ac_value = table.Column<int>(type: "int", nullable: false),
                    ISA_bc = table.Column<int>(type: "int", nullable: false),
                    ISA_bc_value = table.Column<int>(type: "int", nullable: false),
                    ISA_hc = table.Column<int>(type: "int", nullable: false),
                    ISA_hc_value = table.Column<int>(type: "int", nullable: false),
                    ISA_to_chceck = table.Column<bool>(type: "bit", nullable: false),
                    ISA_comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISA_last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISA_Models", x => x.ISA_id);
                });

            migrationBuilder.CreateTable(
                name: "Line_Models",
                columns: table => new
                {
                    LINE_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LINE_number = table.Column<int>(type: "int", nullable: false),
                    LINE_asign_isa = table.Column<int>(type: "int", nullable: false),
                    LINE_units = table.Column<int>(type: "int", nullable: false),
                    LINE_to_check = table.Column<short>(type: "smallint", nullable: false),
                    LINE_lp = table.Column<short>(type: "smallint", nullable: false),
                    LINE_parcel = table.Column<short>(type: "smallint", nullable: false),
                    LINE_mono = table.Column<short>(type: "smallint", nullable: false),
                    LINE_pax = table.Column<short>(type: "smallint", nullable: false),
                    LINE_ra = table.Column<short>(type: "smallint", nullable: false),
                    LINE_rb = table.Column<short>(type: "smallint", nullable: false),
                    LINE_rh = table.Column<short>(type: "smallint", nullable: false),
                    LINE_rap = table.Column<short>(type: "smallint", nullable: false),
                    LINE_rbp = table.Column<short>(type: "smallint", nullable: false),
                    LINE_rhp = table.Column<short>(type: "smallint", nullable: false),
                    LINE_ac = table.Column<short>(type: "smallint", nullable: false),
                    LINE_bc = table.Column<short>(type: "smallint", nullable: false),
                    LINE_hc = table.Column<short>(type: "smallint", nullable: false),
                    LINE_fba = table.Column<short>(type: "smallint", nullable: false),
                    LINE_sea_container = table.Column<short>(type: "smallint", nullable: false),
                    LINE_standard = table.Column<short>(type: "smallint", nullable: false),
                    LINE_semitrailer = table.Column<short>(type: "smallint", nullable: false),
                    LINE_comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Line_Models", x => x.LINE_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ISA_Models");

            migrationBuilder.DropTable(
                name: "Line_Models");
        }
    }
}
