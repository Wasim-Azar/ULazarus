using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ULazarusData.Migrations
{
    /// <inheritdoc />
    public partial class FixCourseTeacherRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-71", "static-stamp-71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-72", "static-stamp-72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-73", "static-stamp-73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-51", "static-stamp-51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-60", "static-stamp-60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-52", "static-stamp-52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-53", "static-stamp-53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-54", "static-stamp-54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC- CONCURRENCY-55", "static- stamp-55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-56", "static-stamp-56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-57", "static-stamp-57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-58", "static-stamp-58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-59", "static-stamp-59" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "TeacherId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "TeacherId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "TeacherId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "TeacherId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 4,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 5,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 6,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 7,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 8,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 9,
                column: "CourseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 10,
                column: "CourseId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Courses_CourseId",
                table: "Teachers",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Courses_CourseId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_CourseId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-1", "static-stamp-1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-2", "static-stamp-2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-3", "static-stamp-3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-1", "static-stamp-1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-10", "static-stamp-10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-2", "static-stamp-2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-3", "static-stamp-3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-CONCURRENCY-4", "static-stamp-4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC- CONCURRENCY-5", "static- stamp-5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-6", "static-stamp-6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-7", "static-stamp-7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-8", "static-stamp-8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Teacher9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "STATIC-STAMP-9", "static-stamp-9" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "TeacherId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "TeacherId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "TeacherId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "TeacherId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId");
        }
    }
}
