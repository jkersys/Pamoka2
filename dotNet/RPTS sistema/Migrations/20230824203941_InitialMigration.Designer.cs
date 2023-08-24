﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPTS_sistema.Database;

#nullable disable

namespace RPTS_sistema.Migrations
{
    [DbContext(typeof(RptsContext))]
    [Migration("20230824203941_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.7");

            modelBuilder.Entity("AdministrativeInspectionLocalUser", b =>
                {
                    b.Property<int>("AdministrativeInspectionsAdministrativeInspectionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvestigatorsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AdministrativeInspectionsAdministrativeInspectionId", "InvestigatorsId");

                    b.HasIndex("InvestigatorsId");

                    b.ToTable("AdministrativeInspectionLocalUser");
                });

            modelBuilder.Entity("InvestigationLocalUser", b =>
                {
                    b.Property<int>("InvestigationsInvestigationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvestigatorsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("InvestigationsInvestigationId", "InvestigatorsId");

                    b.HasIndex("InvestigatorsId");

                    b.ToTable("InvestigationLocalUser");
                });

            modelBuilder.Entity("RPTS_sistema.Models.AdministrativeInspection", b =>
                {
                    b.Property<int>("AdministrativeInspectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ConclusionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("InspectionDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("AdministrativeInspectionId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ConclusionId");

                    b.ToTable("AdministrativeInspections");
                });

            modelBuilder.Entity("RPTS_sistema.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyAdress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CompanyFoundDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CompanyRegistrationNumber")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompanyDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RPTS_sistema.Models.Complain", b =>
                {
                    b.Property<int>("ComplainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ComplainDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Complainant")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ConclusionId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DecisionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("InvestigatorId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsComplainDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("ComplainId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ConclusionId");

                    b.HasIndex("InvestigatorId");

                    b.ToTable("Complain");
                });

            modelBuilder.Entity("RPTS_sistema.Models.Conclusion", b =>
                {
                    b.Property<int>("ConclusionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Decision")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsConclusionDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConclusionId");

                    b.ToTable("Conclusion");

                    b.HasData(
                        new
                        {
                            ConclusionId = 1,
                            Decision = "Skundas atmestas",
                            IsConclusionDeleted = false
                        },
                        new
                        {
                            ConclusionId = 2,
                            Decision = "Skundas priimtas",
                            IsConclusionDeleted = false
                        },
                        new
                        {
                            ConclusionId = 3,
                            Decision = "Pažeidimų nenustatyta",
                            IsConclusionDeleted = false
                        },
                        new
                        {
                            ConclusionId = 4,
                            Decision = "Nustatytas pažeidimas, pradėtas pažeidimo tyrimas",
                            IsConclusionDeleted = false
                        },
                        new
                        {
                            ConclusionId = 5,
                            Decision = "Nustatytas pažeidimas, tačiau pažeidimo tyrimas nepradėtas, nes įmonė laikoma nauju ūkio subjektu",
                            IsConclusionDeleted = false
                        },
                        new
                        {
                            ConclusionId = 6,
                            Decision = "Nutraukta dėl mažareikšmiškumo",
                            IsConclusionDeleted = false
                        },
                        new
                        {
                            ConclusionId = 7,
                            Decision = "Pažeidimo tyrimas baigtas, byloje priimtas sprendimas skirti baudą",
                            IsConclusionDeleted = false
                        },
                        new
                        {
                            ConclusionId = 8,
                            Decision = "Pažeidimo tyrimas baigtas, byloje priimtas tyrimą nutraukti",
                            IsConclusionDeleted = false
                        });
                });

            modelBuilder.Entity("RPTS_sistema.Models.Investigation", b =>
                {
                    b.Property<int>("InvestigationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommissionDecision")
                        .HasColumnType("TEXT");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ConclusionId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DecisionComplained")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsInvestigationDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LegalBase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Penalty")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("InvestigationId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ConclusionId");

                    b.ToTable("Investigation");
                });

            modelBuilder.Entity("RPTS_sistema.Models.InvestigationStage", b =>
                {
                    b.Property<int>("InvestigationStageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdministrativeInspectionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ComplainId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InvestigationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("InvestigationStageId");

                    b.HasIndex("AdministrativeInspectionId");

                    b.HasIndex("ComplainId");

                    b.HasIndex("InvestigationId");

                    b.ToTable("InvestigationStage");
                });

            modelBuilder.Entity("RPTS_sistema.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsUserDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("StillWorking")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("LocalUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "justinaskersys@gmail.com",
                            IsUserDeleted = false,
                            Lastname = "Admin",
                            Name = "Admin",
                            PasswordHash = new byte[] { 132, 36, 215, 21, 156, 232, 87, 79, 54, 42, 249, 117, 29, 249, 254, 130, 233, 191, 157, 238, 61, 39, 113, 206, 133, 202, 108, 6, 59, 22, 149, 96 },
                            PasswordSalt = new byte[] { 19, 240, 169, 179, 104, 34, 119, 10, 29, 142, 158, 51, 8, 185, 48, 120, 142, 170, 230, 96, 184, 67, 120, 128, 255, 250, 247, 153, 248, 45, 102, 32, 189, 57, 144, 51, 23, 89, 141, 244, 69, 86, 56, 187, 29, 76, 202, 99, 251, 222, 190, 162, 139, 132, 233, 98, 255, 46, 159, 181, 149, 109, 178, 93 },
                            Role = 2,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 2,
                            Email = "v.dabulskiene@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Dabulskienė",
                            Name = "Veronika",
                            PasswordHash = new byte[] { 48, 162, 141, 110, 205, 200, 17, 238, 135, 29, 161, 206, 236, 172, 27, 174, 115, 169, 42, 222, 0, 119, 245, 252, 215, 14, 117, 219, 205, 55, 158, 196 },
                            PasswordSalt = new byte[] { 237, 144, 93, 64, 95, 104, 160, 77, 141, 223, 119, 39, 85, 223, 211, 222, 100, 115, 117, 46, 84, 224, 239, 128, 42, 39, 137, 243, 149, 50, 49, 193, 9, 251, 38, 112, 196, 54, 104, 234, 151, 151, 82, 226, 58, 225, 187, 206, 66, 226, 248, 3, 119, 24, 249, 82, 0, 31, 55, 43, 59, 238, 212, 92 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 3,
                            Email = "i.baltusis@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Baltūsis",
                            Name = "Irmantas",
                            PasswordHash = new byte[] { 237, 133, 157, 232, 192, 251, 75, 62, 159, 197, 98, 238, 179, 199, 241, 70, 227, 156, 163, 183, 159, 65, 38, 85, 8, 237, 244, 17, 136, 229, 56, 206 },
                            PasswordSalt = new byte[] { 69, 55, 180, 88, 195, 37, 90, 251, 164, 195, 160, 215, 240, 209, 91, 16, 150, 149, 0, 59, 120, 61, 14, 2, 205, 193, 252, 115, 207, 104, 143, 33, 152, 1, 146, 0, 212, 200, 5, 136, 159, 159, 192, 194, 114, 69, 170, 159, 73, 26, 118, 28, 131, 116, 144, 159, 26, 200, 230, 157, 90, 172, 123, 157 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 4,
                            Email = "a.marcinkus@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Marcinkus",
                            Name = "Audrius",
                            PasswordHash = new byte[] { 242, 21, 106, 162, 18, 207, 10, 139, 215, 204, 142, 227, 226, 221, 168, 247, 19, 199, 194, 47, 170, 185, 183, 14, 53, 12, 237, 140, 21, 106, 160, 183 },
                            PasswordSalt = new byte[] { 1, 195, 213, 58, 79, 52, 166, 192, 153, 164, 76, 235, 82, 38, 57, 200, 143, 37, 52, 221, 120, 107, 204, 191, 116, 209, 122, 78, 0, 238, 250, 103, 139, 104, 97, 97, 181, 14, 45, 45, 251, 210, 184, 228, 37, 197, 190, 73, 58, 11, 246, 250, 117, 68, 222, 178, 244, 22, 234, 85, 14, 216, 93, 114 },
                            Role = 1,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 5,
                            Email = "g.markeviciute@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Markevičiūtė",
                            Name = "Gabrielė",
                            PasswordHash = new byte[] { 249, 48, 58, 205, 159, 45, 83, 85, 116, 178, 222, 15, 152, 2, 232, 182, 188, 194, 75, 253, 194, 17, 142, 251, 167, 207, 20, 166, 195, 108, 129, 175 },
                            PasswordSalt = new byte[] { 104, 123, 232, 40, 188, 251, 127, 96, 44, 138, 138, 231, 50, 120, 77, 87, 133, 94, 121, 141, 104, 195, 211, 147, 119, 225, 94, 86, 244, 214, 253, 58, 55, 238, 124, 171, 3, 183, 76, 239, 186, 241, 133, 218, 61, 9, 42, 251, 193, 134, 232, 242, 173, 61, 195, 143, 230, 137, 96, 247, 43, 146, 175, 117 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 6,
                            Email = "j.kersys@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Keršys",
                            Name = "Justinas",
                            PasswordHash = new byte[] { 158, 156, 88, 108, 185, 164, 4, 15, 157, 194, 155, 82, 94, 190, 18, 61, 123, 106, 234, 105, 22, 5, 81, 68, 237, 244, 17, 31, 120, 152, 214, 59 },
                            PasswordSalt = new byte[] { 142, 96, 90, 12, 29, 38, 128, 9, 238, 159, 113, 235, 155, 115, 230, 51, 142, 192, 51, 26, 137, 148, 88, 151, 208, 246, 135, 173, 111, 136, 1, 84, 71, 164, 222, 179, 133, 96, 148, 224, 134, 140, 199, 157, 120, 204, 187, 181, 54, 11, 58, 93, 193, 226, 52, 59, 117, 149, 209, 227, 64, 3, 200, 3 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 7,
                            Email = "l.matuseviciene@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Matusevičienė",
                            Name = "Laura",
                            PasswordHash = new byte[] { 85, 35, 27, 7, 6, 176, 203, 55, 174, 38, 251, 216, 134, 191, 234, 183, 65, 96, 173, 229, 37, 126, 221, 57, 24, 32, 219, 87, 234, 18, 56, 78 },
                            PasswordSalt = new byte[] { 222, 58, 232, 235, 119, 161, 74, 21, 83, 72, 251, 80, 158, 129, 186, 63, 103, 1, 158, 237, 28, 216, 61, 153, 22, 161, 121, 42, 154, 154, 190, 35, 192, 44, 219, 36, 16, 4, 40, 30, 244, 20, 179, 112, 126, 99, 148, 175, 40, 34, 40, 231, 14, 12, 37, 132, 238, 31, 39, 75, 73, 226, 186, 145 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 8,
                            Email = "i.zlatkus@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Zlatkus",
                            Name = "Ignas",
                            PasswordHash = new byte[] { 86, 243, 28, 245, 39, 164, 199, 225, 226, 242, 28, 216, 133, 11, 22, 18, 76, 18, 177, 127, 150, 187, 253, 191, 244, 85, 213, 86, 197, 92, 172, 242 },
                            PasswordSalt = new byte[] { 249, 51, 218, 143, 91, 110, 254, 96, 127, 104, 3, 230, 154, 230, 136, 230, 112, 252, 236, 3, 44, 221, 231, 170, 3, 182, 224, 209, 24, 6, 82, 175, 71, 48, 207, 1, 209, 3, 79, 212, 108, 86, 217, 99, 127, 39, 236, 133, 18, 125, 151, 3, 145, 113, 3, 93, 128, 62, 49, 86, 113, 246, 194, 18 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 9,
                            Email = "g.markeviciene@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Markevičienė",
                            Name = "Giedrė",
                            PasswordHash = new byte[] { 144, 255, 219, 29, 76, 5, 20, 189, 208, 140, 208, 95, 58, 73, 101, 255, 10, 106, 82, 88, 197, 70, 123, 81, 141, 107, 120, 4, 78, 98, 242, 194 },
                            PasswordSalt = new byte[] { 128, 96, 66, 95, 115, 252, 181, 244, 31, 84, 49, 166, 212, 218, 19, 4, 152, 92, 230, 12, 205, 231, 175, 96, 92, 47, 144, 140, 253, 164, 192, 169, 153, 106, 210, 182, 202, 182, 9, 85, 220, 253, 170, 207, 47, 237, 183, 136, 81, 3, 46, 78, 207, 127, 168, 103, 237, 248, 33, 140, 171, 86, 216, 209 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 10,
                            Email = "l.danauskiene@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Danauskienė",
                            Name = "Lina",
                            PasswordHash = new byte[] { 27, 67, 178, 25, 114, 192, 214, 231, 88, 133, 77, 69, 51, 54, 80, 243, 57, 168, 81, 234, 127, 183, 73, 113, 250, 108, 106, 113, 181, 108, 17, 238 },
                            PasswordSalt = new byte[] { 189, 112, 31, 237, 12, 12, 93, 240, 201, 215, 185, 250, 151, 205, 173, 129, 19, 10, 77, 68, 244, 135, 186, 131, 11, 87, 25, 133, 154, 181, 69, 215, 17, 72, 154, 215, 45, 196, 158, 224, 216, 225, 174, 228, 67, 70, 236, 71, 174, 148, 123, 142, 116, 64, 241, 83, 23, 241, 101, 245, 156, 59, 94, 193 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 11,
                            Email = "z.kraveciene@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Kravecienė",
                            Name = "Žyvilė",
                            PasswordHash = new byte[] { 135, 230, 248, 120, 51, 200, 139, 26, 103, 235, 179, 185, 221, 58, 86, 109, 29, 206, 110, 222, 105, 197, 172, 248, 136, 14, 202, 166, 88, 30, 71, 231 },
                            PasswordSalt = new byte[] { 39, 203, 106, 178, 172, 93, 237, 205, 240, 53, 255, 116, 121, 96, 122, 126, 73, 75, 211, 48, 86, 236, 177, 20, 125, 149, 134, 222, 243, 103, 45, 138, 172, 205, 183, 16, 141, 70, 139, 112, 233, 232, 26, 102, 74, 164, 93, 54, 3, 22, 91, 241, 51, 191, 231, 2, 203, 236, 214, 148, 161, 194, 136, 79 },
                            Role = 0,
                            StillWorking = true
                        },
                        new
                        {
                            Id = 12,
                            Email = "a.karvelis@litfood.lt",
                            IsUserDeleted = false,
                            Lastname = "Karvelis",
                            Name = "Audrius",
                            PasswordHash = new byte[] { 27, 119, 229, 143, 172, 246, 241, 106, 66, 134, 70, 249, 63, 78, 167, 85, 10, 205, 39, 252, 37, 239, 124, 34, 43, 131, 161, 158, 149, 255, 165, 222 },
                            PasswordSalt = new byte[] { 24, 96, 195, 186, 22, 52, 50, 192, 144, 29, 233, 202, 201, 114, 37, 210, 172, 94, 35, 81, 164, 214, 103, 12, 245, 128, 83, 45, 110, 203, 204, 189, 200, 173, 189, 140, 77, 179, 32, 152, 31, 174, 22, 67, 81, 105, 95, 219, 129, 136, 41, 73, 64, 35, 38, 80, 174, 166, 222, 111, 133, 234, 20, 36 },
                            Role = 0,
                            StillWorking = true
                        });
                });

            modelBuilder.Entity("AdministrativeInspectionLocalUser", b =>
                {
                    b.HasOne("RPTS_sistema.Models.AdministrativeInspection", null)
                        .WithMany()
                        .HasForeignKey("AdministrativeInspectionsAdministrativeInspectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPTS_sistema.Models.LocalUser", null)
                        .WithMany()
                        .HasForeignKey("InvestigatorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InvestigationLocalUser", b =>
                {
                    b.HasOne("RPTS_sistema.Models.Investigation", null)
                        .WithMany()
                        .HasForeignKey("InvestigationsInvestigationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPTS_sistema.Models.LocalUser", null)
                        .WithMany()
                        .HasForeignKey("InvestigatorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RPTS_sistema.Models.AdministrativeInspection", b =>
                {
                    b.HasOne("RPTS_sistema.Models.Company", "Company")
                        .WithMany("AdministrativeInspections")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPTS_sistema.Models.Conclusion", "Conclusion")
                        .WithMany("AdministrativeInspections")
                        .HasForeignKey("ConclusionId");

                    b.Navigation("Company");

                    b.Navigation("Conclusion");
                });

            modelBuilder.Entity("RPTS_sistema.Models.Complain", b =>
                {
                    b.HasOne("RPTS_sistema.Models.Company", "Company")
                        .WithMany("Complain")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPTS_sistema.Models.Conclusion", "Conclusion")
                        .WithMany("Complains")
                        .HasForeignKey("ConclusionId");

                    b.HasOne("RPTS_sistema.Models.LocalUser", "Investigator")
                        .WithMany("Complains")
                        .HasForeignKey("InvestigatorId");

                    b.Navigation("Company");

                    b.Navigation("Conclusion");

                    b.Navigation("Investigator");
                });

            modelBuilder.Entity("RPTS_sistema.Models.Investigation", b =>
                {
                    b.HasOne("RPTS_sistema.Models.Company", "Company")
                        .WithMany("Investigations")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPTS_sistema.Models.Conclusion", "Conclusion")
                        .WithMany("Investigations")
                        .HasForeignKey("ConclusionId");

                    b.Navigation("Company");

                    b.Navigation("Conclusion");
                });

            modelBuilder.Entity("RPTS_sistema.Models.InvestigationStage", b =>
                {
                    b.HasOne("RPTS_sistema.Models.AdministrativeInspection", null)
                        .WithMany("InvestigationStages")
                        .HasForeignKey("AdministrativeInspectionId");

                    b.HasOne("RPTS_sistema.Models.Complain", "Complain")
                        .WithMany()
                        .HasForeignKey("ComplainId");

                    b.HasOne("RPTS_sistema.Models.Investigation", null)
                        .WithMany("Stages")
                        .HasForeignKey("InvestigationId");

                    b.Navigation("Complain");
                });

            modelBuilder.Entity("RPTS_sistema.Models.AdministrativeInspection", b =>
                {
                    b.Navigation("InvestigationStages");
                });

            modelBuilder.Entity("RPTS_sistema.Models.Company", b =>
                {
                    b.Navigation("AdministrativeInspections");

                    b.Navigation("Complain");

                    b.Navigation("Investigations");
                });

            modelBuilder.Entity("RPTS_sistema.Models.Conclusion", b =>
                {
                    b.Navigation("AdministrativeInspections");

                    b.Navigation("Complains");

                    b.Navigation("Investigations");
                });

            modelBuilder.Entity("RPTS_sistema.Models.Investigation", b =>
                {
                    b.Navigation("Stages");
                });

            modelBuilder.Entity("RPTS_sistema.Models.LocalUser", b =>
                {
                    b.Navigation("Complains");
                });
#pragma warning restore 612, 618
        }
    }
}
