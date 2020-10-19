﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SSRD.IdentityUI.Core.Infrastructure.Data;

namespace SSRD.IdentityUI.Core.Infrastructure.Data.Migrations
{
    [DbContext(typeof(IdentityDbContext))]
    [Migration("20200811085508_AddUserImageTable")]
    partial class AddUserImageTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.EmailEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Group.GroupAttributeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GroupId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("Key");

                    b.ToTable("GroupAttributes");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Group.GroupEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Group.GroupUserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GroupId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupUsers");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.AppUserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("Enabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("FirstName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("LastName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("TwoFactor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleClaimEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.UserClaimEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.UserLoginEntity", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.UserRoleEntity", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.UserTokenEntity", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.InviteEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("ExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("GroupId")
                        .HasColumnType("text");

                    b.Property<string>("GroupRoleId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("GroupRoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Invite");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.PermissionEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.PermissionRoleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PermissionId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("PermissionRole");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.RoleAssignmentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CanAssigneRoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CanAssigneRoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleAssignments");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.SessionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int?>("EndType")
                        .HasColumnType("integer");

                    b.Property<string>("Ip")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("LastAccess")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_DeletedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.UserImageEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte[]>("BlobImage")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("_CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset?>("_ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserImage");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Group.GroupAttributeEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Group.GroupEntity", "Group")
                        .WithMany("GroupAttributes")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Group.GroupUserEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Group.GroupEntity", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.AppUserEntity", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleClaimEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.UserClaimEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.AppUserEntity", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.UserLoginEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.AppUserEntity", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.UserRoleEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.AppUserEntity", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.Identity.UserTokenEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.AppUserEntity", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.InviteEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Group.GroupEntity", "Group")
                        .WithMany("Invites")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", "GroupRole")
                        .WithMany()
                        .HasForeignKey("GroupRoleId");

                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.PermissionRoleEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.PermissionEntity", "Permission")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.RoleAssignmentEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", "CanAssigneRole")
                        .WithMany("CanBeAssignedBy")
                        .HasForeignKey("CanAssigneRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.RoleEntity", "Role")
                        .WithMany("CanAssigne")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.SessionEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.AppUserEntity", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SSRD.IdentityUI.Core.Data.Entities.UserImageEntity", b =>
                {
                    b.HasOne("SSRD.IdentityUI.Core.Data.Entities.Identity.AppUserEntity", "User")
                        .WithOne("UserImage")
                        .HasForeignKey("SSRD.IdentityUI.Core.Data.Entities.UserImageEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
