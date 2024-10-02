﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TATU.Infrastructure;

#nullable disable

namespace TATU.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241001230644_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TATU.Domain.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("TATU.Domain.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("TATU.Domain.Master", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDismissed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoAvatarLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotosWorksLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WorkExperience")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("TATU.Domain.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTimeRecording")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ServicesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("MasterId");

                    b.HasIndex("ServicesId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TATU.Domain.Services", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("TATU.Domain.Manager", b =>
                {
                    b.HasBaseType("TATU.Domain.Account");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WorkExperience")
                        .HasColumnType("float");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("TATU.Domain.Order", b =>
                {
                    b.HasOne("TATU.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("TATU.Domain.Manager", "Manager")
                        .WithMany("Orders")
                        .HasForeignKey("ManagerId");

                    b.HasOne("TATU.Domain.Master", "Master")
                        .WithMany()
                        .HasForeignKey("MasterId");

                    b.HasOne("TATU.Domain.Services", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesId");

                    b.Navigation("Client");

                    b.Navigation("Manager");

                    b.Navigation("Master");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("TATU.Domain.Manager", b =>
                {
                    b.HasOne("TATU.Domain.Account", null)
                        .WithOne()
                        .HasForeignKey("TATU.Domain.Manager", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TATU.Domain.Manager", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
