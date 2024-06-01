using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DersAdi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.DersId);
                });

            migrationBuilder.CreateTable(
                name: "Mudurler",
                columns: table => new
                {
                    MudurId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: false),
                    Soyad = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Sifre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mudurler", x => x.MudurId);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: false),
                    Soyad = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Sifre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciId);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmenler",
                columns: table => new
                {
                    OgretmenId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: false),
                    Soyad = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Sifre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmenler", x => x.OgretmenId);
                });

            migrationBuilder.CreateTable(
                name: "DersProgramlari",
                columns: table => new
                {
                    DersProgramiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DersId = table.Column<int>(type: "integer", nullable: false),
                    Gun = table.Column<string>(type: "text", nullable: false),
                    Saat = table.Column<string>(type: "text", nullable: false),
                    Sinif = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersProgramlari", x => x.DersProgramiId);
                    table.ForeignKey(
                        name: "FK_DersProgramlari_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notlar",
                columns: table => new
                {
                    NotId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Vize = table.Column<int>(type: "integer", nullable: false),
                    Final = table.Column<int>(type: "integer", nullable: false),
                    OgrenciId = table.Column<int>(type: "integer", nullable: false),
                    DersId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlar", x => x.NotId);
                    table.ForeignKey(
                        name: "FK_Notlar_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notlar_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DersProgramiOgretmen",
                columns: table => new
                {
                    DersProgramlariDersProgramiId = table.Column<int>(type: "integer", nullable: false),
                    OgretmenlerOgretmenId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersProgramiOgretmen", x => new { x.DersProgramlariDersProgramiId, x.OgretmenlerOgretmenId });
                    table.ForeignKey(
                        name: "FK_DersProgramiOgretmen_DersProgramlari_DersProgramlariDersPro~",
                        column: x => x.DersProgramlariDersProgramiId,
                        principalTable: "DersProgramlari",
                        principalColumn: "DersProgramiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersProgramiOgretmen_Ogretmenler_OgretmenlerOgretmenId",
                        column: x => x.OgretmenlerOgretmenId,
                        principalTable: "Ogretmenler",
                        principalColumn: "OgretmenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDersProgrami",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "integer", nullable: false),
                    DersProgramiId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDersProgrami", x => new { x.OgrenciId, x.DersProgramiId });
                    table.ForeignKey(
                        name: "FK_OgrenciDersProgrami_DersProgramlari_DersProgramiId",
                        column: x => x.DersProgramiId,
                        principalTable: "DersProgramlari",
                        principalColumn: "DersProgramiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDersProgrami_Ogrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersProgramiOgretmen_OgretmenlerOgretmenId",
                table: "DersProgramiOgretmen",
                column: "OgretmenlerOgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgramlari_DersId",
                table: "DersProgramlari",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_DersId",
                table: "Notlar",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_OgrenciId",
                table: "Notlar",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersProgrami_DersProgramiId",
                table: "OgrenciDersProgrami",
                column: "DersProgramiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersProgramiOgretmen");

            migrationBuilder.DropTable(
                name: "Mudurler");

            migrationBuilder.DropTable(
                name: "Notlar");

            migrationBuilder.DropTable(
                name: "OgrenciDersProgrami");

            migrationBuilder.DropTable(
                name: "Ogretmenler");

            migrationBuilder.DropTable(
                name: "DersProgramlari");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Dersler");
        }
    }
}
