using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroundManagmentSystem.Migrations
{
    public partial class MySql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ISA_Models",
                columns: table => new
                {
                    ISA_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ISA_number = table.Column<long>(type: "bigint", nullable: false),
                    ISA_date_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    ISA_line = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    ISA_to_chceck = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ISA_comment = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ISA_last_update = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISA_Models", x => x.ISA_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ISA_Models");
        }
    }
}
