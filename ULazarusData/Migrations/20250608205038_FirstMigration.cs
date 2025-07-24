using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ULazarusData.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.FacultyId);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    SectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FacultyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teachers_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: true),
                    SectorId = table.Column<int>(type: "int", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId");
                    table.ForeignKey(
                        name: "FK_Courses_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "SectorId");
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId");
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FacultyId = table.Column<int>(type: "int", nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Students_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "FacultyId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Students_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CourseResults",
                columns: table => new
                {
                    CourseResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseResults", x => x.CourseResultId);
                    table.ForeignKey(
                        name: "FK_CourseResults_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseResults_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "role-admin", null, "Admin", "ADMIN" },
                    { "role-student", null, "Student", "STUDENT" },
                    { "role-teacher", null, "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin1", 0, "STATIC-CONCURRENCY-1", "wasim@ulazarus.be", true, "Wasim", "Lazarus", false, null, "WASIM@ULAZARUS.BE", "WASIM@ULAZARUS.BE", null, null, false, "static-stamp-1", false, "wasim@ulazarus.be" },
                    { "admin2", 0, "STATIC-CONCURRENCY-2", "claire@ulazarus.be", true, "Claire", "Delacroix", false, null, "CLAIRE@ULAZARUS.BE", "CLAIRE@ULAZARUS.BE", null, null, false, "static-stamp-2", false, "claire@ulazarus.be" },
                    { "admin3", 0, "STATIC-CONCURRENCY-3", "jonas@ulazarus.be", true, "Jonas", "Vermeulen", false, null, "JONAS@ULAZARUS.BE", "JONAS@ULAZARUS.BE", null, null, false, "static-stamp-3", false, "jonas@ulazarus.be" },
                    { "Student1", 0, "STATIC-STAMP-1", "lotte.dewilde@ulazarus.be", true, "Lotte", "De Wilde", false, null, "LOTTE.DEWILDE@ULAZARUS.BE", "LOTTE.DEWILDE@ULAZARUS.BE", null, null, false, "Static-stamp-1", false, "lotte.dewilde@ulazarus.be" },
                    { "Student10", 0, "STATIC-STAMP-10", "ugo.desmet@ulazarus.be", true, "Ugo", "Desmet", false, null, "UGO.DESMET@ULAZARUS.BE", "UGO.DESMET@ULAZARUS.BE", null, null, false, "Static-stamp-10", false, "ugo.desmet@ulazarus.be" },
                    { "Student11", 0, "STATIC-STAMP-11", "valerie.vandenbroeck@ulazarus.be", true, "Valerie", "Van den Broeck", false, null, "VALERIE.VANDENBROECK@ULAZARUS.BE", "VALERIE.VANDENBROECK@ULAZARUS.BE", null, null, false, "Static-stamp-11", false, "valerie.vandenbroeck@ulazarus.be" },
                    { "Student12", 0, "STATIC-STAMP-12", "wout.smet@ulazarus.be", true, "Wout", "Smet", false, null, "WOUT.SMET@ULAZARUS.BE", "WOUT.SMET@ULAZARUS.BE", null, null, false, "Static-stamp-12", false, "wout.smet@ulazarus.be" },
                    { "Student13", 0, "STATIC-STAMP-13", "xander.vermeiren@ulazarus.be", true, "Xander", "Vermeiren", false, null, "XANDER.VERMEIREN@ULAZARUS.BE", "XANDER.VERMEIREN@ULAZARUS.BE", null, null, false, "Static-stamp-13", false, "xander.vermeiren@ulazarus.be" },
                    { "Student14", 0, "STATIC-STAMP-14", "yana.desmet@ulazarus.be", true, "Yana", "De Smet", false, null, "YANA.DESMET@ULAZARUS.BE", "YANA.DESMET@ULAZARUS.BE", null, null, false, "Static-stamp-14", false, "yana.desmet@ulazarus.be" },
                    { "Student15", 0, "STATIC-STAMP-15", "zita.lemmens@ulazarus.be", true, "Zita", "Lemmens", false, null, "ZITA.LEMMENS@ULAZARUS.BE", "ZITA.LEMMENS@ULAZARUS.BE", null, null, false, "Static-stamp-15", false, "zita.lemmens@ulazarus.be" },
                    { "Student16", 0, "STATIC-STAMP-16", "amber.coppens@ulazarus.be", true, "Amber", "Coppens", false, null, "AMBER.COPPENS@ULAZARUS.BE", "AMBER.COPPENS@ULAZARUS.BE", null, null, false, "Static-stamp-16", false, "amber.coppens@ulazarus.be" },
                    { "Student17", 0, "STATIC-STAMP-17", "bram.wouters@ulazarus.be", true, "Bram", "Wouters", false, null, "BRAM.WOUTERS@ULAZARUS.BE", "BRAM.WOUTERS@ULAZARUS.BE", null, null, false, "Static-stamp-17", false, "bram.wouters@ulazarus.be" },
                    { "Student18", 0, "STATIC-STAMP-18", "cato.boonen@ulazarus.be", true, "Cato", "Boonen", false, null, "CATO.BOONEN@ULAZARUS.BE", "CATO.BOONEN@ULAZARUS.BE", null, null, false, "Static-stamp-18", false, "cato.boonen@ulazarus.be" },
                    { "Student19", 0, "STATIC-STAMP-19", "dorien.depauw@ulazarus.be", true, "Dorien", "De Pauw", false, null, "DORIEN.DEPAUW@ULAZARUS.BE", "DORIEN.DEPAUW@ULAZARUS.BE", null, null, false, "Static-stamp-19", false, "dorien.depauw@ulazarus.be" },
                    { "Student2", 0, "STATIC-STAMP-2", "milan.goossens@ulazarus.be", true, "Milan", "Goossens", false, null, "MILAN.GOOSSENS@ULAZARUS.BE", "MILAN.GOOSSENS@ULAZARUS.BE", null, null, false, "Static-stamp2", false, "milan.goossens@ulazarus.be" },
                    { "Student20", 0, "STATIC-STAMP-20", "elias.vandenberghe@ulazarus.be", true, "Elias", "Vandenberghe", false, null, "ELIAS.VANDENBERGHE@ULAZARUS.BE", "ELIAS.VANDENBERGHE@ULAZARUS.BE", null, null, false, "Static-stamp-20", false, "elias.vandenberghe@ulazarus.be" },
                    { "Student21", 0, "STATIC-STAMP-21", "fien.verstraeten@ulazarus.be", true, "Fien", "Verstraeten", false, null, "FIEN.VERSTRAETEN@ULAZARUS.BE", "FIEN.VERSTRAETEN@ULAZARUS.BE", null, null, false, "Static-stamp-21", false, "fien.verstraeten@ulazarus.be" },
                    { "Student22", 0, "STATIC-STAMP-22", "gilles.lenaerts@ulazarus.be", true, "Gilles", "Lenaerts", false, null, "GILLES.LENAERTS@ULAZARUS.BE", "GILLES.LENAERTS@ULAZARUS.BE", null, null, false, "Static-stamp-22", false, "gilles.lenaerts@ulazarus.be" },
                    { "Student23", 0, "STATIC-STAMP-23", "hanne.vanhecke@ulazarus.be", true, "Hanne", "Van Hecke", false, null, "HANNE.VANHECKE@ULAZARUS.BE", "HANNE.VANHECKE@ULAZARUS.BE", null, null, false, "Static-stamp-23", false, "hanne.vanhecke@ulazarus.be" },
                    { "Student24", 0, "STATIC-STAMP-24", "ilias.dierckx@ulazarus.be", true, "Ilias", "Dierckx", false, null, "ILIAS.DIERCKX@ULAZARUS.BE", "ILIAS.DIERCKX@ULAZARUS.BE", null, null, false, "Static-stamp-24", false, "ilias.dierckx@ulazarus.be" },
                    { "Student25", 0, "STATIC-STAMP-25", "joke.vangorp@ulazarus.be", true, "Joke", "Van Gorp", false, null, "JOKE.VANGORP@ULAZARUS.BE", "JOKE.VANGORP@ULAZARUS.BE", null, null, false, "Static-stamp-25", false, "joke.vangorp@ulazarus.be" },
                    { "Student26", 0, "STATIC-STAMP-26", "kasper.vandenhaute@ulazarus.be", true, "Kasper", "Vandenhaute", false, null, "KASPER.VANDENHAUTE@ULAZARUS.BE", "KASPER.VANDENHAUTE@ULAZARUS.BE", null, null, false, "Static-stamp-26", false, "kasper.vandenhaute@ulazarus.be" },
                    { "Student27", 0, "STATIC-STAMP-27", "lana.cools@ulazarus.be", true, "Lana", "Cools", false, null, "LANA.COOLS@ULAZARUS.BE", "LANA.COOLS@ULAZARUS.BE", null, null, false, "Static-stamp-27", false, "lana.cools@ulazarus.be" },
                    { "Student28", 0, "STATIC-STAMP-28", "maarten.deridder@ulazarus.be", true, "Maarten", "De Ridder", false, null, "MAARTEN.DERIDDER@ULAZARUS.BE", "MAARTEN.DERIDDER@ULAZARUS.BE", null, null, false, "Static-stamp-28", false, "maarten.deridder@ulazarus.be" },
                    { "Student29", 0, "STATIC-STAMP-29", "nina.vandevelde@ulazarus.be", true, "Nina", "Van de Velde", false, null, "NINA.VANDEVELDE@ULAZARUS.BE", "NINA.VANDEVELDE@ULAZARUS.BE", null, null, false, "Static-stamp-29", false, "nina.vandevelde@ulazarus.be" },
                    { "Student3", 0, "STATIC-STAMP-3", "noa.hermans@ulazarus.be", true, "Noa", "Hermans", false, null, "NOA.HERMANS@ULAZARUS.BE", "NOA.HERMANS@ULAZARUS.BE", null, null, false, "Static-stamp-3", false, "noa.hermans@ulazarus.be" },
                    { "Student30", 0, "STATIC-STAMP-30", "oona.segers@ulazarus.be", true, "Oona", "Segers", false, null, "OONA.SEGERS@ULAZARUS.BE", "OONA.SEGERS@ULAZARUS.BE", null, null, false, "Static-stamp-30", false, "oona.segers@ulazarus.be" },
                    { "Student31", 0, "STATIC-STAMP-31", "pieter.diels@ulazarus.be", true, "Pieter", "Diels", false, null, "PIETER.DIELS@ULAZARUS.BE", "PIETER.DIELS@ULAZARUS.BE", null, null, false, "Static-stamp-31", false, "pieter.diels@ulazarus.be" },
                    { "Student32", 0, "STATIC-STAMP-32", "quincy.helsen@ulazarus.be", true, "Quincy", "Helsen", false, null, "QUINCY.HELSEN@ULAZARUS.BE", "QUINCY.HELSEN@ULAZARUS.BE", null, null, false, "Static-stamp-32", false, "quincy.helsen@ulazarus.be" },
                    { "Student33", 0, "STATIC-STAMP-33", "roos.depooter@ulazarus.be", true, "Roos", "De Pooter", false, null, "ROOS.DEPOOTER@ULAZARUS.BE", "ROOS.DEPOOTER@ULAZARUS.BE", null, null, false, "Static-stamp-33", false, "roos.depooter@ulazarus.be" },
                    { "Student34", 0, "STATIC-STAMP-34", "simon.d'hoore@ulazarus.be", true, "Simon", "D'Hoore", false, null, "SIMON.D'HOORE@ULAZARUS.BE", "SIMON.D'HOORE@ULAZARUS.BE", null, null, false, "Static-stamp-34", false, "simon.d'hoore@ulazarus.be" },
                    { "Student35", 0, "STATIC-STAMP-35", "tine.vermassen@ulazarus.be", true, "Tine", "Vermassen", false, null, "TINE.VERMASSEN@ULAZARUS.BE", "TINE.VERMASSEN@ULAZARUS.BE", null, null, false, "Static-stamp-35", false, "tine.vermassen@ulazarus.be" },
                    { "Student36", 0, "STATIC-STAMP-36", "urs.dekoninck@ulazarus.be", true, "Urs", "De Koninck", false, null, "URS.DEKONINCK@ULAZARUS.BE", "URS.DEKONINCK@ULAZARUS.BE", null, null, false, "Static-stamp-36", false, "urs.dekoninck@ulazarus.be" },
                    { "Student37", 0, "STATIC-STAMP-37", "veerle.dewaele@ulazarus.be", true, "Veerle", "Dewaele", false, null, "VEERLE.DEWAELE@ULAZARUS.BE", "VEERLE.DEWAELE@ULAZARUS.BE", null, null, false, "Static-stamp-37", false, "veerle.dewaele@ulazarus.be" },
                    { "Student38", 0, "STATIC-STAMP-38", "ward.claes@ulazarus.be", true, "Ward", "Claes", false, null, "WARD.CLAES@ULAZARUS.BE", "WARD.CLAES@ULAZARUS.BE", null, null, false, "Static-stamp-38", false, "ward.claes@ulazarus.be" },
                    { "Student39", 0, "STATIC-STAMP-39", "xenia.vanderhaegen@ulazarus.be", true, "Xenia", "Vanderhaegen", false, null, "XENIA.VANDERHAEGEN@ULAZARUS.BE", "XENIA.VANDERHAEGEN@ULAZARUS.BE", null, null, false, "Static-stamp-39", false, "xenia.vanderhaegen@ulazarus.be" },
                    { "Student4", 0, "STATIC-STAMP-4", "olivier.willems@ulazarus.be", true, "Olivier", "Willems", false, null, "OLIVIER.WILLEMS@ULAZARUS.BE", "OLIVIER.WILLEMS@ULAZARUS.BE", null, null, false, "Static-stamp-4", false, "olivier.willems@ulazarus.be" },
                    { "Student40", 0, "STATIC-STAMP-40", "yorben.dewinter@ulazarus.be", true, "Yorben", "De Winter", false, null, "YORBEN.DEWINTER@ULAZARUS.BE", "YORBEN.DEWINTER@ULAZARUS.BE", null, null, false, "Static-stamp-40", false, "yorben.dewinter@ulazarus.be" },
                    { "Student41", 0, "STATIC-STAMP-41", "zoë.meeus@ulazarus.be", true, "Zoë", "Meeus", false, null, "ZOË.MEEUS@ULAZARUS.BE", "ZOË.MEEUS@ULAZARUS.BE", null, null, false, "Static-stamp-1", false, "zoë.meeus@ulazarus.be" },
                    { "Student42", 0, "STATIC-STAMP-42", "annelies.demuynck@ulazarus.be", true, "Annelies", "Demuynck", false, null, "ANNELIES.DEMUYNCK@ULAZARUS.BE", "ANNELIES.DEMUYNCK@ULAZARUS.BE", null, null, false, "Static-stamp-42", false, "annelies.demuynck@ulazarus.be" },
                    { "Student43", 0, "STATIC-STAMP-43", "bert.vrancken@ulazarus.be", true, "Bert", "Vrancken", false, null, "BERT.VRANCKEN@ULAZARUS.BE", "BERT.VRANCKEN@ULAZARUS.BE", null, null, false, "Static-stamp-43", false, "bert.vrancken@ulazarus.be" },
                    { "Student44", 0, "STATIC-STAMP-44", "charlotte.moons@ulazarus.be", true, "Charlotte", "Moons", false, null, "CHARLOTTE.MOONS@ULAZARUS.BE", "CHARLOTTE.MOONS@ULAZARUS.BE", null, null, false, "Static-stamp-44", false, "charlotte.moons@ulazarus.be" },
                    { "Student45", 0, "STATIC-STAMP-45", "dylan.spillebeen@ulazarus.be", true, "Dylan", "Spillebeen", false, null, "DYLAN.SPILLEBEEN@ULAZARUS.BE", "DYLAN.SPILLEBEEN@ULAZARUS.BE", null, null, false, "Static-stamp-45", false, "dylan.spillebeen@ulazarus.be" },
                    { "Student46", 0, "STATIC-STAMP-46", "eline.vermeersch@ulazarus.be", true, "Eline", "Vermeersch", false, null, "ELINE.VERMEERSCH@ULAZARUS.BE", "ELINE.VERMEERSCH@ULAZARUS.BE", null, null, false, "Static-stamp-46", false, "eline.vermeersch@ulazarus.be" },
                    { "Student47", 0, "STATIC-STAMP-47", "frederik.vanlooy@ulazarus.be", true, "Frederik", "Van Looy", false, null, "FREDERIK.VANLOOY@ULAZARUS.BE", "FREDERIK.VANLOOY@ULAZARUS.BE", null, null, false, "Static-stamp-47", false, "frederik.vanlooy@ulazarus.be" },
                    { "Student48", 0, "STATIC-STAMP-48", "gwen.vandamme@ulazarus.be", true, "Gwen", "Van Damme", false, null, "GWEN.VANDAMME@ULAZARUS.BE", "GWEN.VANDAMME@ULAZARUS.BE", null, null, false, "Static-stamp-48", false, "gwen.vandamme@ulazarus.be" },
                    { "Student49", 0, "STATIC-STAMP-49", "hugo.dejonge@ulazarus.be", true, "Hugo", "De Jonge", false, null, "HUGO.DEJONGE@ULAZARUS.BE", "HUGO.DEJONGE@ULAZARUS.BE", null, null, false, "Static-stamp-49", false, "hugo.dejonge@ulazarus.be" },
                    { "Student5", 0, "STATIC-STAMP-5", "pauline.vandamme@ulazarus.be", true, "Pauline", "Vandamme", false, null, "PAULINE.VANDAMME@ULAZARUS.BE", "PAULINE.VANDAMME@ULAZARUS.BE", null, null, false, "Static-stamp-5", false, "pauline.vandamme@ulazarus.be" },
                    { "Student50", 0, "STATIC-STAMP-50", "isa.vandewalle@ulazarus.be", true, "Isa", "Vandewalle", false, null, "ISA.VANDEWALLE@ULAZARUS.BE", "ISA.VANDEWALLE@ULAZARUS.BE", null, null, false, "Static-stamp-50", false, "isa.vandewalle@ulazarus.be" },
                    { "Student6", 0, "STATIC-STAMP-6", "quinten.jacobs@ulazarus.be", true, "Quinten", "Jacobs", false, null, "QUINTEN.JACOBS@ULAZARUS.BE", "QUINTEN.JACOBS@ULAZARUS.BE", null, null, false, "Static-stamp-6", false, "quinten.jacobs@ulazarus.be" },
                    { "Student7", 0, "STATIC-STAMP-7", "rani.declercq@ulazarus.be", true, "Rani", "Declercq", false, null, "RANI.DECLERCQ@ULAZARUS.BE", "RANI.DECLERCQ@ULAZARUS.BE", null, null, false, "Static-stamp-7", false, "rani.declercq@ulazarus.be" },
                    { "Student8", 0, "STATIC-STAMP-8", "stijn.vanacker@ulazarus.be", true, "Stijn", "Van Acker", false, null, "STIJN.VANACKER@ULAZARUS.BE", "STIJN.VANACKER@ULAZARUS.BE", null, null, false, "Static-stamp-8", false, "stijn.vanacker@ulazarus.be" },
                    { "Student9", 0, "STATIC-STAMP-9", "tess.peeters@ulazarus.be", true, "Tess", "Peeters", false, null, "TESS.PEETERS@ULAZARUS.BE", "TESS.PEETERS@ULAZARUS.BE", null, null, false, "Static-stamp-9", false, "tess.peeters@ulazarus.be" },
                    { "Teacher1", 0, "STATIC-CONCURRENCY-1", "alice.jansen@ulazarus.be", true, "Alice", "Jansen", false, null, "ALICE.JANSEN@ULAZARUS.BE", "ALICE.JANSEN@ULAZARUS.BE", null, null, false, "static-stamp-1", false, "alice.jansen@ulazarus.be" },
                    { "Teacher10", 0, "STATIC-STAMP-10", "jan.desmet@ulazarus.be", true, "Jan", "De Smet", false, null, "JAN.DESMET@ULAZARUS.BE", "JAN.DESMET@ULAZARUS.BE", null, null, false, "static-stamp-10", false, "jan.desmet@ulazarus.be" },
                    { "Teacher2", 0, "STATIC-CONCURRENCY-2", "bart.peeters@ulazarus.be", true, "Bart", "Peeters", false, null, "BART.PEETERS@ULAZARUS.BE", "BART.PEETERS@ULAZARUS.BE", null, null, false, "static-stamp-2", false, "bart.peeters@ulazarus.be" },
                    { "Teacher3", 0, "STATIC-CONCURRENCY-3", "clara.devos@ulazarus.be", true, "Clara", "De Vos", false, null, "CLARA.DEVOS@ULAZARUS.BE", "CLARA.DEVOS@ULAZARUS.BE", null, null, false, "static-stamp-3", false, "clara.devos@ulazarus.be" },
                    { "Teacher4", 0, "STATIC-CONCURRENCY-4", "daan.vermeulen@ulazarus.be", true, "Daan", "Vermeulen", false, null, "DAAN.VERMEULEN@ULAZARUS.BE", "DAAN.VERMEULEN@ULAZARUS.BE", null, null, false, "static-stamp-4", false, "daan.vermeulen@ulazarus.be" },
                    { "Teacher5", 0, "STATIC- CONCURRENCY-5", "eva.maes@ulazarus.be", true, "Eva", "Maes", false, null, "EVA.MAES@ULAZARUS.BE", "EVA.MAES@ULAZARUS.BE", null, null, false, "static- stamp-5", false, "eva.maes@ulazarus.be" },
                    { "Teacher6", 0, "STATIC-STAMP-6", "frank.vdb@ulazarus.be", true, "Frank", "Vandenberghe", false, null, "FRANK.VDB@ULAZARUS.BE", "FRANK.VDB@ULAZARUS.BE", null, null, false, "static-stamp-6", false, "frank.vdb@ulazarus.be" },
                    { "Teacher7", 0, "STATIC-STAMP-7", "greet.declerck@ulazarus.be", true, "Greet", "Declerck", false, null, "GREET.DECLERCK@ULAZARUS.BE", "GREET.DECLERCK@ULAZARUS.BE", null, null, false, "static-stamp-7", false, "greet.declerck@ulazarus.be" },
                    { "Teacher8", 0, "STATIC-STAMP-8", "hans.lenaerts@ulazarus.be", true, "Hans", "Lenaerts", false, null, "HANS.LENAERTS@ULAZARUS.BE", "HANS.LENAERTS@ULAZARUS.BE", null, null, false, "static-stamp-8", false, "hans.lenaerts@ulazarus.be" },
                    { "Teacher9", 0, "STATIC-STAMP-9", "ilse.vandenheuvel@ulazarus.be", true, "Ilse", "Vandenheuvel", false, null, "ILSE.VANDENHEUVEL@ULAZARUS.BE", "ILSE.VANDENHEUVEL@ULAZARUS.BE", null, null, false, "static-stamp-9", false, "ilse.vandenheuvel@ulazarus.be" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "FacultyId", "Name" },
                values: new object[,]
                {
                    { 1, "Engineering" },
                    { 2, "Health Sciences" },
                    { 3, "Economics" },
                    { 4, "Arts and Humanities" }
                });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "SectorId", "Name" },
                values: new object[,]
                {
                    { 1, "Software Development" },
                    { 2, "Nursing" },
                    { 3, "Finance" },
                    { 4, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "role-admin", "admin1" },
                    { "role-admin", "admin2" },
                    { "role-admin", "admin3" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "FacultyId", "Name", "SectorId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, "Programming C#", 1, null },
                    { 2, 2, "Medical Ethics", 2, null },
                    { 3, 3, "Financial Accounting", 3, null },
                    { 4, 4, "European Literature", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Email", "FacultyId", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "alice.jansen@ulazarus.be", 1, "Alice", "Jansen", "Teacher1" },
                    { 2, "bart.peeters@ulazarus.be", 2, "Bart", "Peeters", "Teacher2" },
                    { 3, "clara.devos@ulazarus.be", 3, "Clara", "De Vos", "Teacher3" },
                    { 4, "daan.vermeulen@ulazarus.be", 1, "Daan", "Vermeulen", "Teacher4" },
                    { 5, "eva.maes@ulazarus.be", 2, "Eva", "Maes", "Teacher5" },
                    { 6, "frank.vdb@ulazarus.be", 3, "Frank", "Vandenberghe", "Teacher6" },
                    { 7, "greet.declerck@ulazarus.be", 1, "Greet", "Declerck", "Teacher7" },
                    { 8, "hans.lenaerts@ulazarus.be", 2, "Hans", "Lenaerts", "Teacher8" },
                    { 9, "ilse.vandenheuvel@ulazarus.be", 3, "Ilse", "Vandenheuvel", "Teacher9" },
                    { 10, "jan.desmet@ulazarus.be", 1, "Jan", "De Smet", "Teacher10" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ScheduleId", "CourseId", "Date", "Location", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campus A - Room 101", "Morning" },
                    { 2, 2, new DateTime(2025, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campus B - Room 202", "Afternoon" },
                    { 3, 3, new DateTime(2025, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Campus C - Lab 1", "Evening" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "FacultyId", "FirstName", "LastName", "ScheduleId", "UserId" },
                values: new object[,]
                {
                    { 1, "lotte.dewilde@ulazarus.be", 1, "Lotte", "De Wilde", 1, "Student1" },
                    { 2, "milan.goossens@ulazarus.be", 2, "Milan", "Goossens", 2, "Student2" },
                    { 3, "noa.hermans@ulazarus.be", 3, "Noa", "Hermans", 3, "Student3" },
                    { 4, "olivier.willems@ulazarus.be", 1, "Olivier", "Willems", 3, "Student4" },
                    { 5, "pauline.vandamme@ulazarus.be", 2, "Pauline", "Vandamme", 2, "Student5" },
                    { 6, "quinten.jacobs@ulazarus.be", 3, "Quinten", "Jacobs", 1, "Student6" },
                    { 7, "rani.declercq@ulazarus.be", 1, "Rani", "Declercq", 2, "Student7" },
                    { 8, "stijn.vanacker@ulazarus.be", 2, "Stijn", "Van Acker", 3, "Student8" },
                    { 9, "tess.peeters@ulazarus.be", 3, "Tess", "Peeters", 1, "Student9" },
                    { 10, "ugo.desmet@ulazarus.be", 1, "Ugo", "Desmet", 2, "Student10" },
                    { 11, "valerie.vandenbroeck@ulazarus.be", 2, "Valerie", "Van den Broeck", 1, "Student11" },
                    { 12, "wout.smet@ulazarus.be", 3, "Wout", "Smet", 2, "Student12" },
                    { 13, "xander.vermeiren@ulazarus.be", 1, "Xander", "Vermeiren", 3, "Student13" },
                    { 14, "yana.desmet@ulazarus.be", 2, "Yana", "De Smet", 3, "Student14" },
                    { 15, "zita.lemmens@ulazarus.be", 3, "Zita", "Lemmens", 1, "Student15" },
                    { 16, "amber.coppens@ulazarus.be", 1, "Amber", "Coppens", 1, "Student16" },
                    { 17, "bram.wouters@ulazarus.be", 2, "Bram", "Wouters", 2, "Student17" },
                    { 18, "cato.boonen@ulazarus.be", 3, "Cato", "Boonen", 3, "Student18" },
                    { 19, "dorien.depauw@ulazarus.be", 1, "Dorien", "De Pauw", 2, "Student19" },
                    { 20, "elias.vandenberghe@ulazarus.be", 2, "Elias", "Vandenberghe", 3, "Student20" },
                    { 21, "fien.verstraeten@ulazarus.be", 3, "Fien", "Verstraeten", 1, "Student21" },
                    { 22, "gilles.lenaerts@ulazarus.be", 1, "Gilles", "Lenaerts", 2, "Student22" },
                    { 23, "hanne.vanhecke@ulazarus.be", 2, "Hanne", "Van Hecke", 3, "Student23" },
                    { 24, "ilias.dierckx@ulazarus.be", 3, "Ilias", "Dierckx", 1, "Student24" },
                    { 25, "joke.vangorp@ulazarus.be", 1, "Joke", "Van Gorp", 1, "Student25" },
                    { 26, "kasper.vandenhaute@ulazarus.be", 2, "Kasper", "Vandenhaute", 1, "Student26" },
                    { 27, "lana.cools@ulazarus.be", 3, "Lana", "Cools", 2, "Student27" },
                    { 28, "maarten.deridder@ulazarus.be", 1, "Maarten", "De Ridder", 3, "Student28" },
                    { 29, "nina.vandevelde@ulazarus.be", 2, "Nina", "Van de Velde", 2, "Student29" },
                    { 30, "oona.segers@ulazarus.be", 3, "Oona", "Segers", 3, "Student30" },
                    { 31, "pieter.diels@ulazarus.be", 1, "Pieter", "Diels", 1, "Student31" },
                    { 32, "quincy.helsen@ulazarus.be", 2, "Quincy", "Helsen", 2, "Student32" },
                    { 33, "roos.depooter@ulazarus.be", 3, "Roos", "De Pooter", 3, "Student33" },
                    { 34, "simon.d'hoore@ulazarus.be", 1, "Simon", "D'Hoore", 2, "Student34" },
                    { 35, "tine.vermassen@ulazarus.be", 2, "Tine", "Vermassen", 1, "Student35" },
                    { 36, "urs.dekoninck@ulazarus.be", 3, "Urs", "De Koninck", 1, "Student36" },
                    { 37, "veerle.dewaele@ulazarus.be", 1, "Veerle", "Dewaele", 2, "Student37" },
                    { 38, "ward.claes@ulazarus.be", 2, "Ward", "Claes", 3, "Student38" },
                    { 39, "xenia.vanderhaegen@ulazarus.be", 3, "Xenia", "Vanderhaegen", 2, "Student39" },
                    { 40, "yorben.dewinter@ulazarus.be", 1, "Yorben", "De Winter", 1, "Student40" },
                    { 41, "zoë.meeus@ulazarus.be", 2, "Zoë", "Meeus", 1, "Student41" },
                    { 42, "annelies.demuynck@ulazarus.be", 3, "Annelies", "Demuynck", 2, "Student42" },
                    { 43, "bert.vrancken@ulazarus.be", 1, "Bert", "Vrancken", 3, "Student43" },
                    { 44, "charlotte.moons@ulazarus.be", 2, "Charlotte", "Moons", 2, "Student44" },
                    { 45, "dylan.spillebeen@ulazarus.be", 3, "Dylan", "Spillebeen", 3, "Student45" },
                    { 46, "eline.vermeersch@ulazarus.be", 1, "Eline", "Vermeersch", 1, "Student46" },
                    { 47, "frederik.vanlooy@ulazarus.be", 2, "Frederik", "Van Looy", 2, "Student47" },
                    { 48, "gwen.vandamme@ulazarus.be", 3, "Gwen", "Van Damme", 3, "Student48" },
                    { 49, "hugo.dejonge@ulazarus.be", 1, "Hugo", "De Jonge", 1, "Student49" },
                    { 50, "isa.vandewalle@ulazarus.be", 2, "Isa", "Vandewalle", 1, "Student50" }
                });

            migrationBuilder.InsertData(
                table: "CourseResults",
                columns: new[] { "CourseResultId", "CourseId", "Score", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 85.50m, 1 },
                    { 2, 2, 78.25m, 2 },
                    { 3, 3, 92.00m, 3 },
                    { 4, 4, 88.75m, 4 },
                    { 5, 1, 81.00m, 5 },
                    { 6, 2, 90.50m, 6 },
                    { 7, 3, 76.75m, 7 },
                    { 8, 4, 89.00m, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CourseResults_CourseId",
                table: "CourseResults",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseResults_StudentId",
                table: "CourseResults",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_FacultyId",
                table: "Courses",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SectorId",
                table: "Courses",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_CourseId",
                table: "Schedules",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyId",
                table: "Students",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ScheduleId",
                table: "Students",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_FacultyId",
                table: "Teachers",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CourseResults");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
