using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class SuperAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               $"INSERT INTO AspNetRoles VALUES('208B0368-99B5-40A8-B79C-6F4F6AA2823C','SuperAdmin','SUPERADMIN',NEWID())" +
               $"INSERT INTO AspNetRoles VALUES('4528005A-5F70-4C61-8072-FA8092597238','Admin','ADMIN',NEWID())" +
               $"INSERT INTO AspNetRoles VALUES('B3A95E45-D39B-4780-B732-F9C4BAE3D340', 'Student', 'STUDENT', NEWID())" +
               $"INSERT INTO AspNetRoles VALUES('625F0897-E483-4CBB-9DC4-A69A2061D9F0', 'Applicant', 'APPLICANT', NEWID())");

            migrationBuilder.Sql(
                $"INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName], [Address], [DateRegistered], [Deactivated], [HasCompletedNysc], [HasLaptop], [HasAnyProgrammingExp], [ProgrammingLanguagesExps], [ApplicantResideInEnugu], [ReasonForProgramming], [AboutYourSkills], [HowDoYouIntendToCopeStatement], [CV], [IsAdmin], [Status], [Password]) VALUES (N'83eed51e-591d-4c03-8756-1aab512b3318'," +
                $" N'bivisofttest@gmail.com', N'BIVISOFTTEST@GMAIL.COM', N'bivisofttest@gmail.com', N'BIVISOFTTEST@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEMxvig3pSBsLqXLeV3/DL4skz1BB8v7xW3HeKqXy1jvOyaUtFKy+3REChxCs4gCTQw==', N'WK3ASUSNFZKKWIZ36YOH2PEKCLHNCVRW', N'be411b87-f904-4eec-9545-6c25cc102868', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'BiviSoft', N'AcademyAdmin', NULL, N'2022-10-08 05:08:52.9762631', 0, 0, 0, 0, NULL, 0, NULL, NULL, NULL, NULL, 1, 0, NULL)");

            migrationBuilder.Sql($"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'83eed51e-591d-4c03-8756-1aab512b3318', N'208B0368-99B5-40A8-B79C-6F4F6AA2823C')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
