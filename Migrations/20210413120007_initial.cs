using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MFBAdminMBlazorServer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mfb_disclosure_first_part_item",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regulation_code = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    seq = table.Column<int>(type: "int", nullable: true),
                    item_code = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    item_description = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    item_show_flags = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true, defaultValueSql: "(suser_sname())"),
                    now = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mfb_disclosure_first_part_item", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mfb_disclosure_second_part_item",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regulation_code = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    publish_moment = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_from = table.Column<DateTime>(type: "date", nullable: false),
                    date_to = table.Column<DateTime>(type: "date", nullable: true),
                    frequency = table.Column<int>(type: "int", nullable: false),
                    seq = table.Column<int>(type: "int", nullable: true),
                    item_code = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    item_number = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    item_description = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    item_type = table.Column<int>(type: "int", nullable: false),
                    item_value = table.Column<string>(type: "varchar(4096)", unicode: false, maxLength: 4096, nullable: true),
                    extra_details = table.Column<string>(type: "varchar(4096)", unicode: false, maxLength: 4096, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true, defaultValueSql: "(suser_sname())"),
                    now = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mfb_disclosure_second_part_item", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mfb_fine_rate",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    report_date = table.Column<DateTime>(type: "date", nullable: true),
                    currency_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    currency_name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    asset_code = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    asset_name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    asset_isin = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    fine_short_victim = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_long_victim = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_short_guilty = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_long_guilty = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_short_donor = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_long_donor = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    base_limit = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    base_limit_surprise = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    mr_stress = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    group_name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mfb_fine_rate", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mfb_fine_rate_hist",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    report_date = table.Column<DateTime>(type: "date", nullable: true),
                    currency_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    currency_name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    asset_code = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    asset_name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    asset_isin = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    fine_short_victim = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_long_victim = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_short_guilty = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_long_guilty = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_short_donor = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    fine_long_donor = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    base_limit = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    base_limit_surprise = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    mr_stress = table.Column<decimal>(type: "numeric(16,6)", nullable: true),
                    group_name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mfb_fine_rate_hist", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mfb_disclosure_first_part_item_list",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idp = table.Column<long>(type: "bigint", nullable: false),
                    seq = table.Column<int>(type: "int", nullable: true),
                    publish_moment = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_from = table.Column<DateTime>(type: "date", nullable: true),
                    date_to = table.Column<DateTime>(type: "date", nullable: true),
                    item_list_desc = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: true),
                    item_list_value = table.Column<string>(type: "varchar(4096)", unicode: false, maxLength: 4096, nullable: true),
                    item_list_type = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true, defaultValueSql: "(suser_sname())"),
                    now = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    item_list_category = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    memo = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mfb_disclosure_first_part_item_list", x => x.id);
                    table.ForeignKey(
                        name: "FK_mfb_disclosure_first_part_item_list_mfb_disclosure_first_part_item",
                        column: x => x.idp,
                        principalTable: "mfb_disclosure_first_part_item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mfb_disclosure_second_part_item_list",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idp = table.Column<long>(type: "bigint", nullable: false),
                    seq = table.Column<int>(type: "int", nullable: true),
                    item_list_category = table.Column<string>(type: "varchar(1024)", unicode: false, maxLength: 1024, nullable: true),
                    item_list_desc = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: true),
                    item_list_value = table.Column<string>(type: "varchar(4096)", unicode: false, maxLength: 4096, nullable: true),
                    item_list_type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mfb_disclosure_second_part_item_list", x => x.id);
                    table.ForeignKey(
                        name: "FK_mfb_disclosure_second_part_item_list_mfb_disclosure_second_part_item",
                        column: x => x.idp,
                        principalTable: "mfb_disclosure_second_part_item",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mfb_disclosure_first_part_item_list_idp",
                table: "mfb_disclosure_first_part_item_list",
                column: "idp");

            migrationBuilder.CreateIndex(
                name: "IX_mfb_disclosure_second_part_item_list_idp",
                table: "mfb_disclosure_second_part_item_list",
                column: "idp");

            migrationBuilder.CreateIndex(
                name: "IX_mfb_fine_rate_report_date",
                table: "mfb_fine_rate",
                column: "report_date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mfb_disclosure_first_part_item_list");

            migrationBuilder.DropTable(
                name: "mfb_disclosure_second_part_item_list");

            migrationBuilder.DropTable(
                name: "mfb_fine_rate");

            migrationBuilder.DropTable(
                name: "mfb_fine_rate_hist");

            migrationBuilder.DropTable(
                name: "mfb_disclosure_first_part_item");

            migrationBuilder.DropTable(
                name: "mfb_disclosure_second_part_item");
        }
    }
}
