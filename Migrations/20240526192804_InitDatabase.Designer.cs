﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedFileProject.Data;

#nullable disable

namespace RedFileProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240526192804_InitDatabase")]
    partial class InitDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("RoleId")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Attachment", b =>
                {
                    b.Property<int>("AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AttachmentId"));

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Path")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("AttachmentId");

                    b.HasIndex("MessageId");

                    b.ToTable("Attachment", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Channel", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ChannelId"));

                    b.Property<int>("ChannelTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("ChannelId");

                    b.HasIndex("ChannelTypeId");

                    b.ToTable("Channel", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.ChannelPersonRole", b =>
                {
                    b.Property<int>("ChannelPersonRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ChannelPersonRoleId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("ChannelPersonRoleId");

                    b.ToTable("ChannelPersonRole", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.ChannelPersonRole_Person_Channel", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AffectDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ChannelPersonRoleId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "ChannelId")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex("ChannelId");

                    b.HasIndex("ChannelPersonRoleId");

                    b.ToTable("channelpersonrolexpersonxchannel", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.ChannelType", b =>
                {
                    b.Property<int>("ChannelTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ChannelTypeId"));

                    b.Property<string>("ChannelTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("ChannelTypeId");

                    b.ToTable("ChannelType", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatePost")
                        .HasColumnType("datetime");

                    b.Property<bool>("HasAttachment")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("MessageId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("PersonId");

                    b.ToTable("Message", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Message_Reaction_Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<int>("ReactionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PersonId", "MessageId", "ReactionId")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                    b.HasIndex("MessageId");

                    b.HasIndex("ReactionId");

                    b.ToTable("Message_Reaction_Person", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("NotificationDate")
                        .HasColumnType("datetime");

                    b.Property<int>("NotificationTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NotificationTypeId");

                    b.ToTable("Notification", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.NotificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("NotificationType", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.PersonJobTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("PersonJobTitle", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.PersonRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("PersonRole");
                });

            modelBuilder.Entity("RedFileProject.Models.PersonStatus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("ID");

                    b.ToTable("PersonStatus", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Person_Channel", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SignInDate")
                        .HasColumnType("datetime");

                    b.HasKey("PersonId", "ChannelId")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex("ChannelId");

                    b.ToTable("Person_Channel", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Person_Message", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReadDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PersonId", "MessageId")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex("MessageId");

                    b.ToTable("Person_Message", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Person_Notification", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("NotificationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReadDate")
                        .HasColumnType("datetime");

                    b.HasKey("PersonId", "NotificationId")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex("NotificationId");

                    b.ToTable("Person_Notification", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Reaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PicturePath")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Reaction", (string)null);
                });

            modelBuilder.Entity("RedFileProject.Models.Person", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime?>("DateCreatePerson")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int>("PersonJobTitleId")
                        .HasColumnType("int");

                    b.Property<int>("PersonRoleId")
                        .HasColumnType("int");

                    b.Property<int>("PersonStatusId")
                        .HasColumnType("int");

                    b.Property<string>("ProfilPicturePath")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasIndex("PersonJobTitleId");

                    b.HasIndex("PersonRoleId");

                    b.HasIndex("PersonStatusId");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RedFileProject.Models.Attachment", b =>
                {
                    b.HasOne("RedFileProject.Models.Message", "Message")
                        .WithMany("Attachments")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("RedFileProject.Models.Channel", b =>
                {
                    b.HasOne("RedFileProject.Models.ChannelType", "ChannelType")
                        .WithMany("Channels")
                        .HasForeignKey("ChannelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChannelType");
                });

            modelBuilder.Entity("RedFileProject.Models.ChannelPersonRole_Person_Channel", b =>
                {
                    b.HasOne("RedFileProject.Models.Channel", "Channel")
                        .WithMany("ChannelPersonRole_Person_Channel")
                        .HasForeignKey("ChannelId")
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.ChannelPersonRole", "ChannelPersonRole")
                        .WithMany("ChannelPersonRole_Person_Channel")
                        .HasForeignKey("ChannelPersonRoleId")
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.Person", "Person")
                        .WithMany("ChannelPersonRole_Person_Channel")
                        .HasForeignKey("PersonId")
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("ChannelPersonRole");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RedFileProject.Models.Message", b =>
                {
                    b.HasOne("RedFileProject.Models.Channel", "Channel")
                        .WithMany("Messages")
                        .HasForeignKey("ChannelId")
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.Person", "Person")
                        .WithMany("Messages")
                        .HasForeignKey("PersonId")
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RedFileProject.Models.Message_Reaction_Person", b =>
                {
                    b.HasOne("RedFileProject.Models.Message", "Message")
                        .WithMany("Message_Reaction_Person")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.Person", "Person")
                        .WithMany("Message_Reaction_Person")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.Reaction", "Reaction")
                        .WithMany("Message_Reaction_Person")
                        .HasForeignKey("ReactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("Person");

                    b.Navigation("Reaction");
                });

            modelBuilder.Entity("RedFileProject.Models.Notification", b =>
                {
                    b.HasOne("RedFileProject.Models.NotificationType", "NotificationType")
                        .WithMany("Notifications")
                        .HasForeignKey("NotificationTypeId")
                        .IsRequired();

                    b.Navigation("NotificationType");
                });

            modelBuilder.Entity("RedFileProject.Models.Person_Channel", b =>
                {
                    b.HasOne("RedFileProject.Models.Channel", "Channel")
                        .WithMany("Person_Channel")
                        .HasForeignKey("ChannelId")
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.Person", "Person")
                        .WithMany("Person_Channel")
                        .HasForeignKey("PersonId")
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RedFileProject.Models.Person_Message", b =>
                {
                    b.HasOne("RedFileProject.Models.Message", "Message")
                        .WithMany("Person_Message")
                        .HasForeignKey("MessageId")
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.Person", "Person")
                        .WithMany("Person_Message")
                        .HasForeignKey("PersonId")
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RedFileProject.Models.Person_Notification", b =>
                {
                    b.HasOne("RedFileProject.Models.Notification", "Notification")
                        .WithMany("Person_Notification")
                        .HasForeignKey("NotificationId")
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.Person", "Person")
                        .WithMany("Person_Notification")
                        .HasForeignKey("PersonId")
                        .IsRequired();

                    b.Navigation("Notification");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("RedFileProject.Models.Person", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithOne()
                        .HasForeignKey("RedFileProject.Models.Person", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.PersonJobTitle", "PersonJobTitle")
                        .WithMany("Persons")
                        .HasForeignKey("PersonJobTitleId")
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.PersonRole", "PersonRole")
                        .WithMany("Persons")
                        .HasForeignKey("PersonRoleId")
                        .IsRequired();

                    b.HasOne("RedFileProject.Models.PersonStatus", "PersonStatus")
                        .WithMany("Persons")
                        .HasForeignKey("PersonStatusId")
                        .IsRequired();

                    b.Navigation("PersonJobTitle");

                    b.Navigation("PersonRole");

                    b.Navigation("PersonStatus");
                });

            modelBuilder.Entity("RedFileProject.Models.Channel", b =>
                {
                    b.Navigation("ChannelPersonRole_Person_Channel");

                    b.Navigation("Messages");

                    b.Navigation("Person_Channel");
                });

            modelBuilder.Entity("RedFileProject.Models.ChannelPersonRole", b =>
                {
                    b.Navigation("ChannelPersonRole_Person_Channel");
                });

            modelBuilder.Entity("RedFileProject.Models.ChannelType", b =>
                {
                    b.Navigation("Channels");
                });

            modelBuilder.Entity("RedFileProject.Models.Message", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Message_Reaction_Person");

                    b.Navigation("Person_Message");
                });

            modelBuilder.Entity("RedFileProject.Models.Notification", b =>
                {
                    b.Navigation("Person_Notification");
                });

            modelBuilder.Entity("RedFileProject.Models.NotificationType", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("RedFileProject.Models.PersonJobTitle", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("RedFileProject.Models.PersonRole", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("RedFileProject.Models.PersonStatus", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("RedFileProject.Models.Reaction", b =>
                {
                    b.Navigation("Message_Reaction_Person");
                });

            modelBuilder.Entity("RedFileProject.Models.Person", b =>
                {
                    b.Navigation("ChannelPersonRole_Person_Channel");

                    b.Navigation("Message_Reaction_Person");

                    b.Navigation("Messages");

                    b.Navigation("Person_Channel");

                    b.Navigation("Person_Message");

                    b.Navigation("Person_Notification");
                });
#pragma warning restore 612, 618
        }
    }
}
