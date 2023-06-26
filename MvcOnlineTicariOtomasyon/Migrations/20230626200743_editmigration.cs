using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    /// <inheritdoc />
    public partial class editmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carilers_SatisHarekets_SatisHareketSatisid",
                table: "Carilers");

            migrationBuilder.DropForeignKey(
                name: "FK_Personels_SatisHarekets_SatisHareketSatisid",
                table: "Personels");

            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_SatisHarekets_SatisHareketSatisid",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Uruns_SatisHareketSatisid",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Personels_SatisHareketSatisid",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Carilers_SatisHareketSatisid",
                table: "Carilers");

            migrationBuilder.DropColumn(
                name: "SatisHareketSatisid",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "SatisHareketSatisid",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "SatisHareketSatisid",
                table: "Carilers");

            migrationBuilder.AddColumn<int>(
                name: "CarilerCariid",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Personelid",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_CarilerCariid",
                table: "SatisHarekets",
                column: "CarilerCariid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_Personelid",
                table: "SatisHarekets",
                column: "Personelid");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_UrunId",
                table: "SatisHarekets",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Carilers_CarilerCariid",
                table: "SatisHarekets",
                column: "CarilerCariid",
                principalTable: "Carilers",
                principalColumn: "Cariid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Personels_Personelid",
                table: "SatisHarekets",
                column: "Personelid",
                principalTable: "Personels",
                principalColumn: "Personelid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Uruns_UrunId",
                table: "SatisHarekets",
                column: "UrunId",
                principalTable: "Uruns",
                principalColumn: "UrunId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Carilers_CarilerCariid",
                table: "SatisHarekets");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Personels_Personelid",
                table: "SatisHarekets");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Uruns_UrunId",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_CarilerCariid",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_Personelid",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_UrunId",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "CarilerCariid",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "Personelid",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "SatisHarekets");

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketSatisid",
                table: "Uruns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketSatisid",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketSatisid",
                table: "Carilers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_SatisHareketSatisid",
                table: "Uruns",
                column: "SatisHareketSatisid");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_SatisHareketSatisid",
                table: "Personels",
                column: "SatisHareketSatisid");

            migrationBuilder.CreateIndex(
                name: "IX_Carilers_SatisHareketSatisid",
                table: "Carilers",
                column: "SatisHareketSatisid");

            migrationBuilder.AddForeignKey(
                name: "FK_Carilers_SatisHarekets_SatisHareketSatisid",
                table: "Carilers",
                column: "SatisHareketSatisid",
                principalTable: "SatisHarekets",
                principalColumn: "Satisid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_SatisHarekets_SatisHareketSatisid",
                table: "Personels",
                column: "SatisHareketSatisid",
                principalTable: "SatisHarekets",
                principalColumn: "Satisid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_SatisHarekets_SatisHareketSatisid",
                table: "Uruns",
                column: "SatisHareketSatisid",
                principalTable: "SatisHarekets",
                principalColumn: "Satisid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
