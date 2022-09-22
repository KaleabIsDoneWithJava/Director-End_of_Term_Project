using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Director.Migrations
{
    public partial class MadeHomeroomIdonClassnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Parents_ParentId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Classes_ClassId",
                table: "Assessments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Students_StudentId",
                table: "Assessments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Subjects_SubjectId",
                table: "Assessments");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceMisseds_Students_StudentId",
                table: "AttendanceMisseds");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendanceMisseds",
                table: "AttendanceMisseds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assessments",
                table: "Assessments");

            migrationBuilder.DropIndex(
                name: "IX_Assessments_ClassId",
                table: "Assessments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Announcements",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GrandFatherName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "GrandFatherName",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "AssessmentType",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "AssessmentWeight",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "AppointmentTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AnnouncementDate",
                table: "Announcements");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Parents",
                newName: "Parent");

            migrationBuilder.RenameTable(
                name: "Classes",
                newName: "Class");

            migrationBuilder.RenameTable(
                name: "AttendanceMisseds",
                newName: "AttendanceMissed");

            migrationBuilder.RenameTable(
                name: "Assessments",
                newName: "Assessment");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.RenameTable(
                name: "Announcements",
                newName: "Announcement");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ParentId",
                table: "Student",
                newName: "IX_Student_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ClassId",
                table: "Student",
                newName: "IX_Student_ClassId");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Class",
                newName: "SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceMisseds_StudentId",
                table: "AttendanceMissed",
                newName: "IX_AttendanceMissed_StudentId");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Assessment",
                newName: "OutOf");

            migrationBuilder.RenameIndex(
                name: "IX_Assessments_SubjectId",
                table: "Assessment",
                newName: "IX_Assessment_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Assessments_StudentId",
                table: "Assessment",
                newName: "IX_Assessment_StudentId");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Appointment",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Appointment",
                newName: "OfficeStaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_ParentId",
                table: "Appointment",
                newName: "IX_Appointment_OfficeStaffId");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "Announcement",
                newName: "OfficeStaffId");

            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Subject",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Student",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Student",
                type: "varchar(6)",
                unicode: false,
                maxLength: 6,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Student",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Student",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Student",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "Student",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrandFathersName",
                table: "Student",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parent",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Parent",
                type: "varchar(6)",
                unicode: false,
                maxLength: 6,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Parent",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Parent",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Parent",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "Parent",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrandFathersName",
                table: "Parent",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "HomeroomId",
                table: "Class",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Class",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectName",
                table: "AttendanceMissed",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Period",
                table: "AttendanceMissed",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "AttendanceMissed",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<double>(
                name: "Score",
                table: "Assessment",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Assessment",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointment",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Appointment",
                type: "varchar(250)",
                unicode: false,
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Announcement",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Announcement",
                type: "varchar(250)",
                unicode: false,
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parent",
                table: "Parent",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Class",
                table: "Class",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendanceMissed",
                table: "AttendanceMissed",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assessment",
                table: "Assessment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Announcement",
                table: "Announcement",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeStaff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FathersName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    GrandFathersName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeStaff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectForGrade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectForGrade", x => x.Id);
                    table.ForeignKey(
                        name: "FK__SubjectFo__Grade__2D27B809",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__SubjectFo__Subje__2C3393D0",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FathersName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    GrandFathersName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    SubjectForGradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Teacher__Subject__300424B4",
                        column: x => x.SubjectForGradeId,
                        principalTable: "SubjectForGrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_GradeId",
                table: "Class",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_HomeroomId",
                table: "Class",
                column: "HomeroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_SectionId",
                table: "Class",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_StudentId",
                table: "Appointment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcement_OfficeStaffId",
                table: "Announcement",
                column: "OfficeStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectForGrade_GradeId",
                table: "SubjectForGrade",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectForGrade_SubjectId",
                table: "SubjectForGrade",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SubjectForGradeId",
                table: "Teacher",
                column: "SubjectForGradeId");

            migrationBuilder.AddForeignKey(
                name: "FK__Announcem__Offic__34C8D9D1",
                table: "Announcement",
                column: "OfficeStaffId",
                principalTable: "OfficeStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Offic__403A8C7D",
                table: "Appointment",
                column: "OfficeStaffId",
                principalTable: "OfficeStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Stude__412EB0B6",
                table: "Appointment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Assessmen__Stude__440B1D61",
                table: "Assessment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Assessmen__Subje__44FF419A",
                table: "Assessment",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Attendanc__Stude__47DBAE45",
                table: "AttendanceMissed",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Class__GradeId__38996AB5",
                table: "Class",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Class__HomeroomI__398D8EEE",
                table: "Class",
                column: "HomeroomId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Class__SectionId__37A5467C",
                table: "Class",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Student__ClassId__3D5E1FD2",
                table: "Student",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Student__ParentI__3C69FB99",
                table: "Student",
                column: "ParentId",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Announcem__Offic__34C8D9D1",
                table: "Announcement");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Offic__403A8C7D",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Stude__412EB0B6",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Assessmen__Stude__440B1D61",
                table: "Assessment");

            migrationBuilder.DropForeignKey(
                name: "FK__Assessmen__Subje__44FF419A",
                table: "Assessment");

            migrationBuilder.DropForeignKey(
                name: "FK__Attendanc__Stude__47DBAE45",
                table: "AttendanceMissed");

            migrationBuilder.DropForeignKey(
                name: "FK__Class__GradeId__38996AB5",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK__Class__HomeroomI__398D8EEE",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK__Class__SectionId__37A5467C",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK__Student__ClassId__3D5E1FD2",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK__Student__ParentI__3C69FB99",
                table: "Student");

            migrationBuilder.DropTable(
                name: "OfficeStaff");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "SubjectForGrade");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parent",
                table: "Parent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Class",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_GradeId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_HomeroomId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_SectionId",
                table: "Class");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttendanceMissed",
                table: "AttendanceMissed");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assessment",
                table: "Assessment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_StudentId",
                table: "Appointment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Announcement",
                table: "Announcement");

            migrationBuilder.DropIndex(
                name: "IX_Announcement_OfficeStaffId",
                table: "Announcement");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GrandFathersName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "GrandFathersName",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Assessment");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Appointment");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Parent",
                newName: "Parents");

            migrationBuilder.RenameTable(
                name: "Class",
                newName: "Classes");

            migrationBuilder.RenameTable(
                name: "AttendanceMissed",
                newName: "AttendanceMisseds");

            migrationBuilder.RenameTable(
                name: "Assessment",
                newName: "Assessments");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.RenameTable(
                name: "Announcement",
                newName: "Announcements");

            migrationBuilder.RenameIndex(
                name: "IX_Student_ParentId",
                table: "Students",
                newName: "IX_Students_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_ClassId",
                table: "Students",
                newName: "IX_Students_ClassId");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "Classes",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendanceMissed_StudentId",
                table: "AttendanceMisseds",
                newName: "IX_AttendanceMisseds_StudentId");

            migrationBuilder.RenameColumn(
                name: "OutOf",
                table: "Assessments",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Assessment_SubjectId",
                table: "Assessments",
                newName: "IX_Assessments_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Assessment_StudentId",
                table: "Assessments",
                newName: "IX_Assessments_StudentId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Appointments",
                newName: "StaffId");

            migrationBuilder.RenameColumn(
                name: "OfficeStaffId",
                table: "Appointments",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_OfficeStaffId",
                table: "Appointments",
                newName: "IX_Appointments_ParentId");

            migrationBuilder.RenameColumn(
                name: "OfficeStaffId",
                table: "Announcements",
                newName: "StaffId");

            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldUnicode: false,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Students",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrandFatherName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldUnicode: false,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Parents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Parents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrandFatherName",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HomeroomId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<short>(
                name: "Grade",
                table: "Classes",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubjectName",
                table: "AttendanceMisseds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Period",
                table: "AttendanceMisseds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "AttendanceMisseds",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Score",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "AssessmentType",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssessmentWeight",
                table: "Assessments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Assessments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "AppointmentTime",
                table: "Appointments",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldUnicode: false,
                oldMaxLength: 250);

            migrationBuilder.AddColumn<DateTime>(
                name: "AnnouncementDate",
                table: "Announcements",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parents",
                table: "Parents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttendanceMisseds",
                table: "AttendanceMisseds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assessments",
                table: "Assessments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Announcements",
                table: "Announcements",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_ClassId",
                table: "Assessments",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ParentId",
                table: "Notifications",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_StudentId",
                table: "Notifications",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Parents_ParentId",
                table: "Appointments",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Classes_ClassId",
                table: "Assessments",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Students_StudentId",
                table: "Assessments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Subjects_SubjectId",
                table: "Assessments",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceMisseds_Students_StudentId",
                table: "AttendanceMisseds",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
