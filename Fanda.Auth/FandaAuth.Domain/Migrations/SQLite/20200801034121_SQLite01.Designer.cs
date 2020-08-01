﻿// <auto-generated />
using System;
using FandaAuth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FandaAuth.Domain.Migrations.SQLite
{
    [DbContext(typeof(AuthContext))]
    [Migration("20200801034121_SQLite01")]
    partial class SQLite01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("FandaAuth.Domain.AppResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Creatable")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleteable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Exportable")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Importable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Printable")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Readable")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResourceType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ResourceTypeString")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Updateable")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId", "Code")
                        .IsUnique();

                    b.HasIndex("ApplicationId", "Name")
                        .IsUnique();

                    b.ToTable("AppResources");
                });

            modelBuilder.Entity("FandaAuth.Domain.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Edition")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Version")
                        .HasColumnType("TEXT")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("FandaAuth.Domain.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedByIp")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateExpires")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateRevoked")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("RevokedByIp")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("FandaAuth.Domain.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(16);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.HasIndex("Code", "TenantId")
                        .IsUnique();

                    b.HasIndex("Name", "TenantId")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("FandaAuth.Domain.RolePrivilege", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AppResourceId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Create")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Delete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Export")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Import")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Print")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Read")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Update")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoleId", "AppResourceId");

                    b.HasIndex("AppResourceId");

                    b.ToTable("RolePrivileges");
                });

            modelBuilder.Entity("FandaAuth.Domain.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(16);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("OrgCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("FandaAuth.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateLastLogin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .IsFixedLength(true)
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .IsFixedLength(true)
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<Guid>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("TenantId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FandaAuth.Domain.AppResource", b =>
                {
                    b.HasOne("FandaAuth.Domain.Application", "Application")
                        .WithMany("AppResources")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FandaAuth.Domain.RefreshToken", b =>
                {
                    b.HasOne("FandaAuth.Domain.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FandaAuth.Domain.Role", b =>
                {
                    b.HasOne("FandaAuth.Domain.Tenant", "Tenant")
                        .WithMany("Roles")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("FandaAuth.Domain.RolePrivilege", b =>
                {
                    b.HasOne("FandaAuth.Domain.AppResource", "AppResource")
                        .WithMany("Privileges")
                        .HasForeignKey("AppResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FandaAuth.Domain.Role", "Role")
                        .WithMany("Privileges")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FandaAuth.Domain.User", b =>
                {
                    b.HasOne("FandaAuth.Domain.Tenant", "Tenant")
                        .WithMany("Users")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
