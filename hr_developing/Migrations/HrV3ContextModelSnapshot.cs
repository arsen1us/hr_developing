﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hr_developing;

#nullable disable

namespace hr_developing.Migrations
{
    [DbContext(typeof(HrV3Context))]
    partial class HrV3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hr_developing.Client", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("id");

                    b.Property<short>("Age")
                        .HasColumnType("smallint")
                        .HasColumnName("age");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("surname");

                    b.HasKey("Id")
                        .HasName("PK__clients__3213E83FEEC1E448");

                    b.HasIndex(new[] { "Id" }, "UQ__clients__3213E83E2EBC316E")
                        .IsUnique();

                    b.ToTable("clients", (string)null);
                });

            modelBuilder.Entity("hr_developing.Company", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("id");

                    b.Property<string>("FkClientId")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("fk_client_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("owner");

                    b.HasKey("Id")
                        .HasName("PK__companie__3213E83FFF4E7158");

                    b.HasIndex("FkClientId");

                    b.HasIndex(new[] { "Id" }, "UQ__companie__3213E83EBAC99FA4")
                        .IsUnique();

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("hr_developing.Profession", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("id");

                    b.Property<string>("FkCompanyId")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("fk_company_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("name");

                    b.Property<double>("Salary")
                        .HasColumnType("float")
                        .HasColumnName("salary");

                    b.HasKey("Id")
                        .HasName("PK__professi__3213E83FD8A6AC09");

                    b.HasIndex("FkCompanyId");

                    b.HasIndex(new[] { "Id" }, "UQ__professi__3213E83E4566A7D7")
                        .IsUnique();

                    b.ToTable("professions", (string)null);
                });

            modelBuilder.Entity("hr_developing.Resume", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("id");

                    b.Property<string>("FkClientId")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("fk_client_id");

                    b.Property<string>("Keyskills")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("keyskills");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("profession");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("publication_date");

                    b.Property<TimeSpan>("PublicationTime")
                        .HasColumnType("time")
                        .HasColumnName("publication_time");

                    b.Property<double>("Salary")
                        .HasColumnType("float")
                        .HasColumnName("salary");

                    b.HasKey("Id")
                        .HasName("PK__resumes__3213E83FCD9A170A");

                    b.HasIndex("FkClientId");

                    b.HasIndex(new[] { "Id" }, "UQ__resumes__3213E83EEBCF7D3A")
                        .IsUnique();

                    b.ToTable("resumes", (string)null);
                });

            modelBuilder.Entity("hr_developing.WorkExperience", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("id");

                    b.Property<DateTime>("BeginningOfWork")
                        .HasColumnType("date")
                        .HasColumnName("beginning_of_work");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("company_name");

                    b.Property<DateTime>("EndingOfWork")
                        .HasColumnType("date")
                        .HasColumnName("ending_of_work");

                    b.Property<string>("FkClientId")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("fk_client_id");

                    b.Property<bool>("NowWorking")
                        .HasColumnType("bit")
                        .HasColumnName("now_working");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("profession");

                    b.Property<double>("Salary")
                        .HasColumnType("float")
                        .HasColumnName("salary");

                    b.HasKey("Id")
                        .HasName("PK__work_exp__3213E83F88BDB1E9");

                    b.HasIndex("FkClientId");

                    b.HasIndex(new[] { "Id" }, "UQ__work_exp__3213E83EE23ED64D")
                        .IsUnique();

                    b.ToTable("work_experience", (string)null);
                });

            modelBuilder.Entity("hr_developing.Company", b =>
                {
                    b.HasOne("hr_developing.Client", "FkClient")
                        .WithMany("Companies")
                        .HasForeignKey("FkClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__companies__fk_cl__4E88ABD4");

                    b.Navigation("FkClient");
                });

            modelBuilder.Entity("hr_developing.Profession", b =>
                {
                    b.HasOne("hr_developing.Company", "FkCompany")
                        .WithMany("Professions")
                        .HasForeignKey("FkCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__professio__fk_co__52593CB8");

                    b.Navigation("FkCompany");
                });

            modelBuilder.Entity("hr_developing.Resume", b =>
                {
                    b.HasOne("hr_developing.Client", "FkClient")
                        .WithMany("Resumes")
                        .HasForeignKey("FkClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__resumes__fk_clie__5EBF139D");

                    b.Navigation("FkClient");
                });

            modelBuilder.Entity("hr_developing.WorkExperience", b =>
                {
                    b.HasOne("hr_developing.Client", "FkClient")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("FkClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__work_expe__fk_cl__571DF1D5");

                    b.Navigation("FkClient");
                });

            modelBuilder.Entity("hr_developing.Client", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Resumes");

                    b.Navigation("WorkExperiences");
                });

            modelBuilder.Entity("hr_developing.Company", b =>
                {
                    b.Navigation("Professions");
                });
#pragma warning restore 612, 618
        }
    }
}
