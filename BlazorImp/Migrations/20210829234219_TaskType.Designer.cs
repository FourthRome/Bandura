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
    [Migration("20210829234219_TaskType")]
    partial class TaskType
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

                    b.Property<int>("CourseSequenceID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BlazorImp.Models.CourseMembership", b =>
                {
                    b.Property<int>("CourseMembershipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CourseMembershipID");

                    b.ToTable("CourseMemberships");
                });

            modelBuilder.Entity("BlazorImp.Models.CourseSequence", b =>
                {
                    b.Property<int>("CourseSequenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ShouldPropagateProgress")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseSequenceID");

                    b.ToTable("CourseSequences");
                });

            modelBuilder.Entity("BlazorImp.Models.CourseSequenceElement", b =>
                {
                    b.Property<int>("CourseSequenceElementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseSequenceID")
                        .HasColumnType("int");

                    b.Property<int>("ElementIndex")
                        .HasColumnType("int");

                    b.Property<int?>("PageID")
                        .HasColumnType("int");

                    b.Property<int>("ParentCourseSequenceID")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("CourseSequenceElementID");

                    b.ToTable("CourseSequenceElements");
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

            modelBuilder.Entity("BlazorImp.Models.Page", b =>
                {
                    b.Property<int>("PageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FinalPageModelID")
                        .HasColumnType("int");

                    b.Property<int?>("InfoPageModelID")
                        .HasColumnType("int");

                    b.Property<int>("PageType")
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

            modelBuilder.Entity("BlazorImp.Models.PageStat", b =>
                {
                    b.Property<int>("PageStatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CorrectAnswerGiven")
                        .HasColumnType("bit");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("PageID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("PageStatID");

                    b.ToTable("PageStats");
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

                    b.Property<int>("SurveyPageModelID")
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

                    b.Property<int>("AttemptNumber")
                        .HasColumnType("int");

                    b.Property<bool>("Correct")
                        .HasColumnType("bit");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("TaskPageModelID")
                        .HasColumnType("int");

                    b.Property<string>("UserAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserComment")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int?>("TaskType")
                        .HasColumnType("int");

                    b.HasKey("TaskPageModelID");

                    b.ToTable("TaskPageModels");
                });

            modelBuilder.Entity("BlazorImp.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorImp.Models.UserAction", b =>
                {
                    b.Property<int>("UserActionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("DestinationPageID")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SourcePageID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserActionID");

                    b.ToTable("UserActions");
                });

            modelBuilder.Entity("BlazorImp.Models.UserLastPage", b =>
                {
                    b.Property<int>("UserLastPageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StepNumber")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserLastPageID");

                    b.ToTable("UserLastPages");
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
