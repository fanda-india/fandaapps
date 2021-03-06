﻿// <auto-generated />
using System;
using FandaAuth.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FandaAuth.Domain.Migrations.MSSQL
{
    [DbContext(typeof(AuthContext))]
    partial class AuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FandaAuth.Domain.AppResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Creatable")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleteable")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Exportable")
                        .HasColumnType("bit");

                    b.Property<bool>("Importable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Printable")
                        .HasColumnType("bit");

                    b.Property<bool>("Readable")
                        .HasColumnType("bit");

                    b.Property<int>("ResourceType")
                        .HasColumnType("int");

                    b.Property<string>("ResourceTypeString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Updateable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId", "Code")
                        .IsUnique()
                        .HasFilter("[Code] IS NOT NULL");

                    b.HasIndex("ApplicationId", "Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("AppResources");
                });

            modelBuilder.Entity("FandaAuth.Domain.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(16)")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Edition")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Version")
                        .HasColumnType("varchar(16)")
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
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByIp")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateExpires")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRevoked")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("RevokedByIp")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("FandaAuth.Domain.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier");

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
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppResourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Create")
                        .HasColumnType("bit");

                    b.Property<bool>("Delete")
                        .HasColumnType("bit");

                    b.Property<bool>("Export")
                        .HasColumnType("bit");

                    b.Property<bool>("Import")
                        .HasColumnType("bit");

                    b.Property<bool>("Print")
                        .HasColumnType("bit");

                    b.Property<bool>("Read")
                        .HasColumnType("bit");

                    b.Property<bool>("Update")
                        .HasColumnType("bit");

                    b.HasKey("RoleId", "AppResourceId");

                    b.HasIndex("AppResourceId");

                    b.ToTable("RolePrivileges");
                });

            modelBuilder.Entity("FandaAuth.Domain.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("OrgCount")
                        .HasColumnType("int");

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
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateLastLogin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("char(255)")
                        .IsFixedLength(true)
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("char(255)")
                        .IsFixedLength(true)
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
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
