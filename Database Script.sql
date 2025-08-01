CREATE DATABASE ULazarus
GO
USE [ULazarus]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseResults]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseResults](
	[CourseResultId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
	[Score] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_CourseResults] PRIMARY KEY CLUSTERED 
(
	[CourseResultId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[FacultyId] [int] NULL,
	[SectorId] [int] NULL,
	[TeacherId] [int] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[FacultyId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[FacultyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[ScheduleId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sectors]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sectors](
	[SectorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Sectors] PRIMARY KEY CLUSTERED 
(
	[SectorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[FacultyId] [int] NULL,
	[ScheduleId] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 29/07/2025 10:49:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[FacultyId] [int] NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250608205038_FirstMigration', N'9.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250608205938_FixStampNum', N'9.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250624090903_FixCourseTeacherRelation', N'9.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250624093141_FixSchedule4thCourse', N'9.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250624094308_ScheduleRelationship', N'9.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250630100202_SeedingTeacherRole', N'9.0.5')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'role-admin', N'Admin', N'ADMIN', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'role-student', N'Student', N'STUDENT', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'role-teacher', N'Teacher', N'TEACHER', NULL)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'admin1', N'role-admin')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'admin2', N'role-admin')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'admin3', N'role-admin')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student1', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student10', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student11', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student12', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student13', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student14', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student15', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student16', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student17', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student18', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student19', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student2', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student20', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student21', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student22', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student23', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student24', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student25', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student26', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student27', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student28', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student29', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student3', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student30', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student31', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student32', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student33', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student34', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student35', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student36', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student37', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student38', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student39', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student4', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student40', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student41', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student42', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student43', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student44', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student45', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student46', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student47', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student48', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student49', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student5', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student50', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student6', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student7', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student8', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Student9', N'role-student')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher1', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher10', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher2', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher3', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher4', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher5', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher6', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher7', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher8', N'role-teacher')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'Teacher9', N'role-teacher')
GO
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'admin1', N'Wasim', N'Lazarus', N'wasim@ulazarus.be', N'WASIM@ULAZARUS.BE', N'wasim@ulazarus.be', N'WASIM@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEGK6RogjkBSAa6fYVOxzUEApQrWqJAwR+cBltzX1twWeYHnwMk8WTFXcgN1gTfcWLw==', N'static-stamp-71', N'STATIC-CONCURRENCY-71', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'admin2', N'Claire', N'Delacroix', N'claire@ulazarus.be', N'CLAIRE@ULAZARUS.BE', N'claire@ulazarus.be', N'CLAIRE@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEMsOb3MYw/i40kannTKyd+cssgtMjX3B4sP+ZJxF4K/BP6mR2sl8K1cB7b3lhgFlzw==', N'static-stamp-72', N'STATIC-CONCURRENCY-72', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'admin3', N'Jonas', N'Vermeulen', N'jonas@ulazarus.be', N'JONAS@ULAZARUS.BE', N'jonas@ulazarus.be', N'JONAS@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEHIVQqazd80EWJyGYLbcxkco4ax6bd4I9I29y4JtXh5Xp1tLXP1E5ttQ8GOAUsfKpw==', N'static-stamp-73', N'STATIC-CONCURRENCY-73', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student1', N'Lotte', N'De Wilde', N'lotte.dewilde@ulazarus.be', N'LOTTE.DEWILDE@ULAZARUS.BE', N'lotte.dewilde@ulazarus.be', N'LOTTE.DEWILDE@ULAZARUS.BE', 1, NULL, N'Static-stamp-1', N'STATIC-STAMP-1', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student10', N'Ugo', N'Desmet', N'ugo.desmet@ulazarus.be', N'UGO.DESMET@ULAZARUS.BE', N'ugo.desmet@ulazarus.be', N'UGO.DESMET@ULAZARUS.BE', 1, NULL, N'Static-stamp-10', N'STATIC-STAMP-10', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student11', N'Valerie', N'Van den Broeck', N'valerie.vandenbroeck@ulazarus.be', N'VALERIE.VANDENBROECK@ULAZARUS.BE', N'valerie.vandenbroeck@ulazarus.be', N'VALERIE.VANDENBROECK@ULAZARUS.BE', 1, NULL, N'Static-stamp-11', N'STATIC-STAMP-11', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student12', N'Wout', N'Smet', N'wout.smet@ulazarus.be', N'WOUT.SMET@ULAZARUS.BE', N'wout.smet@ulazarus.be', N'WOUT.SMET@ULAZARUS.BE', 1, NULL, N'Static-stamp-12', N'STATIC-STAMP-12', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student13', N'Xander', N'Vermeiren', N'xander.vermeiren@ulazarus.be', N'XANDER.VERMEIREN@ULAZARUS.BE', N'xander.vermeiren@ulazarus.be', N'XANDER.VERMEIREN@ULAZARUS.BE', 1, NULL, N'Static-stamp-13', N'STATIC-STAMP-13', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student14', N'Yana', N'De Smet', N'yana.desmet@ulazarus.be', N'YANA.DESMET@ULAZARUS.BE', N'yana.desmet@ulazarus.be', N'YANA.DESMET@ULAZARUS.BE', 1, NULL, N'Static-stamp-14', N'STATIC-STAMP-14', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student15', N'Zita', N'Lemmens', N'zita.lemmens@ulazarus.be', N'ZITA.LEMMENS@ULAZARUS.BE', N'zita.lemmens@ulazarus.be', N'ZITA.LEMMENS@ULAZARUS.BE', 1, NULL, N'Static-stamp-15', N'STATIC-STAMP-15', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student16', N'Amber', N'Coppens', N'amber.coppens@ulazarus.be', N'AMBER.COPPENS@ULAZARUS.BE', N'amber.coppens@ulazarus.be', N'AMBER.COPPENS@ULAZARUS.BE', 1, NULL, N'Static-stamp-16', N'STATIC-STAMP-16', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student17', N'Bram', N'Wouters', N'bram.wouters@ulazarus.be', N'BRAM.WOUTERS@ULAZARUS.BE', N'bram.wouters@ulazarus.be', N'BRAM.WOUTERS@ULAZARUS.BE', 1, NULL, N'Static-stamp-17', N'STATIC-STAMP-17', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student18', N'Cato', N'Boonen', N'cato.boonen@ulazarus.be', N'CATO.BOONEN@ULAZARUS.BE', N'cato.boonen@ulazarus.be', N'CATO.BOONEN@ULAZARUS.BE', 1, NULL, N'Static-stamp-18', N'STATIC-STAMP-18', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student19', N'Dorien', N'De Pauw', N'dorien.depauw@ulazarus.be', N'DORIEN.DEPAUW@ULAZARUS.BE', N'dorien.depauw@ulazarus.be', N'DORIEN.DEPAUW@ULAZARUS.BE', 1, NULL, N'Static-stamp-19', N'STATIC-STAMP-19', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student2', N'Milan', N'Goossens', N'milan.goossens@ulazarus.be', N'MILAN.GOOSSENS@ULAZARUS.BE', N'milan.goossens@ulazarus.be', N'MILAN.GOOSSENS@ULAZARUS.BE', 1, NULL, N'Static-stamp2', N'STATIC-STAMP-2', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student20', N'Elias', N'Vandenberghe', N'elias.vandenberghe@ulazarus.be', N'ELIAS.VANDENBERGHE@ULAZARUS.BE', N'elias.vandenberghe@ulazarus.be', N'ELIAS.VANDENBERGHE@ULAZARUS.BE', 1, NULL, N'Static-stamp-20', N'STATIC-STAMP-20', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student21', N'Fien', N'Verstraeten', N'fien.verstraeten@ulazarus.be', N'FIEN.VERSTRAETEN@ULAZARUS.BE', N'fien.verstraeten@ulazarus.be', N'FIEN.VERSTRAETEN@ULAZARUS.BE', 1, NULL, N'Static-stamp-21', N'STATIC-STAMP-21', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student22', N'Gilles', N'Lenaerts', N'gilles.lenaerts@ulazarus.be', N'GILLES.LENAERTS@ULAZARUS.BE', N'gilles.lenaerts@ulazarus.be', N'GILLES.LENAERTS@ULAZARUS.BE', 1, NULL, N'Static-stamp-22', N'STATIC-STAMP-22', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student23', N'Hanne', N'Van Hecke', N'hanne.vanhecke@ulazarus.be', N'HANNE.VANHECKE@ULAZARUS.BE', N'hanne.vanhecke@ulazarus.be', N'HANNE.VANHECKE@ULAZARUS.BE', 1, NULL, N'Static-stamp-23', N'STATIC-STAMP-23', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student24', N'Ilias', N'Dierckx', N'ilias.dierckx@ulazarus.be', N'ILIAS.DIERCKX@ULAZARUS.BE', N'ilias.dierckx@ulazarus.be', N'ILIAS.DIERCKX@ULAZARUS.BE', 1, NULL, N'Static-stamp-24', N'STATIC-STAMP-24', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student25', N'Joke', N'Van Gorp', N'joke.vangorp@ulazarus.be', N'JOKE.VANGORP@ULAZARUS.BE', N'joke.vangorp@ulazarus.be', N'JOKE.VANGORP@ULAZARUS.BE', 1, NULL, N'Static-stamp-25', N'STATIC-STAMP-25', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student26', N'Kasper', N'Vandenhaute', N'kasper.vandenhaute@ulazarus.be', N'KASPER.VANDENHAUTE@ULAZARUS.BE', N'kasper.vandenhaute@ulazarus.be', N'KASPER.VANDENHAUTE@ULAZARUS.BE', 1, NULL, N'Static-stamp-26', N'STATIC-STAMP-26', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student27', N'Lana', N'Cools', N'lana.cools@ulazarus.be', N'LANA.COOLS@ULAZARUS.BE', N'lana.cools@ulazarus.be', N'LANA.COOLS@ULAZARUS.BE', 1, NULL, N'Static-stamp-27', N'STATIC-STAMP-27', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student28', N'Maarten', N'De Ridder', N'maarten.deridder@ulazarus.be', N'MAARTEN.DERIDDER@ULAZARUS.BE', N'maarten.deridder@ulazarus.be', N'MAARTEN.DERIDDER@ULAZARUS.BE', 1, NULL, N'Static-stamp-28', N'STATIC-STAMP-28', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student29', N'Nina', N'Van de Velde', N'nina.vandevelde@ulazarus.be', N'NINA.VANDEVELDE@ULAZARUS.BE', N'nina.vandevelde@ulazarus.be', N'NINA.VANDEVELDE@ULAZARUS.BE', 1, NULL, N'Static-stamp-29', N'STATIC-STAMP-29', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student3', N'Noa', N'Hermans', N'noa.hermans@ulazarus.be', N'NOA.HERMANS@ULAZARUS.BE', N'noa.hermans@ulazarus.be', N'NOA.HERMANS@ULAZARUS.BE', 1, NULL, N'Static-stamp-3', N'STATIC-STAMP-3', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student30', N'Oona', N'Segers', N'oona.segers@ulazarus.be', N'OONA.SEGERS@ULAZARUS.BE', N'oona.segers@ulazarus.be', N'OONA.SEGERS@ULAZARUS.BE', 1, NULL, N'Static-stamp-30', N'STATIC-STAMP-30', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student31', N'Pieter', N'Diels', N'pieter.diels@ulazarus.be', N'PIETER.DIELS@ULAZARUS.BE', N'pieter.diels@ulazarus.be', N'PIETER.DIELS@ULAZARUS.BE', 1, NULL, N'Static-stamp-31', N'STATIC-STAMP-31', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student32', N'Quincy', N'Helsen', N'quincy.helsen@ulazarus.be', N'QUINCY.HELSEN@ULAZARUS.BE', N'quincy.helsen@ulazarus.be', N'QUINCY.HELSEN@ULAZARUS.BE', 1, NULL, N'Static-stamp-32', N'STATIC-STAMP-32', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student33', N'Roos', N'De Pooter', N'roos.depooter@ulazarus.be', N'ROOS.DEPOOTER@ULAZARUS.BE', N'roos.depooter@ulazarus.be', N'ROOS.DEPOOTER@ULAZARUS.BE', 1, NULL, N'Static-stamp-33', N'STATIC-STAMP-33', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student34', N'Simon', N'D''Hoore', N'simon.d''hoore@ulazarus.be', N'SIMON.D''HOORE@ULAZARUS.BE', N'simon.d''hoore@ulazarus.be', N'SIMON.D''HOORE@ULAZARUS.BE', 1, NULL, N'Static-stamp-34', N'STATIC-STAMP-34', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student35', N'Tine', N'Vermassen', N'tine.vermassen@ulazarus.be', N'TINE.VERMASSEN@ULAZARUS.BE', N'tine.vermassen@ulazarus.be', N'TINE.VERMASSEN@ULAZARUS.BE', 1, NULL, N'Static-stamp-35', N'STATIC-STAMP-35', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student36', N'Urs', N'De Koninck', N'urs.dekoninck@ulazarus.be', N'URS.DEKONINCK@ULAZARUS.BE', N'urs.dekoninck@ulazarus.be', N'URS.DEKONINCK@ULAZARUS.BE', 1, NULL, N'Static-stamp-36', N'STATIC-STAMP-36', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student37', N'Veerle', N'Dewaele', N'veerle.dewaele@ulazarus.be', N'VEERLE.DEWAELE@ULAZARUS.BE', N'veerle.dewaele@ulazarus.be', N'VEERLE.DEWAELE@ULAZARUS.BE', 1, NULL, N'Static-stamp-37', N'STATIC-STAMP-37', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student38', N'Ward', N'Claes', N'ward.claes@ulazarus.be', N'WARD.CLAES@ULAZARUS.BE', N'ward.claes@ulazarus.be', N'WARD.CLAES@ULAZARUS.BE', 1, NULL, N'Static-stamp-38', N'STATIC-STAMP-38', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student39', N'Xenia', N'Vanderhaegen', N'xenia.vanderhaegen@ulazarus.be', N'XENIA.VANDERHAEGEN@ULAZARUS.BE', N'xenia.vanderhaegen@ulazarus.be', N'XENIA.VANDERHAEGEN@ULAZARUS.BE', 1, NULL, N'Static-stamp-39', N'STATIC-STAMP-39', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student4', N'Olivier', N'Willems', N'olivier.willems@ulazarus.be', N'OLIVIER.WILLEMS@ULAZARUS.BE', N'olivier.willems@ulazarus.be', N'OLIVIER.WILLEMS@ULAZARUS.BE', 1, NULL, N'Static-stamp-4', N'STATIC-STAMP-4', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student40', N'Yorben', N'De Winter', N'yorben.dewinter@ulazarus.be', N'YORBEN.DEWINTER@ULAZARUS.BE', N'yorben.dewinter@ulazarus.be', N'YORBEN.DEWINTER@ULAZARUS.BE', 1, NULL, N'Static-stamp-40', N'STATIC-STAMP-40', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student41', N'Zoë', N'Meeus', N'zoë.meeus@ulazarus.be', N'ZOË.MEEUS@ULAZARUS.BE', N'zoë.meeus@ulazarus.be', N'ZOË.MEEUS@ULAZARUS.BE', 1, NULL, N'Static-stamp-1', N'STATIC-STAMP-41', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student42', N'Annelies', N'Demuynck', N'annelies.demuynck@ulazarus.be', N'ANNELIES.DEMUYNCK@ULAZARUS.BE', N'annelies.demuynck@ulazarus.be', N'ANNELIES.DEMUYNCK@ULAZARUS.BE', 1, NULL, N'Static-stamp-42', N'STATIC-STAMP-42', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student43', N'Bert', N'Vrancken', N'bert.vrancken@ulazarus.be', N'BERT.VRANCKEN@ULAZARUS.BE', N'bert.vrancken@ulazarus.be', N'BERT.VRANCKEN@ULAZARUS.BE', 1, NULL, N'Static-stamp-43', N'STATIC-STAMP-43', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student44', N'Charlotte', N'Moons', N'charlotte.moons@ulazarus.be', N'CHARLOTTE.MOONS@ULAZARUS.BE', N'charlotte.moons@ulazarus.be', N'CHARLOTTE.MOONS@ULAZARUS.BE', 1, NULL, N'Static-stamp-44', N'STATIC-STAMP-44', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student45', N'Dylan', N'Spillebeen', N'dylan.spillebeen@ulazarus.be', N'DYLAN.SPILLEBEEN@ULAZARUS.BE', N'dylan.spillebeen@ulazarus.be', N'DYLAN.SPILLEBEEN@ULAZARUS.BE', 1, NULL, N'Static-stamp-45', N'STATIC-STAMP-45', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student46', N'Eline', N'Vermeersch', N'eline.vermeersch@ulazarus.be', N'ELINE.VERMEERSCH@ULAZARUS.BE', N'eline.vermeersch@ulazarus.be', N'ELINE.VERMEERSCH@ULAZARUS.BE', 1, NULL, N'Static-stamp-46', N'STATIC-STAMP-46', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student47', N'Frederik', N'Van Looy', N'frederik.vanlooy@ulazarus.be', N'FREDERIK.VANLOOY@ULAZARUS.BE', N'frederik.vanlooy@ulazarus.be', N'FREDERIK.VANLOOY@ULAZARUS.BE', 1, NULL, N'Static-stamp-47', N'STATIC-STAMP-47', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student48', N'Gwen', N'Van Damme', N'gwen.vandamme@ulazarus.be', N'GWEN.VANDAMME@ULAZARUS.BE', N'gwen.vandamme@ulazarus.be', N'GWEN.VANDAMME@ULAZARUS.BE', 1, NULL, N'Static-stamp-48', N'STATIC-STAMP-48', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student49', N'Hugo', N'De Jonge', N'hugo.dejonge@ulazarus.be', N'HUGO.DEJONGE@ULAZARUS.BE', N'hugo.dejonge@ulazarus.be', N'HUGO.DEJONGE@ULAZARUS.BE', 1, NULL, N'Static-stamp-49', N'STATIC-STAMP-49', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student5', N'Pauline', N'Vandamme', N'pauline.vandamme@ulazarus.be', N'PAULINE.VANDAMME@ULAZARUS.BE', N'pauline.vandamme@ulazarus.be', N'PAULINE.VANDAMME@ULAZARUS.BE', 1, NULL, N'Static-stamp-5', N'STATIC-STAMP-5', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student50', N'Isa', N'Vandewalle', N'isa.vandewalle@ulazarus.be', N'ISA.VANDEWALLE@ULAZARUS.BE', N'isa.vandewalle@ulazarus.be', N'ISA.VANDEWALLE@ULAZARUS.BE', 1, NULL, N'Static-stamp-50', N'STATIC-STAMP-50', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student6', N'Quinten', N'Jacobs', N'quinten.jacobs@ulazarus.be', N'QUINTEN.JACOBS@ULAZARUS.BE', N'quinten.jacobs@ulazarus.be', N'QUINTEN.JACOBS@ULAZARUS.BE', 1, NULL, N'Static-stamp-6', N'STATIC-STAMP-6', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student7', N'Rani', N'Declercq', N'rani.declercq@ulazarus.be', N'RANI.DECLERCQ@ULAZARUS.BE', N'rani.declercq@ulazarus.be', N'RANI.DECLERCQ@ULAZARUS.BE', 1, NULL, N'Static-stamp-7', N'STATIC-STAMP-7', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student8', N'Stijn', N'Van Acker', N'stijn.vanacker@ulazarus.be', N'STIJN.VANACKER@ULAZARUS.BE', N'stijn.vanacker@ulazarus.be', N'STIJN.VANACKER@ULAZARUS.BE', 1, NULL, N'Static-stamp-8', N'STATIC-STAMP-8', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Student9', N'Tess', N'Peeters', N'tess.peeters@ulazarus.be', N'TESS.PEETERS@ULAZARUS.BE', N'tess.peeters@ulazarus.be', N'TESS.PEETERS@ULAZARUS.BE', 1, NULL, N'Static-stamp-9', N'STATIC-STAMP-9', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher1', N'Alice', N'Jansen', N'alice.jansen@ulazarus.be', N'ALICE.JANSEN@ULAZARUS.BE', N'alice.jansen@ulazarus.be', N'ALICE.JANSEN@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEIb6hf1M4W4sq4vAWiTkXGY6fzg8D+2mQ5qgB88i/alVCF+wxGxM+Hx8jx/vJb90yQ==', N'A3GN6CG5QQ65ZHPB2SOLXIRVX2UX5ORK', N'872769c0-aa5a-49fc-a76d-93e4a0a3763d', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher10', N'Jan', N'De Smet', N'jan.desmet@ulazarus.be', N'JAN.DESMET@ULAZARUS.BE', N'jan.desmet@ulazarus.be', N'JAN.DESMET@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEDk8PY5i4TLjqztTPTxJ/FklsDHYnbQW7HzEAaK7gqI77by3EcJI4tDnChttx2eI0Q==', N'V4F5LWDF4A626MIZEMXJ5OOUSSQQO7FZ', N'64d3beab-baa8-4c80-81e4-a7a21c236566', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher2', N'Bart', N'Peeters', N'bart.peeters@ulazarus.be', N'BART.PEETERS@ULAZARUS.BE', N'bart.peeters@ulazarus.be', N'BART.PEETERS@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEHUevIAOMZFJMPkcqlWv6twgal2vb18eIOrov16J+2JDzFSfcX9QFx+RdvaJwAWQ9Q==', N'YKEUGRYSYHYJVISBEXAKNDDIIQ2CI4RE', N'6b797449-a0ef-47ed-b7dd-577356841a37', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher3', N'Clara', N'De Vos', N'clara.devos@ulazarus.be', N'CLARA.DEVOS@ULAZARUS.BE', N'clara.devos@ulazarus.be', N'CLARA.DEVOS@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEPoV0gP/atVBrbUk0qphB+DcKf+qOsPH/MAIUd4vT2WxH8ABZFA8x1h7xOxfM7otyg==', N'MWAX7ZNYV6XE5PMCWIN3UIDRLZO2BZA5', N'fe16f6b4-c8fe-4d16-9ab9-51c5cf08088a', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher4', N'Daan', N'Vermeulen', N'daan.vermeulen@ulazarus.be', N'DAAN.VERMEULEN@ULAZARUS.BE', N'daan.vermeulen@ulazarus.be', N'DAAN.VERMEULEN@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAECN0Et37TVRIZC82kmvvU/Hw9CpmFuJqm0YuFEx0ERvBDMTXGOfD6GJTMfnSmJ15jA==', N'YZWB6ZNZ5DEBKUNHZ2DZMHDFTHTV2J6B', N'1036e804-b1fd-4134-829f-50216f76d36e', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher5', N'Eva', N'Maes', N'eva.maes@ulazarus.be', N'EVA.MAES@ULAZARUS.BE', N'eva.maes@ulazarus.be', N'EVA.MAES@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEAAT5C9MU3nRLBDsdvPqX3X6pikDm2K9sdGWi/wqgJg5bFt6Ug6FLzk0uR64PHwFdg==', N'HRCDDOHYUKJOQ3AFIUSFQRYRPIG4BF4M', N'9c80b715-9ae9-4cc2-9178-dcfcf5a2dbb0', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher6', N'Frank', N'Vandenberghe', N'frank.vdb@ulazarus.be', N'FRANK.VDB@ULAZARUS.BE', N'frank.vdb@ulazarus.be', N'FRANK.VDB@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEJgR5IBNhEL8M7Vaemu/10ceYMdWLgTmmTEt2kpW6+/r2iZDN+KHnqUdCsD5uE9eKA==', N'A2SQEZFR734HBBK2SZQEPMARA4JQKUKF', N'4fc649b3-daab-4c65-85c5-e21250bbe57c', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher7', N'Greet', N'Declerck', N'greet.declerck@ulazarus.be', N'GREET.DECLERCK@ULAZARUS.BE', N'greet.declerck@ulazarus.be', N'GREET.DECLERCK@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEK8s9Wk9eo4Rt2RLgUPpeCgmwiyz+8bI5F/TcfcQ7gg7B6W0cGfT4ILId0fqSh/lYQ==', N'QKROWP4DFUUR3UNK7YKQPQTK7H3TODU3', N'620e0c6b-c52b-4e2e-b4fe-313c1c31ac51', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher8', N'Hans', N'Lenaerts', N'hans.lenaerts@ulazarus.be', N'HANS.LENAERTS@ULAZARUS.BE', N'hans.lenaerts@ulazarus.be', N'HANS.LENAERTS@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEERtUBWWjfVImLtaoI0o9883vgcw0URDLOBh63LTypBWwopW0Y6B7fD/szlEOcsDmQ==', N'LLFE2W3TJTTIQ7NUS5FBUGKHLKFJOCKZ', N'344eb2b8-c8d0-4f32-a7b6-7e5aed33a0d8', NULL, 0, 0, NULL, 0, 0)
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'Teacher9', N'Ilse', N'Vandenheuvel', N'ilse.vandenheuvel@ulazarus.be', N'ILSE.VANDENHEUVEL@ULAZARUS.BE', N'ilse.vandenheuvel@ulazarus.be', N'ILSE.VANDENHEUVEL@ULAZARUS.BE', 1, N'AQAAAAIAAYagAAAAEF7Dd1lwzanLk3I6L7KsMDXEG1kMhrFd1Udx29muT2bwFCo/0t46ibikVloM9UMvIg==', N'5NHSVOL5HTM3QFM6VHT3R2RP6AXIZOIN', N'009a2217-8174-439f-8b4a-cd95f2be259f', NULL, 0, 0, NULL, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[CourseResults] ON 

INSERT [dbo].[CourseResults] ([CourseResultId], [StudentId], [CourseId], [Score]) VALUES (1, 1, 1, CAST(85.50 AS Decimal(5, 2)))
INSERT [dbo].[CourseResults] ([CourseResultId], [StudentId], [CourseId], [Score]) VALUES (2, 2, 2, CAST(78.25 AS Decimal(5, 2)))
INSERT [dbo].[CourseResults] ([CourseResultId], [StudentId], [CourseId], [Score]) VALUES (3, 3, 3, CAST(92.00 AS Decimal(5, 2)))
INSERT [dbo].[CourseResults] ([CourseResultId], [StudentId], [CourseId], [Score]) VALUES (4, 4, 4, CAST(88.75 AS Decimal(5, 2)))
INSERT [dbo].[CourseResults] ([CourseResultId], [StudentId], [CourseId], [Score]) VALUES (5, 5, 1, CAST(81.00 AS Decimal(5, 2)))
INSERT [dbo].[CourseResults] ([CourseResultId], [StudentId], [CourseId], [Score]) VALUES (6, 6, 2, CAST(90.50 AS Decimal(5, 2)))
INSERT [dbo].[CourseResults] ([CourseResultId], [StudentId], [CourseId], [Score]) VALUES (7, 7, 3, CAST(76.75 AS Decimal(5, 2)))
INSERT [dbo].[CourseResults] ([CourseResultId], [StudentId], [CourseId], [Score]) VALUES (8, 8, 4, CAST(89.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[CourseResults] OFF
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([CourseId], [Name], [FacultyId], [SectorId], [TeacherId]) VALUES (1, N'Programming C#', 1, 1, 1)
INSERT [dbo].[Courses] ([CourseId], [Name], [FacultyId], [SectorId], [TeacherId]) VALUES (2, N'Medical Ethics', 2, 2, 2)
INSERT [dbo].[Courses] ([CourseId], [Name], [FacultyId], [SectorId], [TeacherId]) VALUES (3, N'Financial Accounting', 3, 3, 3)
INSERT [dbo].[Courses] ([CourseId], [Name], [FacultyId], [SectorId], [TeacherId]) VALUES (4, N'European Literature', 4, 4, 4)
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Faculties] ON 

INSERT [dbo].[Faculties] ([FacultyId], [Name]) VALUES (1, N'Engineering')
INSERT [dbo].[Faculties] ([FacultyId], [Name]) VALUES (2, N'Health Sciences')
INSERT [dbo].[Faculties] ([FacultyId], [Name]) VALUES (3, N'Economics')
INSERT [dbo].[Faculties] ([FacultyId], [Name]) VALUES (4, N'Arts and Humanities')
SET IDENTITY_INSERT [dbo].[Faculties] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedules] ON 

INSERT [dbo].[Schedules] ([ScheduleId], [Name], [Date], [Location], [CourseId]) VALUES (1, N'Morning', CAST(N'2025-09-01T00:00:00.0000000' AS DateTime2), N'Campus A - Room 101', 1)
INSERT [dbo].[Schedules] ([ScheduleId], [Name], [Date], [Location], [CourseId]) VALUES (2, N'Afternoon', CAST(N'2025-09-02T00:00:00.0000000' AS DateTime2), N'Campus B - Room 202', 2)
INSERT [dbo].[Schedules] ([ScheduleId], [Name], [Date], [Location], [CourseId]) VALUES (3, N'Evening', CAST(N'2025-09-03T00:00:00.0000000' AS DateTime2), N'Campus C - Lab 1', 3)
INSERT [dbo].[Schedules] ([ScheduleId], [Name], [Date], [Location], [CourseId]) VALUES (4, N'Weekend', CAST(N'2025-09-01T00:00:00.0000000' AS DateTime2), N'Campus D - Room 404', 4)
SET IDENTITY_INSERT [dbo].[Schedules] OFF
GO
SET IDENTITY_INSERT [dbo].[Sectors] ON 

INSERT [dbo].[Sectors] ([SectorId], [Name]) VALUES (1, N'Software Development')
INSERT [dbo].[Sectors] ([SectorId], [Name]) VALUES (2, N'Nursing')
INSERT [dbo].[Sectors] ([SectorId], [Name]) VALUES (3, N'Finance')
INSERT [dbo].[Sectors] ([SectorId], [Name]) VALUES (4, N'Literature')
SET IDENTITY_INSERT [dbo].[Sectors] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (1, N'Lotte', N'De Wilde', N'lotte.dewilde@ulazarus.be', N'Student1', 1, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (2, N'Milan', N'Goossens', N'milan.goossens@ulazarus.be', N'Student2', 2, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (3, N'Noa', N'Hermans', N'noa.hermans@ulazarus.be', N'Student3', 3, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (4, N'Olivier', N'Willems', N'olivier.willems@ulazarus.be', N'Student4', 1, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (5, N'Pauline', N'Vandamme', N'pauline.vandamme@ulazarus.be', N'Student5', 2, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (6, N'Quinten', N'Jacobs', N'quinten.jacobs@ulazarus.be', N'Student6', 3, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (7, N'Rani', N'Declercq', N'rani.declercq@ulazarus.be', N'Student7', 1, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (8, N'Stijn', N'Van Acker', N'stijn.vanacker@ulazarus.be', N'Student8', 2, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (9, N'Tess', N'Peeters', N'tess.peeters@ulazarus.be', N'Student9', 3, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (10, N'Ugo', N'Desmet', N'ugo.desmet@ulazarus.be', N'Student10', 1, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (11, N'Valerie', N'Van den Broeck', N'valerie.vandenbroeck@ulazarus.be', N'Student11', 2, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (12, N'Wout', N'Smet', N'wout.smet@ulazarus.be', N'Student12', 3, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (13, N'Xander', N'Vermeiren', N'xander.vermeiren@ulazarus.be', N'Student13', 1, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (14, N'Yana', N'De Smet', N'yana.desmet@ulazarus.be', N'Student14', 2, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (15, N'Zita', N'Lemmens', N'zita.lemmens@ulazarus.be', N'Student15', 3, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (16, N'Amber', N'Coppens', N'amber.coppens@ulazarus.be', N'Student16', 1, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (17, N'Bram', N'Wouters', N'bram.wouters@ulazarus.be', N'Student17', 2, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (18, N'Cato', N'Boonen', N'cato.boonen@ulazarus.be', N'Student18', 3, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (19, N'Dorien', N'De Pauw', N'dorien.depauw@ulazarus.be', N'Student19', 1, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (20, N'Elias', N'Vandenberghe', N'elias.vandenberghe@ulazarus.be', N'Student20', 2, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (21, N'Fien', N'Verstraeten', N'fien.verstraeten@ulazarus.be', N'Student21', 3, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (22, N'Gilles', N'Lenaerts', N'gilles.lenaerts@ulazarus.be', N'Student22', 1, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (23, N'Hanne', N'Van Hecke', N'hanne.vanhecke@ulazarus.be', N'Student23', 2, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (24, N'Ilias', N'Dierckx', N'ilias.dierckx@ulazarus.be', N'Student24', 3, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (25, N'Joke', N'Van Gorp', N'joke.vangorp@ulazarus.be', N'Student25', 1, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (26, N'Kasper', N'Vandenhaute', N'kasper.vandenhaute@ulazarus.be', N'Student26', 2, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (27, N'Lana', N'Cools', N'lana.cools@ulazarus.be', N'Student27', 3, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (28, N'Maarten', N'De Ridder', N'maarten.deridder@ulazarus.be', N'Student28', 1, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (29, N'Nina', N'Van de Velde', N'nina.vandevelde@ulazarus.be', N'Student29', 2, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (30, N'Oona', N'Segers', N'oona.segers@ulazarus.be', N'Student30', 3, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (31, N'Pieter', N'Diels', N'pieter.diels@ulazarus.be', N'Student31', 1, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (32, N'Quincy', N'Helsen', N'quincy.helsen@ulazarus.be', N'Student32', 2, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (33, N'Roos', N'De Pooter', N'roos.depooter@ulazarus.be', N'Student33', 3, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (34, N'Simon', N'D''Hoore', N'simon.d''hoore@ulazarus.be', N'Student34', 1, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (35, N'Tine', N'Vermassen', N'tine.vermassen@ulazarus.be', N'Student35', 2, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (36, N'Urs', N'De Koninck', N'urs.dekoninck@ulazarus.be', N'Student36', 3, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (37, N'Veerle', N'Dewaele', N'veerle.dewaele@ulazarus.be', N'Student37', 1, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (38, N'Ward', N'Claes', N'ward.claes@ulazarus.be', N'Student38', 2, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (39, N'Xenia', N'Vanderhaegen', N'xenia.vanderhaegen@ulazarus.be', N'Student39', 3, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (40, N'Yorben', N'De Winter', N'yorben.dewinter@ulazarus.be', N'Student40', 1, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (41, N'Zoë', N'Meeus', N'zoë.meeus@ulazarus.be', N'Student41', 2, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (42, N'Annelies', N'Demuynck', N'annelies.demuynck@ulazarus.be', N'Student42', 3, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (43, N'Bert', N'Vrancken', N'bert.vrancken@ulazarus.be', N'Student43', 1, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (44, N'Charlotte', N'Moons', N'charlotte.moons@ulazarus.be', N'Student44', 2, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (45, N'Dylan', N'Spillebeen', N'dylan.spillebeen@ulazarus.be', N'Student45', 3, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (46, N'Eline', N'Vermeersch', N'eline.vermeersch@ulazarus.be', N'Student46', 1, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (47, N'Frederik', N'Van Looy', N'frederik.vanlooy@ulazarus.be', N'Student47', 2, 2)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (48, N'Gwen', N'Van Damme', N'gwen.vandamme@ulazarus.be', N'Student48', 3, 3)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (49, N'Hugo', N'De Jonge', N'hugo.dejonge@ulazarus.be', N'Student49', 1, 1)
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Email], [UserId], [FacultyId], [ScheduleId]) VALUES (50, N'Isa', N'Vandewalle', N'isa.vandewalle@ulazarus.be', N'Student50', 2, 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (1, N'Alice', N'Jansen', N'alice.jansen@ulazarus.be', N'Teacher1', 1)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (2, N'Bart', N'Peeters', N'bart.peeters@ulazarus.be', N'Teacher2', 2)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (3, N'Clara', N'De Vos', N'clara.devos@ulazarus.be', N'Teacher3', 3)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (4, N'Daan', N'Vermeulen', N'daan.vermeulen@ulazarus.be', N'Teacher4', 1)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (5, N'Eva', N'Maes', N'eva.maes@ulazarus.be', N'Teacher5', 2)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (6, N'Frank', N'Vandenberghe', N'frank.vdb@ulazarus.be', N'Teacher6', 3)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (7, N'Greet', N'Declerck', N'greet.declerck@ulazarus.be', N'Teacher7', 1)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (8, N'Hans', N'Lenaerts', N'hans.lenaerts@ulazarus.be', N'Teacher8', 2)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (9, N'Ilse', N'Vandenheuvel', N'ilse.vandenheuvel@ulazarus.be', N'Teacher9', 3)
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Email], [UserId], [FacultyId]) VALUES (10, N'Jan', N'De Smet', N'jan.desmet@ulazarus.be', N'Teacher10', 1)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[CourseResults]  WITH CHECK ADD  CONSTRAINT [FK_CourseResults_Courses_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseResults] CHECK CONSTRAINT [FK_CourseResults_Courses_CourseId]
GO
ALTER TABLE [dbo].[CourseResults]  WITH CHECK ADD  CONSTRAINT [FK_CourseResults_Students_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseResults] CHECK CONSTRAINT [FK_CourseResults_Students_StudentId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Faculties_FacultyId] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([FacultyId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Faculties_FacultyId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Sectors_SectorId] FOREIGN KEY([SectorId])
REFERENCES [dbo].[Sectors] ([SectorId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Sectors_SectorId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Teachers_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([TeacherId])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Teachers_TeacherId]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Courses_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Courses_CourseId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties_FacultyId] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([FacultyId])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties_FacultyId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Schedules_ScheduleId] FOREIGN KEY([ScheduleId])
REFERENCES [dbo].[Schedules] ([ScheduleId])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Schedules_ScheduleId]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Faculties_FacultyId] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([FacultyId])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Faculties_FacultyId]
GO
