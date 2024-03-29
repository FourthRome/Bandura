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
    [Migration("20210727040937_FixNameMismatch")]
    partial class FixNameMismatch
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorImp.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BlazorImp.Models.FinalPageModel", b =>
                {
                    b.Property<int>("FinalPageModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FinalPageModelID");

                    b.ToTable("FinalPageModels");
                });

            modelBuilder.Entity("BlazorImp.Models.InfoPageModel", b =>
                {
                    b.Property<int>("InfoPageModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InfoPageModelID");

                    b.ToTable("InfoPageModels");
                });

            modelBuilder.Entity("BlazorImp.Models.LastUserPage", b =>
                {
                    b.Property<int>("LastUserPageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StepNumber")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("LastUserPageID");

                    b.ToTable("UserLastPages");
                });

            modelBuilder.Entity("BlazorImp.Models.Page", b =>
                {
                    b.Property<int>("PageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("FinalPageModelID")
                        .HasColumnType("int");

                    b.Property<int?>("InfoPageModelID")
                        .HasColumnType("int");

                    b.Property<int>("PageType")
                        .HasColumnType("int");

                    b.Property<int>("StepNumber")
                        .HasColumnType("int");

                    b.Property<int?>("SurveyPageModelID")
                        .HasColumnType("int");

                    b.Property<int?>("TaskPageModelID")
                        .HasColumnType("int");

                    b.Property<int?>("VideoPageModelID")
                        .HasColumnType("int");

                    b.HasKey("PageID");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("BlazorImp.Models.SurveyAnswer", b =>
                {
                    b.Property<int>("SurveyAnswerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("SurveyPageID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("SurveyAnswerID");

                    b.ToTable("SurveyAnswers");
                });

            modelBuilder.Entity("BlazorImp.Models.SurveyPageModel", b =>
                {
                    b.Property<int>("SurveyPageModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SurveyPageModelID");

                    b.ToTable("SurveyPageModels");
                });

            modelBuilder.Entity("BlazorImp.Models.TaskAttempt", b =>
                {
                    b.Property<int>("TaskAttemptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AttemptNumber")
                        .HasColumnType("int");

                    b.Property<bool>("Correct")
                        .HasColumnType("bit");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("TaskPageID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("TaskAttemptID");

                    b.ToTable("TaskAttempts");
                });

            modelBuilder.Entity("BlazorImp.Models.TaskPageModel", b =>
                {
                    b.Property<int>("TaskPageModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttemptNumberConstraint")
                        .HasColumnType("int");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskPageModelID");

                    b.ToTable("TaskPageModels");
                });

            modelBuilder.Entity("BlazorImp.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorImp.Models.VideoPageModel", b =>
                {
                    b.Property<int>("VideoPageModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoURI")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideoPageModelID");

                    b.ToTable("VideoPageModels");
                });
#pragma warning restore 612, 618
        }
    }
}
