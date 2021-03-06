﻿// <auto-generated />
using System;
using BlazorImp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorImp.Migrations
{
    [DbContext(typeof(BlazorImpContext))]
    [Migration("20210303103135_InitialTables")]
    partial class InitialTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("BlazorImp.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("QuestionsEntity");
                });

            modelBuilder.Entity("BlazorImp.Models.QuestionAdditionalData", b =>
                {
                    b.Property<int>("QuestionAdditionalDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("QuestionAdditionalDataId");

                    b.HasIndex("QuestionId")
                        .IsUnique()
                        .HasFilter("[QuestionId] IS NOT NULL");

                    b.ToTable("QuestionAdditionalDataEntity");
                });

            modelBuilder.Entity("BlazorImp.Models.QuestionAttempt", b =>
                {
                    b.Property<int>("QuestionAttemptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AttemptNumber")
                        .HasColumnType("int");

                    b.Property<double?>("Grade")
                        .HasColumnType("float");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserInput")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionAttemptId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId1");

                    b.ToTable("QuestionAttemptsEntity");
                });

            modelBuilder.Entity("BlazorImp.Models.QuizDetails", b =>
                {
                    b.Property<int>("QuizDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("QuizDetailsId");

                    b.HasIndex("QuestionId")
                        .IsUnique()
                        .HasFilter("[QuestionId] IS NOT NULL");

                    b.ToTable("QuizDetailsEntity");
                });

            modelBuilder.Entity("BlazorImp.Models.RightAnswer", b =>
                {
                    b.Property<int>("RightAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RightAnswerId");

                    b.HasIndex("QuestionId")
                        .IsUnique()
                        .HasFilter("[QuestionId] IS NOT NULL");

                    b.ToTable("RightAnswersEntity");
                });

            modelBuilder.Entity("BlazorImp.Models.UserAction", b =>
                {
                    b.Property<int>("UserActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Context")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Timestamp")
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserActionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserActionsEntity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("BlazorImp.Models.QuestionAdditionalData", b =>
                {
                    b.HasOne("BlazorImp.Models.Question", "Question")
                        .WithOne("AdditionalData")
                        .HasForeignKey("BlazorImp.Models.QuestionAdditionalData", "QuestionId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("BlazorImp.Models.QuestionAttempt", b =>
                {
                    b.HasOne("BlazorImp.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("Question");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorImp.Models.QuizDetails", b =>
                {
                    b.HasOne("BlazorImp.Models.Question", "Question")
                        .WithOne("QuizDetails")
                        .HasForeignKey("BlazorImp.Models.QuizDetails", "QuestionId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("BlazorImp.Models.RightAnswer", b =>
                {
                    b.HasOne("BlazorImp.Models.Question", "Question")
                        .WithOne("RightAnswer")
                        .HasForeignKey("BlazorImp.Models.RightAnswer", "QuestionId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("BlazorImp.Models.UserAction", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorImp.Models.Question", b =>
                {
                    b.Navigation("AdditionalData");

                    b.Navigation("QuizDetails");

                    b.Navigation("RightAnswer");
                });
#pragma warning restore 612, 618
        }
    }
}
