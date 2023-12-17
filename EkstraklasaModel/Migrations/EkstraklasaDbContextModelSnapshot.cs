﻿// <auto-generated />
using System;
using EkstraklasaModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EkstraklasaModel.Migrations
{
    [DbContext(typeof(EkstraklasaDbContext))]
    partial class EkstraklasaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("EkstraklasaModel.Bet", b =>
                {
                    b.Property<int>("BetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserOwnerUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BetId");

                    b.HasIndex("MatchId");

                    b.HasIndex("UserOwnerUserId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("EkstraklasaModel.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CountHostGoals")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CountVisitorGoals")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("HostTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RoundId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VisitorTeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MatchId");

                    b.HasIndex("HostTeamId");

                    b.HasIndex("RoundId");

                    b.HasIndex("VisitorTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("EkstraklasaModel.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("EkstraklasaModel.PlayerPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PlayerPositions");
                });

            modelBuilder.Entity("EkstraklasaModel.PredictedResult", b =>
                {
                    b.Property<int>("PredictedResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PredictedHostGoals")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PredictedVisitorGoals")
                        .HasColumnType("INTEGER");

                    b.HasKey("PredictedResultId");

                    b.HasIndex("MatchId");

                    b.ToTable("PredictedResults");
                });

            modelBuilder.Entity("EkstraklasaModel.Round", b =>
                {
                    b.Property<int>("RoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RoundEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RoundStart")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SeasonId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SeasonId1")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoundId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("SeasonId1");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("EkstraklasaModel.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("EkstraklasaModel.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EkstraklasaModel.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EkstraklasaModel.Bet", b =>
                {
                    b.HasOne("EkstraklasaModel.Match", "Match")
                        .WithMany("Bets")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkstraklasaModel.User", "UserOwner")
                        .WithMany("Bets")
                        .HasForeignKey("UserOwnerUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("UserOwner");
                });

            modelBuilder.Entity("EkstraklasaModel.Match", b =>
                {
                    b.HasOne("EkstraklasaModel.Team", "Host")
                        .WithMany()
                        .HasForeignKey("HostTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EkstraklasaModel.Round", null)
                        .WithMany("Matches")
                        .HasForeignKey("RoundId");

                    b.HasOne("EkstraklasaModel.Team", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Host");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("EkstraklasaModel.Player", b =>
                {
                    b.HasOne("EkstraklasaModel.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("EkstraklasaModel.PredictedResult", b =>
                {
                    b.HasOne("EkstraklasaModel.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");
                });

            modelBuilder.Entity("EkstraklasaModel.Round", b =>
                {
                    b.HasOne("EkstraklasaModel.Season", null)
                        .WithMany("FirstRounds")
                        .HasForeignKey("SeasonId");

                    b.HasOne("EkstraklasaModel.Season", null)
                        .WithMany("SecondRounds")
                        .HasForeignKey("SeasonId1");
                });

            modelBuilder.Entity("EkstraklasaModel.Match", b =>
                {
                    b.Navigation("Bets");
                });

            modelBuilder.Entity("EkstraklasaModel.Round", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("EkstraklasaModel.Season", b =>
                {
                    b.Navigation("FirstRounds");

                    b.Navigation("SecondRounds");
                });

            modelBuilder.Entity("EkstraklasaModel.Team", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("EkstraklasaModel.User", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}