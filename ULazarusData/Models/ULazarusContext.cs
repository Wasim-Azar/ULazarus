using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ULazarusData.Models;
using System;
using System.Collections.Generic;

namespace ULazarusData
{
    public class ULazarusContext : IdentityDbContext<ApplicationUser>
    {
        public ULazarusContext(DbContextOptions<ULazarusContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<CourseResult> CourseResults { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<CourseResult>()
                .HasOne(cr => cr.Student)
                .WithMany(s => s.CourseResults)
                .HasForeignKey(cr => cr.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CourseResult>()
                .HasOne(cr => cr.Course)
                .WithMany(c => c.CourseResults)
                .HasForeignKey(cr => cr.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>()
                 .HasOne(s => s.Faculty)
                 .WithMany(f => f.Students)
                 .HasForeignKey(s => s.FacultyId)
                 .OnDelete(DeleteBehavior.SetNull);


            modelBuilder.Entity<Student>()
                .HasOne(s => s.Schedule)
                .WithMany()
                .HasForeignKey(s => s.ScheduleId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Faculty)
                .WithMany(f => f.Teachers)
                .HasForeignKey(t => t.FacultyId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Course)
                .WithMany(c => c.Schedules)
                .HasForeignKey(s => s.CourseId);






            // Seed Roles
            var adminRole = new IdentityRole { Id = "role-admin", Name = "Admin", NormalizedName = "ADMIN" };
            var teacherRole = new IdentityRole { Id = "role-teacher", Name = "Teacher", NormalizedName = "TEACHER" };
            var studentRole = new IdentityRole { Id = "role-student", Name = "Student", NormalizedName = "STUDENT" };
            modelBuilder.Entity<IdentityRole>().HasData(adminRole, teacherRole, studentRole);

            // Seed Admin Users
            ;
            var admin1 = new ApplicationUser
            {
                Id = "admin1",
                UserName = "wasim@ulazarus.be",
                NormalizedUserName = "WASIM@ULAZARUS.BE",
                Email = "wasim@ulazarus.be",
                NormalizedEmail = "WASIM@ULAZARUS.BE",
                EmailConfirmed = true,
                FirstName = "Wasim",
                LastName = "Lazarus",
                SecurityStamp = "static-stamp-71",
                ConcurrencyStamp = "STATIC-CONCURRENCY-71"
            };



            var admin2 = new ApplicationUser
            {
                Id = "admin2",
                UserName = "claire@ulazarus.be",
                NormalizedUserName = "CLAIRE@ULAZARUS.BE",
                Email = "claire@ulazarus.be",
                NormalizedEmail = "CLAIRE@ULAZARUS.BE",
                EmailConfirmed = true,
                FirstName = "Claire",
                LastName = "Delacroix",
                SecurityStamp = "static-stamp-72",
                ConcurrencyStamp = "STATIC-CONCURRENCY-72"

            };


            var admin3 = new ApplicationUser
            {
                Id = "admin3",
                UserName = "jonas@ulazarus.be",
                NormalizedUserName = "JONAS@ULAZARUS.BE",
                Email = "jonas@ulazarus.be",
                NormalizedEmail = "JONAS@ULAZARUS.BE",
                EmailConfirmed = true,
                FirstName = "Jonas",
                LastName = "Vermeulen",
                SecurityStamp = "static-stamp-73",
                ConcurrencyStamp = "STATIC-CONCURRENCY-73"
            };


            modelBuilder.Entity<ApplicationUser>().HasData(admin1, admin2, admin3);

            // Link Admins to Admin role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "admin1", RoleId = "role-admin" },
                new IdentityUserRole<string> { UserId = "admin2", RoleId = "role-admin" },
                new IdentityUserRole<string> { UserId = "admin3", RoleId = "role-admin" }
            );

            //Link Teachers to Teacher role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "Teacher1", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher2", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher3", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher4", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher5", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher6", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher7", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher8", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher9", RoleId = "role-teacher" },
                new IdentityUserRole<string> { UserId = "Teacher10", RoleId = "role-teacher" }
            );

            // Link Students to Student role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "Student1", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student2", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student3", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student4", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student5", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student6", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student7", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student8", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student9", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student10", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student11", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student12", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student13", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student14", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student15", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student16", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student17", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student18", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student19", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student20", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student21", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student22", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student23", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student24", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student25", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student26", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student27", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student28", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student29", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student30", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student31", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student32", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student33", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student34", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student35", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student36", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student37", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student38", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student39", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student40", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student41", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student42", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student43", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student44", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student45", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student46", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student47", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student48", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student49", RoleId = "role-student" },
                new IdentityUserRole<string> { UserId = "Student50", RoleId = "role-student" }


            );

            // Generate Faculties

            modelBuilder.Entity<Faculty>().HasData(
                new Faculty { FacultyId = 1, Name = "Engineering" },
                new Faculty { FacultyId = 2, Name = "Health Sciences" },
                new Faculty { FacultyId = 3, Name = "Economics" },
                new Faculty { FacultyId = 4, Name = "Arts and Humanities" }
                );

            // Generate Sectors        

            modelBuilder.Entity<Sector>().HasData(
                new Sector { SectorId = 1, Name = "Software Development" },
                new Sector { SectorId = 2, Name = "Nursing" },
                new Sector { SectorId = 3, Name = "Finance" },
                new Sector { SectorId = 4, Name = "Literature" }
                );

            // Generate Schedules         

            modelBuilder.Entity<Schedule>().HasData(
                new Schedule
                { ScheduleId = 1, Name = "Morning", Location = "Campus A - Room 101", Date = new DateTime(2025, 9, 1), CourseId = 1 },
                new Schedule
                { ScheduleId = 2, Name = "Afternoon", Location = "Campus B - Room 202", Date = new DateTime(2025, 9, 2), CourseId = 2 },
                new Schedule
                { ScheduleId = 3, Name = "Evening", Location = "Campus C - Lab 1", Date = new DateTime(2025, 9, 3), CourseId = 3 },
                new Schedule
                { ScheduleId = 4, Name = "Weekend", Location = "Campus D - Room 404", Date = new DateTime(2025, 9, 1), CourseId =4}
                );


            // Generate Courses          
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Name = "Programming C#", FacultyId = 1, SectorId = 1, TeacherId =1 },
                new Course { CourseId = 2, Name = "Medical Ethics", FacultyId = 2, SectorId = 2, TeacherId = 2 },
                new Course { CourseId = 3, Name = "Financial Accounting", FacultyId = 3, SectorId = 3, TeacherId = 3 },
                new Course { CourseId = 4, Name = "European Literature", FacultyId = 4, SectorId = 4 , TeacherId = 4 }
                );
            // Generate ApplicationUser Teacher
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "Teacher1",
                    FirstName = "Alice",
                    LastName = "Jansen",
                    UserName = "alice.jansen@ulazarus.be",
                    NormalizedUserName = "ALICE.JANSEN@ULAZARUS.BE",
                    Email = "alice.jansen@ulazarus.be",
                    NormalizedEmail = "ALICE.JANSEN@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-51",
                    ConcurrencyStamp = "STATIC-CONCURRENCY-51"
                },
                new ApplicationUser
                {
                    Id = "Teacher2",
                    FirstName = "Bart",
                    LastName = "Peeters",
                    UserName = "bart.peeters@ulazarus.be",
                    NormalizedUserName = "BART.PEETERS@ULAZARUS.BE",
                    Email = "bart.peeters@ulazarus.be",
                    NormalizedEmail = "BART.PEETERS@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-52",
                    ConcurrencyStamp = "STATIC-CONCURRENCY-52"
                },
                new ApplicationUser
                {
                    Id = "Teacher3",
                    FirstName = "Clara",
                    LastName = "De Vos",
                    UserName = "clara.devos@ulazarus.be",
                    NormalizedUserName = "CLARA.DEVOS@ULAZARUS.BE",
                    Email = "clara.devos@ulazarus.be",
                    NormalizedEmail = "CLARA.DEVOS@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-53",
                    ConcurrencyStamp = "STATIC-CONCURRENCY-53"
                },
                new ApplicationUser
                {
                    Id = "Teacher4",
                    FirstName = "Daan",
                    LastName = "Vermeulen",
                    UserName = "daan.vermeulen@ulazarus.be",
                    NormalizedUserName = "DAAN.VERMEULEN@ULAZARUS.BE",
                    Email = "daan.vermeulen@ulazarus.be",
                    NormalizedEmail = "DAAN.VERMEULEN@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-54",
                    ConcurrencyStamp = "STATIC-CONCURRENCY-54"
                },
                new ApplicationUser
                {
                    Id = "Teacher5",
                    FirstName = "Eva",
                    LastName = "Maes",
                    UserName = "eva.maes@ulazarus.be",
                    NormalizedUserName = "EVA.MAES@ULAZARUS.BE",
                    Email = "eva.maes@ulazarus.be",
                    NormalizedEmail = "EVA.MAES@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static- stamp-55",
                    ConcurrencyStamp = "STATIC- CONCURRENCY-55"
                },
                new ApplicationUser
                {
                    Id = "Teacher6",
                    FirstName = "Frank",
                    LastName = "Vandenberghe",
                    UserName = "frank.vdb@ulazarus.be",
                    NormalizedUserName = "FRANK.VDB@ULAZARUS.BE",
                    Email = "frank.vdb@ulazarus.be",
                    NormalizedEmail = "FRANK.VDB@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-56",
                    ConcurrencyStamp = "STATIC-STAMP-56"
                },
                new ApplicationUser
                {
                    Id = "Teacher7",
                    FirstName = "Greet",
                    LastName = "Declerck",
                    UserName = "greet.declerck@ulazarus.be",
                    NormalizedUserName = "GREET.DECLERCK@ULAZARUS.BE",
                    Email = "greet.declerck@ulazarus.be",
                    NormalizedEmail = "GREET.DECLERCK@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-57",
                    ConcurrencyStamp = "STATIC-STAMP-57"
                },
                new ApplicationUser
                {
                    Id = "Teacher8",
                    FirstName = "Hans",
                    LastName = "Lenaerts",
                    UserName = "hans.lenaerts@ulazarus.be",
                    NormalizedUserName = "HANS.LENAERTS@ULAZARUS.BE",
                    Email = "hans.lenaerts@ulazarus.be",
                    NormalizedEmail = "HANS.LENAERTS@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-58",
                    ConcurrencyStamp = "STATIC-STAMP-58"
                },
                new ApplicationUser
                {
                    Id = "Teacher9",
                    FirstName = "Ilse",
                    LastName = "Vandenheuvel",
                    UserName = "ilse.vandenheuvel@ulazarus.be",
                    NormalizedUserName = "ILSE.VANDENHEUVEL@ULAZARUS.BE",
                    Email = "ilse.vandenheuvel@ulazarus.be",
                    NormalizedEmail = "ILSE.VANDENHEUVEL@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-59",
                    ConcurrencyStamp = "STATIC-STAMP-59"
                },
                new ApplicationUser
                {
                    Id = "Teacher10",
                    FirstName = "Jan",
                    LastName = "De Smet",
                    UserName = "jan.desmet@ulazarus.be",
                    NormalizedUserName = "JAN.DESMET@ULAZARUS.BE",
                    Email = "jan.desmet@ulazarus.be",
                    NormalizedEmail = "JAN.DESMET@ULAZARUS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "static-stamp-60",
                    ConcurrencyStamp = "STATIC-STAMP-60"
                }
  );

            // Generate 10 Teachers
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, FirstName = "Alice", LastName = "Jansen", Email = "alice.jansen@ulazarus.be", FacultyId = 1, UserId = "Teacher1" },
                new Teacher { TeacherId = 2, FirstName = "Bart", LastName = "Peeters", Email = "bart.peeters@ulazarus.be", FacultyId = 2, UserId = "Teacher2" },
                new Teacher { TeacherId = 3, FirstName = "Clara", LastName = "De Vos", Email = "clara.devos@ulazarus.be", FacultyId = 3, UserId = "Teacher3" },
                new Teacher { TeacherId = 4, FirstName = "Daan", LastName = "Vermeulen", Email = "daan.vermeulen@ulazarus.be", FacultyId = 1, UserId = "Teacher4" },
                new Teacher { TeacherId = 5, FirstName = "Eva", LastName = "Maes", Email = "eva.maes@ulazarus.be", FacultyId = 2, UserId = "Teacher5" },
                new Teacher { TeacherId = 6, FirstName = "Frank", LastName = "Vandenberghe", Email = "frank.vdb@ulazarus.be", FacultyId = 3, UserId = "Teacher6" },
                new Teacher { TeacherId = 7, FirstName = "Greet", LastName = "Declerck", Email = "greet.declerck@ulazarus.be", FacultyId = 1, UserId = "Teacher7" },
                new Teacher { TeacherId = 8, FirstName = "Hans", LastName = "Lenaerts", Email = "hans.lenaerts@ulazarus.be", FacultyId = 2, UserId = "Teacher8" },
                new Teacher { TeacherId = 9, FirstName = "Ilse", LastName = "Vandenheuvel", Email = "ilse.vandenheuvel@ulazarus.be", FacultyId = 3, UserId = "Teacher9" },
                new Teacher { TeacherId = 10, FirstName = "Jan", LastName = "De Smet", Email = "jan.desmet@ulazarus.be", FacultyId = 1, UserId = "Teacher10" }
);
            // Generate 50 Students application users
            modelBuilder.Entity<ApplicationUser>().HasData(
    new ApplicationUser { Id = "Student1", FirstName = "Lotte", LastName = "De Wilde", UserName = "lotte.dewilde@ulazarus.be", NormalizedUserName = "LOTTE.DEWILDE@ULAZARUS.BE", Email = "lotte.dewilde@ulazarus.be", NormalizedEmail = "LOTTE.DEWILDE@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp ="Static-stamp-1", ConcurrencyStamp = "STATIC-STAMP-1" },
    new ApplicationUser { Id = "Student2", FirstName = "Milan", LastName = "Goossens", UserName = "milan.goossens@ulazarus.be", NormalizedUserName = "MILAN.GOOSSENS@ULAZARUS.BE", Email = "milan.goossens@ulazarus.be", NormalizedEmail = "MILAN.GOOSSENS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp ="Static-stamp2", ConcurrencyStamp ="STATIC-STAMP-2" },
    new ApplicationUser { Id = "Student3", FirstName = "Noa", LastName = "Hermans", UserName = "noa.hermans@ulazarus.be", NormalizedUserName = "NOA.HERMANS@ULAZARUS.BE", Email = "noa.hermans@ulazarus.be", NormalizedEmail = "NOA.HERMANS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-3", ConcurrencyStamp = "STATIC-STAMP-3" },
    new ApplicationUser { Id = "Student4", FirstName = "Olivier", LastName = "Willems", UserName = "olivier.willems@ulazarus.be", NormalizedUserName = "OLIVIER.WILLEMS@ULAZARUS.BE", Email = "olivier.willems@ulazarus.be", NormalizedEmail = "OLIVIER.WILLEMS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-4", ConcurrencyStamp = "STATIC-STAMP-4" },
    new ApplicationUser { Id = "Student5", FirstName = "Pauline", LastName = "Vandamme", UserName = "pauline.vandamme@ulazarus.be", NormalizedUserName = "PAULINE.VANDAMME@ULAZARUS.BE", Email = "pauline.vandamme@ulazarus.be", NormalizedEmail = "PAULINE.VANDAMME@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-5", ConcurrencyStamp = "STATIC-STAMP-5" },
    new ApplicationUser { Id = "Student6", FirstName = "Quinten", LastName = "Jacobs", UserName = "quinten.jacobs@ulazarus.be", NormalizedUserName = "QUINTEN.JACOBS@ULAZARUS.BE", Email = "quinten.jacobs@ulazarus.be", NormalizedEmail = "QUINTEN.JACOBS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-6", ConcurrencyStamp = "STATIC-STAMP-6" },
    new ApplicationUser { Id = "Student7", FirstName = "Rani", LastName = "Declercq", UserName = "rani.declercq@ulazarus.be", NormalizedUserName = "RANI.DECLERCQ@ULAZARUS.BE", Email = "rani.declercq@ulazarus.be", NormalizedEmail = "RANI.DECLERCQ@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-7", ConcurrencyStamp = "STATIC-STAMP-7" },
    new ApplicationUser { Id = "Student8", FirstName = "Stijn", LastName = "Van Acker", UserName = "stijn.vanacker@ulazarus.be", NormalizedUserName = "STIJN.VANACKER@ULAZARUS.BE", Email = "stijn.vanacker@ulazarus.be", NormalizedEmail = "STIJN.VANACKER@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-8", ConcurrencyStamp = "STATIC-STAMP-8" },
    new ApplicationUser { Id = "Student9", FirstName = "Tess", LastName = "Peeters", UserName = "tess.peeters@ulazarus.be", NormalizedUserName = "TESS.PEETERS@ULAZARUS.BE", Email = "tess.peeters@ulazarus.be", NormalizedEmail = "TESS.PEETERS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-9", ConcurrencyStamp = "STATIC-STAMP-9" },
    new ApplicationUser { Id = "Student10", FirstName = "Ugo", LastName = "Desmet", UserName = "ugo.desmet@ulazarus.be", NormalizedUserName = "UGO.DESMET@ULAZARUS.BE", Email = "ugo.desmet@ulazarus.be", NormalizedEmail = "UGO.DESMET@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-10", ConcurrencyStamp = "STATIC-STAMP-10" },
    new ApplicationUser { Id = "Student11", FirstName = "Valerie", LastName = "Van den Broeck", UserName = "valerie.vandenbroeck@ulazarus.be", NormalizedUserName = "VALERIE.VANDENBROECK@ULAZARUS.BE", Email = "valerie.vandenbroeck@ulazarus.be", NormalizedEmail = "VALERIE.VANDENBROECK@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-11", ConcurrencyStamp = "STATIC-STAMP-11" },
new ApplicationUser { Id = "Student12", FirstName = "Wout", LastName = "Smet", UserName = "wout.smet@ulazarus.be", NormalizedUserName = "WOUT.SMET@ULAZARUS.BE", Email = "wout.smet@ulazarus.be", NormalizedEmail = "WOUT.SMET@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-12", ConcurrencyStamp = "STATIC-STAMP-12" },
new ApplicationUser { Id = "Student13", FirstName = "Xander", LastName = "Vermeiren", UserName = "xander.vermeiren@ulazarus.be", NormalizedUserName = "XANDER.VERMEIREN@ULAZARUS.BE", Email = "xander.vermeiren@ulazarus.be", NormalizedEmail = "XANDER.VERMEIREN@ULAZARUS.BE", EmailConfirmed = true , SecurityStamp = "Static-stamp-13", ConcurrencyStamp = "STATIC-STAMP-13" },
new ApplicationUser { Id = "Student14", FirstName = "Yana", LastName = "De Smet", UserName = "yana.desmet@ulazarus.be", NormalizedUserName = "YANA.DESMET@ULAZARUS.BE", Email = "yana.desmet@ulazarus.be", NormalizedEmail = "YANA.DESMET@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-14", ConcurrencyStamp = "STATIC-STAMP-14" },
new ApplicationUser { Id = "Student15", FirstName = "Zita", LastName = "Lemmens", UserName = "zita.lemmens@ulazarus.be", NormalizedUserName = "ZITA.LEMMENS@ULAZARUS.BE", Email = "zita.lemmens@ulazarus.be", NormalizedEmail = "ZITA.LEMMENS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-15", ConcurrencyStamp = "STATIC-STAMP-15" },
new ApplicationUser { Id = "Student16", FirstName = "Amber", LastName = "Coppens", UserName = "amber.coppens@ulazarus.be", NormalizedUserName = "AMBER.COPPENS@ULAZARUS.BE", Email = "amber.coppens@ulazarus.be", NormalizedEmail = "AMBER.COPPENS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-16", ConcurrencyStamp = "STATIC-STAMP-16" },
new ApplicationUser { Id = "Student17", FirstName = "Bram", LastName = "Wouters", UserName = "bram.wouters@ulazarus.be", NormalizedUserName = "BRAM.WOUTERS@ULAZARUS.BE", Email = "bram.wouters@ulazarus.be", NormalizedEmail = "BRAM.WOUTERS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-17", ConcurrencyStamp = "STATIC-STAMP-17" },
new ApplicationUser { Id = "Student18", FirstName = "Cato", LastName = "Boonen", UserName = "cato.boonen@ulazarus.be", NormalizedUserName = "CATO.BOONEN@ULAZARUS.BE", Email = "cato.boonen@ulazarus.be", NormalizedEmail = "CATO.BOONEN@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-18", ConcurrencyStamp = "STATIC-STAMP-18" },
new ApplicationUser { Id = "Student19", FirstName = "Dorien", LastName = "De Pauw", UserName = "dorien.depauw@ulazarus.be", NormalizedUserName = "DORIEN.DEPAUW@ULAZARUS.BE", Email = "dorien.depauw@ulazarus.be", NormalizedEmail = "DORIEN.DEPAUW@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-19", ConcurrencyStamp = "STATIC-STAMP-19" },
new ApplicationUser { Id = "Student20", FirstName = "Elias", LastName = "Vandenberghe", UserName = "elias.vandenberghe@ulazarus.be", NormalizedUserName = "ELIAS.VANDENBERGHE@ULAZARUS.BE", Email = "elias.vandenberghe@ulazarus.be", NormalizedEmail = "ELIAS.VANDENBERGHE@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-20", ConcurrencyStamp = "STATIC-STAMP-20" },
new ApplicationUser { Id = "Student21", FirstName = "Fien", LastName = "Verstraeten", UserName = "fien.verstraeten@ulazarus.be", NormalizedUserName = "FIEN.VERSTRAETEN@ULAZARUS.BE", Email = "fien.verstraeten@ulazarus.be", NormalizedEmail = "FIEN.VERSTRAETEN@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-21", ConcurrencyStamp = "STATIC-STAMP-21" },
new ApplicationUser { Id = "Student22", FirstName = "Gilles", LastName = "Lenaerts", UserName = "gilles.lenaerts@ulazarus.be", NormalizedUserName = "GILLES.LENAERTS@ULAZARUS.BE", Email = "gilles.lenaerts@ulazarus.be", NormalizedEmail = "GILLES.LENAERTS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-22", ConcurrencyStamp = "STATIC-STAMP-22" },
new ApplicationUser { Id = "Student23", FirstName = "Hanne", LastName = "Van Hecke", UserName = "hanne.vanhecke@ulazarus.be", NormalizedUserName = "HANNE.VANHECKE@ULAZARUS.BE", Email = "hanne.vanhecke@ulazarus.be", NormalizedEmail = "HANNE.VANHECKE@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-23", ConcurrencyStamp = "STATIC-STAMP-23" },
new ApplicationUser { Id = "Student24", FirstName = "Ilias", LastName = "Dierckx", UserName = "ilias.dierckx@ulazarus.be", NormalizedUserName = "ILIAS.DIERCKX@ULAZARUS.BE", Email = "ilias.dierckx@ulazarus.be", NormalizedEmail = "ILIAS.DIERCKX@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-24", ConcurrencyStamp = "STATIC-STAMP-24" },
new ApplicationUser { Id = "Student25", FirstName = "Joke", LastName = "Van Gorp", UserName = "joke.vangorp@ulazarus.be", NormalizedUserName = "JOKE.VANGORP@ULAZARUS.BE", Email = "joke.vangorp@ulazarus.be", NormalizedEmail = "JOKE.VANGORP@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-25", ConcurrencyStamp = "STATIC-STAMP-25" },
new ApplicationUser { Id = "Student26", FirstName = "Kasper", LastName = "Vandenhaute", UserName = "kasper.vandenhaute@ulazarus.be", NormalizedUserName = "KASPER.VANDENHAUTE@ULAZARUS.BE", Email = "kasper.vandenhaute@ulazarus.be", NormalizedEmail = "KASPER.VANDENHAUTE@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-26", ConcurrencyStamp = "STATIC-STAMP-26" },
new ApplicationUser { Id = "Student27", FirstName = "Lana", LastName = "Cools", UserName = "lana.cools@ulazarus.be", NormalizedUserName = "LANA.COOLS@ULAZARUS.BE", Email = "lana.cools@ulazarus.be", NormalizedEmail = "LANA.COOLS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-27", ConcurrencyStamp = "STATIC-STAMP-27" },
new ApplicationUser { Id = "Student28", FirstName = "Maarten", LastName = "De Ridder", UserName = "maarten.deridder@ulazarus.be", NormalizedUserName = "MAARTEN.DERIDDER@ULAZARUS.BE", Email = "maarten.deridder@ulazarus.be", NormalizedEmail = "MAARTEN.DERIDDER@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-28", ConcurrencyStamp = "STATIC-STAMP-28" },
new ApplicationUser { Id = "Student29", FirstName = "Nina", LastName = "Van de Velde", UserName = "nina.vandevelde@ulazarus.be", NormalizedUserName = "NINA.VANDEVELDE@ULAZARUS.BE", Email = "nina.vandevelde@ulazarus.be", NormalizedEmail = "NINA.VANDEVELDE@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-29", ConcurrencyStamp = "STATIC-STAMP-29" },
new ApplicationUser { Id = "Student30", FirstName = "Oona", LastName = "Segers", UserName = "oona.segers@ulazarus.be", NormalizedUserName = "OONA.SEGERS@ULAZARUS.BE", Email = "oona.segers@ulazarus.be", NormalizedEmail = "OONA.SEGERS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-30", ConcurrencyStamp = "STATIC-STAMP-30" },
new ApplicationUser {Id = "Student31", FirstName = "Pieter", LastName = "Diels", UserName = "pieter.diels@ulazarus.be", NormalizedUserName = "PIETER.DIELS@ULAZARUS.BE", Email = "pieter.diels@ulazarus.be", NormalizedEmail = "PIETER.DIELS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-31", ConcurrencyStamp = "STATIC-STAMP-31" },
new ApplicationUser {Id = "Student32", FirstName = "Quincy", LastName = "Helsen", UserName = "quincy.helsen@ulazarus.be", NormalizedUserName = "QUINCY.HELSEN@ULAZARUS.BE", Email = "quincy.helsen@ulazarus.be", NormalizedEmail = "QUINCY.HELSEN@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-32", ConcurrencyStamp = "STATIC-STAMP-32" },
new ApplicationUser {Id = "Student33", FirstName = "Roos", LastName = "De Pooter", UserName = "roos.depooter@ulazarus.be", NormalizedUserName = "ROOS.DEPOOTER@ULAZARUS.BE", Email = "roos.depooter@ulazarus.be", NormalizedEmail = "ROOS.DEPOOTER@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-33", ConcurrencyStamp = "STATIC-STAMP-33" },
new ApplicationUser {Id = "Student34", FirstName = "Simon", LastName = "D'Hoore", UserName = "simon.d'hoore@ulazarus.be", NormalizedUserName = "SIMON.D'HOORE@ULAZARUS.BE", Email = "simon.d'hoore@ulazarus.be", NormalizedEmail = "SIMON.D'HOORE@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-34", ConcurrencyStamp = "STATIC-STAMP-34" },
new ApplicationUser {Id = "Student35", FirstName = "Tine", LastName = "Vermassen", UserName = "tine.vermassen@ulazarus.be", NormalizedUserName = "TINE.VERMASSEN@ULAZARUS.BE", Email = "tine.vermassen@ulazarus.be", NormalizedEmail = "TINE.VERMASSEN@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-35", ConcurrencyStamp = "STATIC-STAMP-35" },
new ApplicationUser {Id = "Student36", FirstName = "Urs", LastName = "De Koninck", UserName = "urs.dekoninck@ulazarus.be", NormalizedUserName = "URS.DEKONINCK@ULAZARUS.BE", Email = "urs.dekoninck@ulazarus.be", NormalizedEmail = "URS.DEKONINCK@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-36", ConcurrencyStamp = "STATIC-STAMP-36" },
new ApplicationUser {Id = "Student37", FirstName = "Veerle", LastName = "Dewaele", UserName = "veerle.dewaele@ulazarus.be", NormalizedUserName = "VEERLE.DEWAELE@ULAZARUS.BE", Email = "veerle.dewaele@ulazarus.be", NormalizedEmail = "VEERLE.DEWAELE@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-37", ConcurrencyStamp = "STATIC-STAMP-37" },
new ApplicationUser {    Id = "Student38", FirstName = "Ward", LastName = "Claes", UserName = "ward.claes@ulazarus.be", NormalizedUserName = "WARD.CLAES@ULAZARUS.BE", Email = "ward.claes@ulazarus.be", NormalizedEmail = "WARD.CLAES@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-38", ConcurrencyStamp = "STATIC-STAMP-38" },
new ApplicationUser { Id = "Student39", FirstName = "Xenia", LastName = "Vanderhaegen", UserName = "xenia.vanderhaegen@ulazarus.be", NormalizedUserName = "XENIA.VANDERHAEGEN@ULAZARUS.BE", Email = "xenia.vanderhaegen@ulazarus.be", NormalizedEmail = "XENIA.VANDERHAEGEN@ULAZARUS.BE", EmailConfirmed = true , SecurityStamp = "Static-stamp-39", ConcurrencyStamp = "STATIC-STAMP-39" },
new ApplicationUser { Id = "Student40", FirstName = "Yorben", LastName = "De Winter", UserName = "yorben.dewinter@ulazarus.be", NormalizedUserName = "YORBEN.DEWINTER@ULAZARUS.BE", Email = "yorben.dewinter@ulazarus.be", NormalizedEmail = "YORBEN.DEWINTER@ULAZARUS.BE", EmailConfirmed = true , SecurityStamp = "Static-stamp-40", ConcurrencyStamp = "STATIC-STAMP-40" },
new ApplicationUser { Id = "Student41", FirstName = "Zoë", LastName = "Meeus", UserName = "zoë.meeus@ulazarus.be", NormalizedUserName = "ZOË.MEEUS@ULAZARUS.BE", Email = "zoë.meeus@ulazarus.be", NormalizedEmail = "ZOË.MEEUS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-1", ConcurrencyStamp = "STATIC-STAMP-41" },
new ApplicationUser { Id = "Student42", FirstName = "Annelies", LastName = "Demuynck", UserName = "annelies.demuynck@ulazarus.be", NormalizedUserName = "ANNELIES.DEMUYNCK@ULAZARUS.BE", Email = "annelies.demuynck@ulazarus.be", NormalizedEmail = "ANNELIES.DEMUYNCK@ULAZARUS.BE", EmailConfirmed = true , SecurityStamp = "Static-stamp-42", ConcurrencyStamp = "STATIC-STAMP-42" },
new ApplicationUser { Id = "Student43", FirstName = "Bert", LastName = "Vrancken", UserName = "bert.vrancken@ulazarus.be", NormalizedUserName = "BERT.VRANCKEN@ULAZARUS.BE", Email = "bert.vrancken@ulazarus.be", NormalizedEmail = "BERT.VRANCKEN@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-43", ConcurrencyStamp = "STATIC-STAMP-43" },
new ApplicationUser { Id = "Student44", FirstName = "Charlotte", LastName = "Moons", UserName = "charlotte.moons@ulazarus.be", NormalizedUserName = "CHARLOTTE.MOONS@ULAZARUS.BE", Email = "charlotte.moons@ulazarus.be", NormalizedEmail = "CHARLOTTE.MOONS@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-44", ConcurrencyStamp = "STATIC-STAMP-44" },
new ApplicationUser { Id = "Student45", FirstName = "Dylan", LastName = "Spillebeen", UserName = "dylan.spillebeen@ulazarus.be", NormalizedUserName = "DYLAN.SPILLEBEEN@ULAZARUS.BE", Email = "dylan.spillebeen@ulazarus.be", NormalizedEmail = "DYLAN.SPILLEBEEN@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-45", ConcurrencyStamp = "STATIC-STAMP-45" },
new ApplicationUser { Id = "Student46", FirstName = "Eline", LastName = "Vermeersch", UserName = "eline.vermeersch@ulazarus.be", NormalizedUserName = "ELINE.VERMEERSCH@ULAZARUS.BE", Email = "eline.vermeersch@ulazarus.be", NormalizedEmail = "ELINE.VERMEERSCH@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-46", ConcurrencyStamp = "STATIC-STAMP-46" },
new ApplicationUser { Id = "Student47", FirstName = "Frederik", LastName = "Van Looy", UserName = "frederik.vanlooy@ulazarus.be", NormalizedUserName = "FREDERIK.VANLOOY@ULAZARUS.BE", Email = "frederik.vanlooy@ulazarus.be", NormalizedEmail = "FREDERIK.VANLOOY@ULAZARUS.BE", EmailConfirmed = true , SecurityStamp = "Static-stamp-47", ConcurrencyStamp = "STATIC-STAMP-47" },
new ApplicationUser { Id = "Student48", FirstName = "Gwen", LastName = "Van Damme", UserName = "gwen.vandamme@ulazarus.be", NormalizedUserName = "GWEN.VANDAMME@ULAZARUS.BE", Email = "gwen.vandamme@ulazarus.be", NormalizedEmail = "GWEN.VANDAMME@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-48", ConcurrencyStamp = "STATIC-STAMP-48" },
new ApplicationUser { Id = "Student49", FirstName = "Hugo", LastName = "De Jonge", UserName = "hugo.dejonge@ulazarus.be", NormalizedUserName = "HUGO.DEJONGE@ULAZARUS.BE", Email = "hugo.dejonge@ulazarus.be", NormalizedEmail = "HUGO.DEJONGE@ULAZARUS.BE", EmailConfirmed = true , SecurityStamp = "Static-stamp-49", ConcurrencyStamp = "STATIC-STAMP-49" },
new ApplicationUser { Id = "Student50", FirstName = "Isa", LastName = "Vandewalle", UserName = "isa.vandewalle@ulazarus.be", NormalizedUserName = "ISA.VANDEWALLE@ULAZARUS.BE", Email = "isa.vandewalle@ulazarus.be", NormalizedEmail = "ISA.VANDEWALLE@ULAZARUS.BE", EmailConfirmed = true, SecurityStamp = "Static-stamp-50", ConcurrencyStamp = "STATIC-STAMP-50" }



);




            // Generate 50 Students
            modelBuilder.Entity<Student>().HasData(
      new Student { StudentId = 1, FirstName = "Lotte", LastName = "De Wilde", Email = "lotte.dewilde@ulazarus.be", FacultyId = 1, ScheduleId = 1, UserId = "Student1" },
      new Student { StudentId = 2, FirstName = "Milan", LastName = "Goossens", Email = "milan.goossens@ulazarus.be", FacultyId = 2, ScheduleId = 2, UserId = "Student2" },
      new Student { StudentId = 3, FirstName = "Noa", LastName = "Hermans", Email = "noa.hermans@ulazarus.be", FacultyId = 3, ScheduleId = 3, UserId = "Student3" },
      new Student { StudentId = 4, FirstName = "Olivier", LastName = "Willems", Email = "olivier.willems@ulazarus.be", FacultyId = 1, ScheduleId = 3, UserId = "Student4" },
      new Student { StudentId = 5, FirstName = "Pauline", LastName = "Vandamme", Email = "pauline.vandamme@ulazarus.be", FacultyId = 2, ScheduleId = 2, UserId = "Student5" },
      new Student { StudentId = 6, FirstName = "Quinten", LastName = "Jacobs", Email = "quinten.jacobs@ulazarus.be", FacultyId = 3, ScheduleId = 1, UserId = "Student6" },
      new Student { StudentId = 7, FirstName = "Rani", LastName = "Declercq", Email = "rani.declercq@ulazarus.be", FacultyId = 1, ScheduleId = 2, UserId = "Student7" },
      new Student { StudentId = 8, FirstName = "Stijn", LastName = "Van Acker", Email = "stijn.vanacker@ulazarus.be", FacultyId = 2, ScheduleId = 3, UserId = "Student8" },
      new Student { StudentId = 9, FirstName = "Tess", LastName = "Peeters", Email = "tess.peeters@ulazarus.be", FacultyId = 3, ScheduleId = 1, UserId = "Student9" },
      new Student { StudentId = 10, FirstName = "Ugo", LastName = "Desmet", Email = "ugo.desmet@ulazarus.be", FacultyId = 1, ScheduleId = 2, UserId = "Student10" },
      new Student { StudentId = 11, FirstName = "Valerie", LastName = "Van den Broeck", Email = "valerie.vandenbroeck@ulazarus.be", FacultyId = 2, ScheduleId = 1, UserId = "Student11" },
      new Student { StudentId = 12, FirstName = "Wout", LastName = "Smet", Email = "wout.smet@ulazarus.be", FacultyId = 3, ScheduleId = 2, UserId = "Student12" },
      new Student { StudentId = 13, FirstName = "Xander", LastName = "Vermeiren", Email = "xander.vermeiren@ulazarus.be", FacultyId = 1, ScheduleId = 3, UserId = "Student13" },
      new Student { StudentId = 14, FirstName = "Yana", LastName = "De Smet", Email = "yana.desmet@ulazarus.be", FacultyId = 2, ScheduleId = 3, UserId = "Student14" },
      new Student { StudentId = 15, FirstName = "Zita", LastName = "Lemmens", Email = "zita.lemmens@ulazarus.be", FacultyId = 3, ScheduleId = 1, UserId = "Student15" },
      new Student { StudentId = 16, FirstName = "Amber", LastName = "Coppens", Email = "amber.coppens@ulazarus.be", FacultyId = 1, ScheduleId = 1, UserId = "Student16" },
      new Student { StudentId = 17, FirstName = "Bram", LastName = "Wouters", Email = "bram.wouters@ulazarus.be", FacultyId = 2, ScheduleId = 2, UserId = "Student17" },
      new Student { StudentId = 18, FirstName = "Cato", LastName = "Boonen", Email = "cato.boonen@ulazarus.be", FacultyId = 3, ScheduleId = 3, UserId = "Student18" },
      new Student { StudentId = 19, FirstName = "Dorien", LastName = "De Pauw", Email = "dorien.depauw@ulazarus.be", FacultyId = 1, ScheduleId = 2, UserId = "Student19" },
      new Student { StudentId = 20, FirstName = "Elias", LastName = "Vandenberghe", Email = "elias.vandenberghe@ulazarus.be", FacultyId = 2, ScheduleId = 3, UserId = "Student20" },
      new Student { StudentId = 21, FirstName = "Fien", LastName = "Verstraeten", Email = "fien.verstraeten@ulazarus.be", FacultyId = 3, ScheduleId = 1, UserId = "Student21" },
      new Student { StudentId = 22, FirstName = "Gilles", LastName = "Lenaerts", Email = "gilles.lenaerts@ulazarus.be", FacultyId = 1, ScheduleId = 2, UserId = "Student22" },
      new Student { StudentId = 23, FirstName = "Hanne", LastName = "Van Hecke", Email = "hanne.vanhecke@ulazarus.be", FacultyId = 2, ScheduleId = 3, UserId = "Student23" },
      new Student { StudentId = 24, FirstName = "Ilias", LastName = "Dierckx", Email = "ilias.dierckx@ulazarus.be", FacultyId = 3, ScheduleId = 1, UserId = "Student24" },
      new Student { StudentId = 25, FirstName = "Joke", LastName = "Van Gorp", Email = "joke.vangorp@ulazarus.be", FacultyId = 1, ScheduleId = 1, UserId = "Student25" },
      new Student { StudentId = 26, FirstName = "Kasper", LastName = "Vandenhaute", Email = "kasper.vandenhaute@ulazarus.be", FacultyId = 2, ScheduleId = 1, UserId = "Student26" },
      new Student { StudentId = 27, FirstName = "Lana", LastName = "Cools", Email = "lana.cools@ulazarus.be", FacultyId = 3, ScheduleId = 2, UserId = "Student27" },
      new Student { StudentId = 28, FirstName = "Maarten", LastName = "De Ridder", Email = "maarten.deridder@ulazarus.be", FacultyId = 1, ScheduleId = 3, UserId = "Student28" },
      new Student { StudentId = 29, FirstName = "Nina", LastName = "Van de Velde", Email = "nina.vandevelde@ulazarus.be", FacultyId = 2, ScheduleId = 2, UserId = "Student29" },
      new Student { StudentId = 30, FirstName = "Oona", LastName = "Segers", Email = "oona.segers@ulazarus.be", FacultyId = 3, ScheduleId = 3, UserId = "Student30" },
      new Student { StudentId = 31, FirstName = "Pieter", LastName = "Diels", Email = "pieter.diels@ulazarus.be", FacultyId = 1, ScheduleId = 1, UserId = "Student31" },
      new Student { StudentId = 32, FirstName = "Quincy", LastName = "Helsen", Email = "quincy.helsen@ulazarus.be", FacultyId = 2, ScheduleId = 2, UserId = "Student32" },
      new Student { StudentId = 33, FirstName = "Roos", LastName = "De Pooter", Email = "roos.depooter@ulazarus.be", FacultyId = 3, ScheduleId = 3, UserId = "Student33" },
      new Student { StudentId = 34, FirstName = "Simon", LastName = "D'Hoore", Email = "simon.d'hoore@ulazarus.be", FacultyId = 1, ScheduleId = 2, UserId = "Student34" },
      new Student { StudentId = 35, FirstName = "Tine", LastName = "Vermassen", Email = "tine.vermassen@ulazarus.be", FacultyId = 2, ScheduleId = 1, UserId = "Student35" },
      new Student { StudentId = 36, FirstName = "Urs", LastName = "De Koninck", Email = "urs.dekoninck@ulazarus.be", FacultyId = 3, ScheduleId = 1, UserId = "Student36" },
      new Student { StudentId = 37, FirstName = "Veerle", LastName = "Dewaele", Email = "veerle.dewaele@ulazarus.be", FacultyId = 1, ScheduleId = 2, UserId = "Student37" },
      new Student { StudentId = 38, FirstName = "Ward", LastName = "Claes", Email = "ward.claes@ulazarus.be", FacultyId = 2, ScheduleId = 3, UserId = "Student38" },
      new Student { StudentId = 39, FirstName = "Xenia", LastName = "Vanderhaegen", Email = "xenia.vanderhaegen@ulazarus.be", FacultyId = 3, ScheduleId = 2, UserId = "Student39" },
      new Student { StudentId = 40, FirstName = "Yorben", LastName = "De Winter", Email = "yorben.dewinter@ulazarus.be", FacultyId = 1, ScheduleId = 1, UserId = "Student40" },
      new Student { StudentId = 41, FirstName = "Zoë", LastName = "Meeus", Email = "zoë.meeus@ulazarus.be", FacultyId = 2, ScheduleId = 1, UserId = "Student41" },
      new Student { StudentId = 42, FirstName = "Annelies", LastName = "Demuynck", Email = "annelies.demuynck@ulazarus.be", FacultyId = 3, ScheduleId = 2, UserId = "Student42" },
      new Student { StudentId = 43, FirstName = "Bert", LastName = "Vrancken", Email = "bert.vrancken@ulazarus.be", FacultyId = 1, ScheduleId = 3, UserId = "Student43" },
      new Student { StudentId = 44, FirstName = "Charlotte", LastName = "Moons", Email = "charlotte.moons@ulazarus.be", FacultyId = 2, ScheduleId = 2, UserId = "Student44" },
      new Student { StudentId = 45, FirstName = "Dylan", LastName = "Spillebeen", Email = "dylan.spillebeen@ulazarus.be", FacultyId = 3, ScheduleId = 3, UserId = "Student45" },
      new Student { StudentId = 46, FirstName = "Eline", LastName = "Vermeersch", Email = "eline.vermeersch@ulazarus.be", FacultyId = 1, ScheduleId = 1, UserId = "Student46" },
      new Student { StudentId = 47, FirstName = "Frederik", LastName = "Van Looy", Email = "frederik.vanlooy@ulazarus.be", FacultyId = 2, ScheduleId = 2, UserId = "Student47" },
      new Student { StudentId = 48, FirstName = "Gwen", LastName = "Van Damme", Email = "gwen.vandamme@ulazarus.be", FacultyId = 3, ScheduleId = 3, UserId = "Student48" },
      new Student { StudentId = 49, FirstName = "Hugo", LastName = "De Jonge", Email = "hugo.dejonge@ulazarus.be", FacultyId = 1, ScheduleId = 1, UserId = "Student49" },
      new Student { StudentId = 50, FirstName = "Isa", LastName = "Vandewalle", Email = "isa.vandewalle@ulazarus.be", FacultyId = 2, ScheduleId = 1, UserId = "Student50" }
  );


            // Generate CourseResults for each student (1–3 per student)
            // Predefined CourseResults to avoid dynamic generation in OnModelCreating       

            modelBuilder.Entity<CourseResult>().HasData(
                   new CourseResult { CourseResultId = 1, StudentId = 1, CourseId = 1, Score = 85.50m },
                new CourseResult { CourseResultId = 2, StudentId = 2, CourseId = 2, Score = 78.25m },
                new CourseResult { CourseResultId = 3, StudentId = 3, CourseId = 3, Score = 92.00m },
                new CourseResult { CourseResultId = 4, StudentId = 4, CourseId = 4, Score = 88.75m },
                new CourseResult { CourseResultId = 5, StudentId = 5, CourseId = 1, Score = 81.00m },
                new CourseResult { CourseResultId = 6, StudentId = 6, CourseId = 2, Score = 90.50m },
                new CourseResult { CourseResultId = 7, StudentId = 7, CourseId = 3, Score = 76.75m },
                new CourseResult { CourseResultId = 8, StudentId = 8, CourseId = 4, Score = 89.00m }
                );

            modelBuilder.Entity<CourseResult>()
                .Property(cr => cr.Score)
                .HasColumnType("decimal(5,2)"); // Adjust precision/scale as needed

        }
    }
}
