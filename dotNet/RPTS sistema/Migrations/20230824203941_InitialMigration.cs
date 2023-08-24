using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RPTS_sistema.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyRegistrationNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyFoundDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyCategory = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyAdress = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyEmail = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyPhone = table.Column<string>(type: "TEXT", nullable: false),
                    IsCompanyDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Conclusion",
                columns: table => new
                {
                    ConclusionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Decision = table.Column<string>(type: "TEXT", nullable: false),
                    IsConclusionDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conclusion", x => x.ConclusionId);
                });

            migrationBuilder.CreateTable(
                name: "LocalUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false),
                    StillWorking = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsUserDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdministrativeInspections",
                columns: table => new
                {
                    AdministrativeInspectionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    InspectionDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConclusionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativeInspections", x => x.AdministrativeInspectionId);
                    table.ForeignKey(
                        name: "FK_AdministrativeInspections_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdministrativeInspections_Conclusion_ConclusionId",
                        column: x => x.ConclusionId,
                        principalTable: "Conclusion",
                        principalColumn: "ConclusionId");
                });

            migrationBuilder.CreateTable(
                name: "Investigation",
                columns: table => new
                {
                    InvestigationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false),
                    LegalBase = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ConclusionId = table.Column<int>(type: "INTEGER", nullable: true),
                    CommissionDecision = table.Column<string>(type: "TEXT", nullable: true),
                    Penalty = table.Column<int>(type: "INTEGER", nullable: true),
                    DecisionComplained = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsInvestigationDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigation", x => x.InvestigationId);
                    table.ForeignKey(
                        name: "FK_Investigation_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Investigation_Conclusion_ConclusionId",
                        column: x => x.ConclusionId,
                        principalTable: "Conclusion",
                        principalColumn: "ConclusionId");
                });

            migrationBuilder.CreateTable(
                name: "Complain",
                columns: table => new
                {
                    ComplainId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Complainant = table.Column<string>(type: "TEXT", nullable: false),
                    ComplainDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DecisionDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsComplainDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    ConclusionId = table.Column<int>(type: "INTEGER", nullable: true),
                    InvestigatorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complain", x => x.ComplainId);
                    table.ForeignKey(
                        name: "FK_Complain_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complain_Conclusion_ConclusionId",
                        column: x => x.ConclusionId,
                        principalTable: "Conclusion",
                        principalColumn: "ConclusionId");
                    table.ForeignKey(
                        name: "FK_Complain_LocalUser_InvestigatorId",
                        column: x => x.InvestigatorId,
                        principalTable: "LocalUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdministrativeInspectionLocalUser",
                columns: table => new
                {
                    AdministrativeInspectionsAdministrativeInspectionId = table.Column<int>(type: "INTEGER", nullable: false),
                    InvestigatorsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdministrativeInspectionLocalUser", x => new { x.AdministrativeInspectionsAdministrativeInspectionId, x.InvestigatorsId });
                    table.ForeignKey(
                        name: "FK_AdministrativeInspectionLocalUser_AdministrativeInspections_AdministrativeInspectionsAdministrativeInspectionId",
                        column: x => x.AdministrativeInspectionsAdministrativeInspectionId,
                        principalTable: "AdministrativeInspections",
                        principalColumn: "AdministrativeInspectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdministrativeInspectionLocalUser_LocalUser_InvestigatorsId",
                        column: x => x.InvestigatorsId,
                        principalTable: "LocalUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvestigationLocalUser",
                columns: table => new
                {
                    InvestigationsInvestigationId = table.Column<int>(type: "INTEGER", nullable: false),
                    InvestigatorsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestigationLocalUser", x => new { x.InvestigationsInvestigationId, x.InvestigatorsId });
                    table.ForeignKey(
                        name: "FK_InvestigationLocalUser_Investigation_InvestigationsInvestigationId",
                        column: x => x.InvestigationsInvestigationId,
                        principalTable: "Investigation",
                        principalColumn: "InvestigationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvestigationLocalUser_LocalUser_InvestigatorsId",
                        column: x => x.InvestigatorsId,
                        principalTable: "LocalUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvestigationStage",
                columns: table => new
                {
                    InvestigationStageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Stage = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ComplainId = table.Column<int>(type: "INTEGER", nullable: true),
                    AdministrativeInspectionId = table.Column<int>(type: "INTEGER", nullable: true),
                    InvestigationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestigationStage", x => x.InvestigationStageId);
                    table.ForeignKey(
                        name: "FK_InvestigationStage_AdministrativeInspections_AdministrativeInspectionId",
                        column: x => x.AdministrativeInspectionId,
                        principalTable: "AdministrativeInspections",
                        principalColumn: "AdministrativeInspectionId");
                    table.ForeignKey(
                        name: "FK_InvestigationStage_Complain_ComplainId",
                        column: x => x.ComplainId,
                        principalTable: "Complain",
                        principalColumn: "ComplainId");
                    table.ForeignKey(
                        name: "FK_InvestigationStage_Investigation_InvestigationId",
                        column: x => x.InvestigationId,
                        principalTable: "Investigation",
                        principalColumn: "InvestigationId");
                });

            migrationBuilder.InsertData(
                table: "Conclusion",
                columns: new[] { "ConclusionId", "Decision", "IsConclusionDeleted" },
                values: new object[,]
                {
                    { 1, "Skundas atmestas", false },
                    { 2, "Skundas priimtas", false },
                    { 3, "Pažeidimų nenustatyta", false },
                    { 4, "Nustatytas pažeidimas, pradėtas pažeidimo tyrimas", false },
                    { 5, "Nustatytas pažeidimas, tačiau pažeidimo tyrimas nepradėtas, nes įmonė laikoma nauju ūkio subjektu", false },
                    { 6, "Nutraukta dėl mažareikšmiškumo", false },
                    { 7, "Pažeidimo tyrimas baigtas, byloje priimtas sprendimas skirti baudą", false },
                    { 8, "Pažeidimo tyrimas baigtas, byloje priimtas tyrimą nutraukti", false }
                });

            migrationBuilder.InsertData(
                table: "LocalUser",
                columns: new[] { "Id", "Email", "IsUserDeleted", "Lastname", "Name", "PasswordHash", "PasswordSalt", "Role", "StillWorking" },
                values: new object[,]
                {
                    { 1, "justinaskersys@gmail.com", false, "Admin", "Admin", new byte[] { 132, 36, 215, 21, 156, 232, 87, 79, 54, 42, 249, 117, 29, 249, 254, 130, 233, 191, 157, 238, 61, 39, 113, 206, 133, 202, 108, 6, 59, 22, 149, 96 }, new byte[] { 19, 240, 169, 179, 104, 34, 119, 10, 29, 142, 158, 51, 8, 185, 48, 120, 142, 170, 230, 96, 184, 67, 120, 128, 255, 250, 247, 153, 248, 45, 102, 32, 189, 57, 144, 51, 23, 89, 141, 244, 69, 86, 56, 187, 29, 76, 202, 99, 251, 222, 190, 162, 139, 132, 233, 98, 255, 46, 159, 181, 149, 109, 178, 93 }, 2, true },
                    { 2, "v.dabulskiene@litfood.lt", false, "Dabulskienė", "Veronika", new byte[] { 48, 162, 141, 110, 205, 200, 17, 238, 135, 29, 161, 206, 236, 172, 27, 174, 115, 169, 42, 222, 0, 119, 245, 252, 215, 14, 117, 219, 205, 55, 158, 196 }, new byte[] { 237, 144, 93, 64, 95, 104, 160, 77, 141, 223, 119, 39, 85, 223, 211, 222, 100, 115, 117, 46, 84, 224, 239, 128, 42, 39, 137, 243, 149, 50, 49, 193, 9, 251, 38, 112, 196, 54, 104, 234, 151, 151, 82, 226, 58, 225, 187, 206, 66, 226, 248, 3, 119, 24, 249, 82, 0, 31, 55, 43, 59, 238, 212, 92 }, 0, true },
                    { 3, "i.baltusis@litfood.lt", false, "Baltūsis", "Irmantas", new byte[] { 237, 133, 157, 232, 192, 251, 75, 62, 159, 197, 98, 238, 179, 199, 241, 70, 227, 156, 163, 183, 159, 65, 38, 85, 8, 237, 244, 17, 136, 229, 56, 206 }, new byte[] { 69, 55, 180, 88, 195, 37, 90, 251, 164, 195, 160, 215, 240, 209, 91, 16, 150, 149, 0, 59, 120, 61, 14, 2, 205, 193, 252, 115, 207, 104, 143, 33, 152, 1, 146, 0, 212, 200, 5, 136, 159, 159, 192, 194, 114, 69, 170, 159, 73, 26, 118, 28, 131, 116, 144, 159, 26, 200, 230, 157, 90, 172, 123, 157 }, 0, true },
                    { 4, "a.marcinkus@litfood.lt", false, "Marcinkus", "Audrius", new byte[] { 242, 21, 106, 162, 18, 207, 10, 139, 215, 204, 142, 227, 226, 221, 168, 247, 19, 199, 194, 47, 170, 185, 183, 14, 53, 12, 237, 140, 21, 106, 160, 183 }, new byte[] { 1, 195, 213, 58, 79, 52, 166, 192, 153, 164, 76, 235, 82, 38, 57, 200, 143, 37, 52, 221, 120, 107, 204, 191, 116, 209, 122, 78, 0, 238, 250, 103, 139, 104, 97, 97, 181, 14, 45, 45, 251, 210, 184, 228, 37, 197, 190, 73, 58, 11, 246, 250, 117, 68, 222, 178, 244, 22, 234, 85, 14, 216, 93, 114 }, 1, true },
                    { 5, "g.markeviciute@litfood.lt", false, "Markevičiūtė", "Gabrielė", new byte[] { 249, 48, 58, 205, 159, 45, 83, 85, 116, 178, 222, 15, 152, 2, 232, 182, 188, 194, 75, 253, 194, 17, 142, 251, 167, 207, 20, 166, 195, 108, 129, 175 }, new byte[] { 104, 123, 232, 40, 188, 251, 127, 96, 44, 138, 138, 231, 50, 120, 77, 87, 133, 94, 121, 141, 104, 195, 211, 147, 119, 225, 94, 86, 244, 214, 253, 58, 55, 238, 124, 171, 3, 183, 76, 239, 186, 241, 133, 218, 61, 9, 42, 251, 193, 134, 232, 242, 173, 61, 195, 143, 230, 137, 96, 247, 43, 146, 175, 117 }, 0, true },
                    { 6, "j.kersys@litfood.lt", false, "Keršys", "Justinas", new byte[] { 158, 156, 88, 108, 185, 164, 4, 15, 157, 194, 155, 82, 94, 190, 18, 61, 123, 106, 234, 105, 22, 5, 81, 68, 237, 244, 17, 31, 120, 152, 214, 59 }, new byte[] { 142, 96, 90, 12, 29, 38, 128, 9, 238, 159, 113, 235, 155, 115, 230, 51, 142, 192, 51, 26, 137, 148, 88, 151, 208, 246, 135, 173, 111, 136, 1, 84, 71, 164, 222, 179, 133, 96, 148, 224, 134, 140, 199, 157, 120, 204, 187, 181, 54, 11, 58, 93, 193, 226, 52, 59, 117, 149, 209, 227, 64, 3, 200, 3 }, 0, true },
                    { 7, "l.matuseviciene@litfood.lt", false, "Matusevičienė", "Laura", new byte[] { 85, 35, 27, 7, 6, 176, 203, 55, 174, 38, 251, 216, 134, 191, 234, 183, 65, 96, 173, 229, 37, 126, 221, 57, 24, 32, 219, 87, 234, 18, 56, 78 }, new byte[] { 222, 58, 232, 235, 119, 161, 74, 21, 83, 72, 251, 80, 158, 129, 186, 63, 103, 1, 158, 237, 28, 216, 61, 153, 22, 161, 121, 42, 154, 154, 190, 35, 192, 44, 219, 36, 16, 4, 40, 30, 244, 20, 179, 112, 126, 99, 148, 175, 40, 34, 40, 231, 14, 12, 37, 132, 238, 31, 39, 75, 73, 226, 186, 145 }, 0, true },
                    { 8, "i.zlatkus@litfood.lt", false, "Zlatkus", "Ignas", new byte[] { 86, 243, 28, 245, 39, 164, 199, 225, 226, 242, 28, 216, 133, 11, 22, 18, 76, 18, 177, 127, 150, 187, 253, 191, 244, 85, 213, 86, 197, 92, 172, 242 }, new byte[] { 249, 51, 218, 143, 91, 110, 254, 96, 127, 104, 3, 230, 154, 230, 136, 230, 112, 252, 236, 3, 44, 221, 231, 170, 3, 182, 224, 209, 24, 6, 82, 175, 71, 48, 207, 1, 209, 3, 79, 212, 108, 86, 217, 99, 127, 39, 236, 133, 18, 125, 151, 3, 145, 113, 3, 93, 128, 62, 49, 86, 113, 246, 194, 18 }, 0, true },
                    { 9, "g.markeviciene@litfood.lt", false, "Markevičienė", "Giedrė", new byte[] { 144, 255, 219, 29, 76, 5, 20, 189, 208, 140, 208, 95, 58, 73, 101, 255, 10, 106, 82, 88, 197, 70, 123, 81, 141, 107, 120, 4, 78, 98, 242, 194 }, new byte[] { 128, 96, 66, 95, 115, 252, 181, 244, 31, 84, 49, 166, 212, 218, 19, 4, 152, 92, 230, 12, 205, 231, 175, 96, 92, 47, 144, 140, 253, 164, 192, 169, 153, 106, 210, 182, 202, 182, 9, 85, 220, 253, 170, 207, 47, 237, 183, 136, 81, 3, 46, 78, 207, 127, 168, 103, 237, 248, 33, 140, 171, 86, 216, 209 }, 0, true },
                    { 10, "l.danauskiene@litfood.lt", false, "Danauskienė", "Lina", new byte[] { 27, 67, 178, 25, 114, 192, 214, 231, 88, 133, 77, 69, 51, 54, 80, 243, 57, 168, 81, 234, 127, 183, 73, 113, 250, 108, 106, 113, 181, 108, 17, 238 }, new byte[] { 189, 112, 31, 237, 12, 12, 93, 240, 201, 215, 185, 250, 151, 205, 173, 129, 19, 10, 77, 68, 244, 135, 186, 131, 11, 87, 25, 133, 154, 181, 69, 215, 17, 72, 154, 215, 45, 196, 158, 224, 216, 225, 174, 228, 67, 70, 236, 71, 174, 148, 123, 142, 116, 64, 241, 83, 23, 241, 101, 245, 156, 59, 94, 193 }, 0, true },
                    { 11, "z.kraveciene@litfood.lt", false, "Kravecienė", "Žyvilė", new byte[] { 135, 230, 248, 120, 51, 200, 139, 26, 103, 235, 179, 185, 221, 58, 86, 109, 29, 206, 110, 222, 105, 197, 172, 248, 136, 14, 202, 166, 88, 30, 71, 231 }, new byte[] { 39, 203, 106, 178, 172, 93, 237, 205, 240, 53, 255, 116, 121, 96, 122, 126, 73, 75, 211, 48, 86, 236, 177, 20, 125, 149, 134, 222, 243, 103, 45, 138, 172, 205, 183, 16, 141, 70, 139, 112, 233, 232, 26, 102, 74, 164, 93, 54, 3, 22, 91, 241, 51, 191, 231, 2, 203, 236, 214, 148, 161, 194, 136, 79 }, 0, true },
                    { 12, "a.karvelis@litfood.lt", false, "Karvelis", "Audrius", new byte[] { 27, 119, 229, 143, 172, 246, 241, 106, 66, 134, 70, 249, 63, 78, 167, 85, 10, 205, 39, 252, 37, 239, 124, 34, 43, 131, 161, 158, 149, 255, 165, 222 }, new byte[] { 24, 96, 195, 186, 22, 52, 50, 192, 144, 29, 233, 202, 201, 114, 37, 210, 172, 94, 35, 81, 164, 214, 103, 12, 245, 128, 83, 45, 110, 203, 204, 189, 200, 173, 189, 140, 77, 179, 32, 152, 31, 174, 22, 67, 81, 105, 95, 219, 129, 136, 41, 73, 64, 35, 38, 80, 174, 166, 222, 111, 133, 234, 20, 36 }, 0, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativeInspectionLocalUser_InvestigatorsId",
                table: "AdministrativeInspectionLocalUser",
                column: "InvestigatorsId");

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativeInspections_CompanyId",
                table: "AdministrativeInspections",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AdministrativeInspections_ConclusionId",
                table: "AdministrativeInspections",
                column: "ConclusionId");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_CompanyId",
                table: "Complain",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_ConclusionId",
                table: "Complain",
                column: "ConclusionId");

            migrationBuilder.CreateIndex(
                name: "IX_Complain_InvestigatorId",
                table: "Complain",
                column: "InvestigatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigation_CompanyId",
                table: "Investigation",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigation_ConclusionId",
                table: "Investigation",
                column: "ConclusionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestigationLocalUser_InvestigatorsId",
                table: "InvestigationLocalUser",
                column: "InvestigatorsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestigationStage_AdministrativeInspectionId",
                table: "InvestigationStage",
                column: "AdministrativeInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestigationStage_ComplainId",
                table: "InvestigationStage",
                column: "ComplainId");

            migrationBuilder.CreateIndex(
                name: "IX_InvestigationStage_InvestigationId",
                table: "InvestigationStage",
                column: "InvestigationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdministrativeInspectionLocalUser");

            migrationBuilder.DropTable(
                name: "InvestigationLocalUser");

            migrationBuilder.DropTable(
                name: "InvestigationStage");

            migrationBuilder.DropTable(
                name: "AdministrativeInspections");

            migrationBuilder.DropTable(
                name: "Complain");

            migrationBuilder.DropTable(
                name: "Investigation");

            migrationBuilder.DropTable(
                name: "LocalUser");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Conclusion");
        }
    }
}
