﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizBackEnd.Data;

namespace QuizBackEnd.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200720010209_QuestionChange")]
    partial class QuestionChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuizBackEnd.Models.Questions", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorrectAnswer")
                        .IsRequired();

                    b.Property<string>("IncorrectAnswer1")
                        .IsRequired();

                    b.Property<string>("IncorrectAnswer2")
                        .IsRequired();

                    b.Property<string>("IncorrectAnswer3")
                        .IsRequired();

                    b.Property<string>("Question")
                        .IsRequired();

                    b.Property<int?>("QuizId");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("QuizBackEnd.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("QuizId");

                    b.ToTable("Quiz");
                });

            modelBuilder.Entity("QuizBackEnd.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("Permission");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("QuizBackEnd.Models.Questions", b =>
                {
                    b.HasOne("QuizBackEnd.Models.Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId");
                });
#pragma warning restore 612, 618
        }
    }
}
