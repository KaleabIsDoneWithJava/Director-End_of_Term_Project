using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Director.Migrations
{
    public partial class CorrectedtheClasstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Announcem__Staff__36B12243",
                table: "Announcement");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Paren__3F466844",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Staff__403A8C7D",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Assessmen__Class__3B75D760",
                table: "Assessment");

            migrationBuilder.DropForeignKey(
                name: "FK__Assessmen__Staff__3C69FB99",
                table: "Assessment");

            migrationBuilder.DropForeignKey(
                name: "FK__Assessmen__Stude__3A81B327",
                table: "Assessment");

            migrationBuilder.DropForeignKey(
                name: "FK__Assessmen__Subje__398D8EEE",
                table: "Assessment");

            migrationBuilder.DropForeignKey(
                name: "FK__Class__HomeroomI__29572725",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK__Class__StaffID__286302EC",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK__Student__ClassId__33D4B598",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK__Student__ParentI__32E0915F",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK__Subject__StaffID__2C3393D0",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Subject_StaffID",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Class_StaffID",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "UQ__Class__5D3FDC8D08BB3D82",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Assessment_ClassId",
                table: "Assessment");

            migrationBuilder.DropIndex(
                name: "IX_Assessment_StaffID",
                table: "Assessment");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GrandFatherName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "GrandFatherName",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "AssessmentType",
                table: "Assessment");

            migrationBuilder.DropColumn(
                name: "AssessmentWeight",
                table: "Assessment");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Assessment");

            migrationBuilder.DropColumn(
                name: "AppointmentTime",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "AnnouncementDate",
                table: "Announcement");

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "Student",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_ParentID",
                table: "Student",
                newName: "IX_Student_ParentId");

            migrationBuilder.RenameColumn(
                name: "HomeroomID",
                table: "Class",
                newName: "HomeroomId");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "Class",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "SubjectID",
                table: "Assessment",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Assessment",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "Assessment",
                newName: "OutOf");

            migrationBuilder.RenameIndex(
                name: "IX_Assessment_SubjectID",
                table: "Assessment",
                newName: "IX_Assessment_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Assessment_StudentID",
                table: "Assessment",
                newName: "IX_Assessment_StudentId");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "Appointment",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ParentID",
                table: "Appointment",
                newName: "OfficeStaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_StaffID",
                table: "Appointment",
                newName: "IX_Appointment_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_ParentID",
                table: "Appointment",
                newName: "IX_Appointment_OfficeStaffId");

            migrationBuilder.RenameColumn(
                name: "StaffID",
                table: "Announcement",
                newName: "OfficeStaffId");

            migrationBuilder.RenameIndex(
                name: "IX_Announcement_StaffID",
                table: "Announcement",
                newName: "IX_Announcement_OfficeStaffId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Subject",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
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
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
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
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
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
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Student",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
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
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
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
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
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
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Parent",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Parent",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                name: "Id",
                table: "Class",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Class",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Class",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Score",
                table: "Assessment",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Assessment",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Appointment",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                oldType: "text",
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
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Announcement",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "AttendanceMissed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SubjectName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceMissed", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Attendanc__Stude__48CFD27E",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FathersName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    GrandFathersName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Teacher__Subject__2C3393D0",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectForGrade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectForGrade", x => x.Id);
                    table.ForeignKey(
                        name: "FK__SubjectFo__Grade__34C8D9D1",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__SubjectFo__Subje__33D4B598",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassTeacher",
                columns: table => new
                {
                    ClassTeachersId = table.Column<int>(type: "int", nullable: false),
                    TeachersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTeacher", x => new { x.ClassTeachersId, x.TeachersId });
                    table.ForeignKey(
                        name: "FK_ClassTeacher_Class_ClassTeachersId",
                        column: x => x.ClassTeachersId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassTeacher_Teacher_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_AttendanceMissed_StudentId",
                table: "AttendanceMissed",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassTeacher_TeachersId",
                table: "ClassTeacher",
                column: "TeachersId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectForGrade_GradeId",
                table: "SubjectForGrade",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectForGrade_SubjectId",
                table: "SubjectForGrade",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SubjectId",
                table: "Teacher",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK__Announcem__Offic__30F848ED",
                table: "Announcement",
                column: "OfficeStaffId",
                principalTable: "OfficeStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Offic__412EB0B6",
                table: "Appointment",
                column: "OfficeStaffId",
                principalTable: "OfficeStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Stude__4222D4EF",
                table: "Appointment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Assessmen__Stude__44FF419A",
                table: "Assessment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Assessmen__Subje__45F365D3",
                table: "Assessment",
                column: "SubjectId",
                principalTable: "Subject",
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
                name: "FK__Student__ClassId__3E52440B",
                table: "Student",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Student__ParentI__3D5E1FD2",
                table: "Student",
                column: "ParentId",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Announcem__Offic__30F848ED",
                table: "Announcement");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Offic__412EB0B6",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Appointme__Stude__4222D4EF",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK__Assessmen__Stude__44FF419A",
                table: "Assessment");

            migrationBuilder.DropForeignKey(
                name: "FK__Assessmen__Subje__45F365D3",
                table: "Assessment");

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
                name: "FK__Student__ClassId__3E52440B",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK__Student__ParentI__3D5E1FD2",
                table: "Student");

            migrationBuilder.DropTable(
                name: "AttendanceMissed");

            migrationBuilder.DropTable(
                name: "ClassTeacher");

            migrationBuilder.DropTable(
                name: "OfficeStaff");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "SubjectForGrade");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Class_GradeId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_HomeroomId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_SectionId",
                table: "Class");

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
                name: "SectionId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Assessment");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Student",
                newName: "ParentID");

            migrationBuilder.RenameIndex(
                name: "IX_Student_ParentId",
                table: "Student",
                newName: "IX_Student_ParentID");

            migrationBuilder.RenameColumn(
                name: "HomeroomId",
                table: "Class",
                newName: "HomeroomID");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Class",
                newName: "StaffID");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Assessment",
                newName: "SubjectID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Assessment",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "OutOf",
                table: "Assessment",
                newName: "StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_Assessment_SubjectId",
                table: "Assessment",
                newName: "IX_Assessment_SubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Assessment_StudentId",
                table: "Assessment",
                newName: "IX_Assessment_StudentID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Appointment",
                newName: "StaffID");

            migrationBuilder.RenameColumn(
                name: "OfficeStaffId",
                table: "Appointment",
                newName: "ParentID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_StudentId",
                table: "Appointment",
                newName: "IX_Appointment_StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_Appointment_OfficeStaffId",
                table: "Appointment",
                newName: "IX_Appointment_ParentID");

            migrationBuilder.RenameColumn(
                name: "OfficeStaffId",
                table: "Announcement",
                newName: "StaffID");

            migrationBuilder.RenameIndex(
                name: "IX_Announcement_OfficeStaffId",
                table: "Announcement",
                newName: "IX_Announcement_StaffID");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Subject",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "StaffID",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "Subject",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Student",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Student",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldUnicode: false,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Student",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Student",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Student",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Student",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrandFatherName",
                table: "Student",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Parent",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Parent",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldUnicode: false,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Parent",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Parent",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Parent",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Parent",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Parent",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Parent",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrandFatherName",
                table: "Parent",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Class",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<short>(
                name: "Grade",
                table: "Class",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Class",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Score",
                table: "Assessment",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Assessment",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AssessmentType",
                table: "Assessment",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssessmentWeight",
                table: "Assessment",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Assessment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointment",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Appointment",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "AppointmentTime",
                table: "Appointment",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Appointment",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Announcement",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Announcement",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldUnicode: false,
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Announcement",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "AnnouncementDate",
                table: "Announcement",
                type: "date",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FatherName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    FirstName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Gender = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    GrandFatherName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Role = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "text", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "date", nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true)
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
                name: "IX_Subject_StaffID",
                table: "Subject",
                column: "StaffID");

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
                name: "IX_Assessment_ClassId",
                table: "Assessment",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_StaffID",
                table: "Assessment",
                column: "StaffID");

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

            migrationBuilder.AddForeignKey(
                name: "FK__Announcem__Staff__36B12243",
                table: "Announcement",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Paren__3F466844",
                table: "Appointment",
                column: "ParentID",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__Staff__403A8C7D",
                table: "Appointment",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Assessmen__Class__3B75D760",
                table: "Assessment",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Assessmen__Staff__3C69FB99",
                table: "Assessment",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Assessmen__Stude__3A81B327",
                table: "Assessment",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Assessmen__Subje__398D8EEE",
                table: "Assessment",
                column: "SubjectID",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Class__HomeroomI__29572725",
                table: "Class",
                column: "HomeroomID",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Class__StaffID__286302EC",
                table: "Class",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Student__ClassId__33D4B598",
                table: "Student",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Student__ParentI__32E0915F",
                table: "Student",
                column: "ParentID",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__Subject__StaffID__2C3393D0",
                table: "Subject",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
