﻿// <auto-generated />
using System;
using Director.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Director.Migrations
{
    [DbContext(typeof(SMSContext))]
    partial class SMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Director.Models.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AnnouncementDate")
                        .HasColumnType("date");

                    b.Property<string>("Detail")
                        .HasColumnType("text");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Announcement");
                });

            modelBuilder.Entity("Director.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AppointmentDate")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("AppointmentTime")
                        .HasColumnType("time");

                    b.Property<int>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("ParentID");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("StaffId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Director.Models.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssessmentType")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("AssessmentWeight")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Score")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnName("SubjectID");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("StaffId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Assessment");
                });

            modelBuilder.Entity("Director.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Grade")
                        .HasColumnType("smallint");

                    b.Property<int>("HomeroomId")
                        .HasColumnType("int")
                        .HasColumnName("HomeroomID");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength(true);

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.HasIndex(new[] { "HomeroomId" }, "UQ__Class__5D3FDC8D08BB3D82")
                        .IsUnique();

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Director.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("text");

                    b.Property<DateTime?>("NotificationDate")
                        .HasColumnType("date");

                    b.Property<int>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("ParentID");

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("StudentID");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("StaffId");

                    b.HasIndex("StudentId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("Director.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FatherName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength(true);

                    b.Property<string>("GrandFatherName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Parent");
                });

            modelBuilder.Entity("Director.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FatherName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength(true);

                    b.Property<string>("GrandFatherName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Role")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Director.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FatherName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength(true);

                    b.Property<string>("GrandFatherName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("ParentID");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("ParentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Director.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    b.Property<string>("SubjectName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("Director.Models.Announcement", b =>
                {
                    b.HasOne("Director.Models.Staff", "Staff")
                        .WithMany("Announcements")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK__Announcem__Staff__36B12243")
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Director.Models.Appointment", b =>
                {
                    b.HasOne("Director.Models.Parent", "Parent")
                        .WithMany("Appointments")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK__Appointme__Paren__3F466844")
                        .IsRequired();

                    b.HasOne("Director.Models.Staff", "Staff")
                        .WithMany("Appointments")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK__Appointme__Staff__403A8C7D")
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Director.Models.Assessment", b =>
                {
                    b.HasOne("Director.Models.Class", "Class")
                        .WithMany("Assessments")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__Assessmen__Class__3B75D760")
                        .IsRequired();

                    b.HasOne("Director.Models.Staff", "Staff")
                        .WithMany("Assessments")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK__Assessmen__Staff__3C69FB99")
                        .IsRequired();

                    b.HasOne("Director.Models.Student", "Student")
                        .WithMany("Assessments")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__Assessmen__Stude__3A81B327")
                        .IsRequired();

                    b.HasOne("Director.Models.Subject", "Subject")
                        .WithMany("Assessments")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK__Assessmen__Subje__398D8EEE")
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Staff");

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Director.Models.Class", b =>
                {
                    b.HasOne("Director.Models.Staff", "Homeroom")
                        .WithOne("ClassHomeroom")
                        .HasForeignKey("Director.Models.Class", "HomeroomId")
                        .HasConstraintName("FK__Class__HomeroomI__29572725")
                        .IsRequired();

                    b.HasOne("Director.Models.Staff", "Staff")
                        .WithMany("ClassStaffs")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK__Class__StaffID__286302EC")
                        .IsRequired();

                    b.Navigation("Homeroom");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Director.Models.Notification", b =>
                {
                    b.HasOne("Director.Models.Parent", "Parent")
                        .WithMany("Notifications")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK__Notificat__Paren__440B1D61")
                        .IsRequired();

                    b.HasOne("Director.Models.Staff", "Staff")
                        .WithMany("Notifications")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK__Notificat__Staff__4316F928")
                        .IsRequired();

                    b.HasOne("Director.Models.Student", "Student")
                        .WithMany("Notifications")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK__Notificat__Stude__44FF419A")
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Staff");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Director.Models.Student", b =>
                {
                    b.HasOne("Director.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK__Student__ClassId__33D4B598")
                        .IsRequired();

                    b.HasOne("Director.Models.Parent", "Parent")
                        .WithMany("Students")
                        .HasForeignKey("ParentId")
                        .HasConstraintName("FK__Student__ParentI__32E0915F")
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Director.Models.Subject", b =>
                {
                    b.HasOne("Director.Models.Staff", "Staff")
                        .WithMany("Subjects")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK__Subject__StaffID__2C3393D0")
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Director.Models.Class", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Director.Models.Parent", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Notifications");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Director.Models.Staff", b =>
                {
                    b.Navigation("Announcements");

                    b.Navigation("Appointments");

                    b.Navigation("Assessments");

                    b.Navigation("ClassHomeroom");

                    b.Navigation("ClassStaffs");

                    b.Navigation("Notifications");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Director.Models.Student", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("Director.Models.Subject", b =>
                {
                    b.Navigation("Assessments");
                });
#pragma warning restore 612, 618
        }
    }
}
