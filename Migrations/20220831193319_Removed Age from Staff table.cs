using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Director.Migrations
{
    public partial class RemovedAgefromStafftable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FatherName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GrandFatherName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FirstName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FatherName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    GrandFatherName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Announcement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Detail = table.Column<string>(type: "text", nullable: true),
                    AnnouncementDate = table.Column<DateTime>(type: "date", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Announcem__Staff__36B12243",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateTime>(type: "date", nullable: true),
                    AppointmentTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Appointme__Paren__3F466844",
                        column: x => x.ParentID,
                        principalTable: "Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Appointme__Staff__403A8C7D",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<short>(type: "smallint", nullable: false),
                    Section = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    HomeroomID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Class__HomeroomI__29572725",
                        column: x => x.HomeroomID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Class__StaffID__286302EC",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Subject__StaffID__2C3393D0",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FatherName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GrandFatherName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Student__ClassId__33D4B598",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Student__ParentI__32E0915F",
                        column: x => x.ParentID,
                        principalTable: "Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    AssessmentType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AssessmentWeight = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    Score = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Assessmen__Class__3B75D760",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Assessmen__Staff__3C69FB99",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Assessmen__Stude__3A81B327",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Assessmen__Subje__398D8EEE",
                        column: x => x.SubjectID,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Details = table.Column<string>(type: "text", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "date", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Notificat__Paren__440B1D61",
                        column: x => x.ParentID,
                        principalTable: "Parent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Notificat__Staff__4316F928",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Notificat__Stude__44FF419A",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcement_StaffID",
                table: "Announcement",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_ParentID",
                table: "Appointment",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_StaffID",
                table: "Appointment",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_ClassId",
                table: "Assessment",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_StaffID",
                table: "Assessment",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_StudentID",
                table: "Assessment",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_SubjectID",
                table: "Assessment",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_StaffID",
                table: "Class",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "UQ__Class__5D3FDC8D08BB3D82",
                table: "Class",
                column: "HomeroomID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notification_ParentID",
                table: "Notification",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_StaffID",
                table: "Notification",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_StudentID",
                table: "Notification",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassId",
                table: "Student",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ParentID",
                table: "Student",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StaffID",
                table: "Subject",
                column: "StaffID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcement");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Assessment");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
