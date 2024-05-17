﻿// <auto-generated />
using System;
using AppFilm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppFilm.Net.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppFilm.Net.Areas.Identity.Data.ApplicationUser", b =>
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

                    b.ToTable("ApplicationUser", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.CollectionMovies", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<string>("IdUser")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdMovie", "IdUser");

                    b.HasIndex("IdUser");

                    b.ToTable("CollectionMovies", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameGenre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.GenreConnMovie", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("IdGenre")
                        .HasColumnType("int");

                    b.HasKey("IdMovie", "IdGenre");

                    b.HasIndex("IdGenre");

                    b.ToTable("GenreConnMovie", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.ItemMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMovie");

                    b.ToTable("ItemMovie", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameJob")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Job", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.LinkMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Episodes")
                        .HasColumnType("int");

                    b.Property<string>("File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgEpisodes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEPISODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LinkMovie", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Background")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMovieType")
                        .HasColumnType("int");

                    b.Property<int>("IdYears")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameVN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Point")
                        .HasColumnType("real");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdMovieType");

                    b.HasIndex("IdYears");

                    b.ToTable("Movie", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.MovieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameMovieType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MovieType", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.Nation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NameNation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nation", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.NationConnMovie", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("IdNation")
                        .HasColumnType("int");

                    b.HasKey("IdMovie", "IdNation");

                    b.HasIndex("IdNation");

                    b.ToTable("NationConnMovie", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePeople")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceofBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Story")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearofBirth")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("People", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.PeopleConnJob", b =>
                {
                    b.Property<int>("IdJob")
                        .HasColumnType("int");

                    b.Property<int>("IdPeople")
                        .HasColumnType("int");

                    b.HasKey("IdJob", "IdPeople");

                    b.HasIndex("IdPeople");

                    b.ToTable("PeopleConnJob", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.PeopleDirectorConnMovie", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("IdPeople")
                        .HasColumnType("int");

                    b.HasKey("IdMovie", "IdPeople");

                    b.HasIndex("IdPeople");

                    b.ToTable("PeopleDirectorConnMovies", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.PeoplePerformerConnMovie", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("IdPeople")
                        .HasColumnType("int");

                    b.HasKey("IdMovie", "IdPeople");

                    b.HasIndex("IdPeople");

                    b.ToTable("PeoplePerformerConnMovies", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Episodes")
                        .HasColumnType("int");

                    b.Property<string>("NameSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSSVN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Part")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("imgSS")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Season", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.SeasonsConnLinkMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdLinkMovie")
                        .HasColumnType("int");

                    b.Property<int>("IdSeason")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLinkMovie");

                    b.HasIndex("IdSeason");

                    b.ToTable("SeasonsConnLinkMovie", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.SeasonsConnMovie", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("IdSeason")
                        .HasColumnType("int");

                    b.HasKey("IdMovie", "IdSeason");

                    b.HasIndex("IdSeason");

                    b.ToTable("SeasonsConnMovie", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.SeasonsConnPeople", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPeople")
                        .HasColumnType("int");

                    b.Property<int>("IdSeason")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPeople");

                    b.HasIndex("IdSeason");

                    b.ToTable("SeasonsConnPeople", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.Trailers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trailers", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.TrailersConnMovie", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("IdTrailer")
                        .HasColumnType("int");

                    b.HasKey("IdMovie", "IdTrailer");

                    b.HasIndex("IdTrailer");

                    b.ToTable("TrailersConnMovie", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.ViewDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMovie");

                    b.ToTable("ViewDay", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.ViewMonth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMovie");

                    b.ToTable("ViewMonth", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.ViewWeek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMovie");

                    b.ToTable("ViewWeek", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.Years", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Years", (string)null);
                });

            modelBuilder.Entity("AppFilm.Net.Models.CollectionMovies", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany("collectionMovies")
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Areas.Identity.Data.ApplicationUser", "User")
                        .WithMany("collectionMovies")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AppFilm.Net.Models.GenreConnMovie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Genre", "Genre")
                        .WithMany("GenreConnMovies")
                        .HasForeignKey("IdGenre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany("GenreConnMovies")
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("AppFilm.Net.Models.ItemMovie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("AppFilm.Net.Models.Movie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.MovieType", "MovieType")
                        .WithMany()
                        .HasForeignKey("IdMovieType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.Years", "Years")
                        .WithMany()
                        .HasForeignKey("IdYears")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieType");

                    b.Navigation("Years");
                });

            modelBuilder.Entity("AppFilm.Net.Models.NationConnMovie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany("NationConnMovies")
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.Nation", "Nation")
                        .WithMany("NationConnMovies")
                        .HasForeignKey("IdNation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Nation");
                });

            modelBuilder.Entity("AppFilm.Net.Models.PeopleConnJob", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Job", "Job")
                        .WithMany("PeopleConnJobs")
                        .HasForeignKey("IdJob")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.People", "People")
                        .WithMany("PeopleConnJobs")
                        .HasForeignKey("IdPeople")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("People");
                });

            modelBuilder.Entity("AppFilm.Net.Models.PeopleDirectorConnMovie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany("PeopleDirectorConnMovies")
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.People", "People")
                        .WithMany("PeopleDirectorConnMovies")
                        .HasForeignKey("IdPeople")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("People");
                });

            modelBuilder.Entity("AppFilm.Net.Models.PeoplePerformerConnMovie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany("PeoplePerformerConnMovies")
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.People", "People")
                        .WithMany("PeoplePerformerConnMovies")
                        .HasForeignKey("IdPeople")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("People");
                });

            modelBuilder.Entity("AppFilm.Net.Models.SeasonsConnLinkMovie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.LinkMovie", "LinkMovie")
                        .WithMany()
                        .HasForeignKey("IdLinkMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("IdSeason")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LinkMovie");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("AppFilm.Net.Models.SeasonsConnMovie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany("SeasonsConnMovies")
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("IdSeason")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("AppFilm.Net.Models.SeasonsConnPeople", b =>
                {
                    b.HasOne("AppFilm.Net.Models.People", "People")
                        .WithMany()
                        .HasForeignKey("IdPeople")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("IdSeason")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("People");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("AppFilm.Net.Models.TrailersConnMovie", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany("TrailersConnMovies")
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppFilm.Net.Models.Trailers", "Trailers")
                        .WithMany()
                        .HasForeignKey("IdTrailer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Trailers");
                });

            modelBuilder.Entity("AppFilm.Net.Models.ViewDay", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("AppFilm.Net.Models.ViewMonth", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("AppFilm.Net.Models.ViewWeek", b =>
                {
                    b.HasOne("AppFilm.Net.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("AppFilm.Net.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Navigation("collectionMovies");
                });

            modelBuilder.Entity("AppFilm.Net.Models.Genre", b =>
                {
                    b.Navigation("GenreConnMovies");
                });

            modelBuilder.Entity("AppFilm.Net.Models.Job", b =>
                {
                    b.Navigation("PeopleConnJobs");
                });

            modelBuilder.Entity("AppFilm.Net.Models.Movie", b =>
                {
                    b.Navigation("GenreConnMovies");

                    b.Navigation("NationConnMovies");

                    b.Navigation("PeopleDirectorConnMovies");

                    b.Navigation("PeoplePerformerConnMovies");

                    b.Navigation("SeasonsConnMovies");

                    b.Navigation("TrailersConnMovies");

                    b.Navigation("collectionMovies");
                });

            modelBuilder.Entity("AppFilm.Net.Models.Nation", b =>
                {
                    b.Navigation("NationConnMovies");
                });

            modelBuilder.Entity("AppFilm.Net.Models.People", b =>
                {
                    b.Navigation("PeopleConnJobs");

                    b.Navigation("PeopleDirectorConnMovies");

                    b.Navigation("PeoplePerformerConnMovies");
                });
#pragma warning restore 612, 618
        }
    }
}