﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_boolflix.Data;

#nullable disable

namespace csharp_boolflix.Migrations
{
    [DbContext(typeof(BoolflixContext))]
    partial class BoolflixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("csharp_boolflix.Models.Actor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MediaLinkId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MediaLinkId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Episode", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<int?>("TvSerieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TvSerieId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Genre", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int>("MediaLinkId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MediaLinkId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("csharp_boolflix.Models.MediaLink", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<bool?>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MediaLinks");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Movie", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("MediaLinkId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MediaLinkId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("csharp_boolflix.Models.TvSerie", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("MediaLinkId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MediaLinkId");

                    b.ToTable("TvSeries");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Actor", b =>
                {
                    b.HasOne("csharp_boolflix.Models.MediaLink", "MediaLink")
                        .WithMany("Actors")
                        .HasForeignKey("MediaLinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaLink");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Episode", b =>
                {
                    b.HasOne("csharp_boolflix.Models.TvSerie", "TVSerie")
                        .WithMany()
                        .HasForeignKey("TvSerieId");

                    b.Navigation("TVSerie");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Genre", b =>
                {
                    b.HasOne("csharp_boolflix.Models.MediaLink", "MediaLink")
                        .WithMany("Genres")
                        .HasForeignKey("MediaLinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaLink");
                });

            modelBuilder.Entity("csharp_boolflix.Models.Movie", b =>
                {
                    b.HasOne("csharp_boolflix.Models.MediaLink", "MediaLink")
                        .WithMany("Movies")
                        .HasForeignKey("MediaLinkId");

                    b.Navigation("MediaLink");
                });

            modelBuilder.Entity("csharp_boolflix.Models.TvSerie", b =>
                {
                    b.HasOne("csharp_boolflix.Models.MediaLink", "MediaLink")
                        .WithMany("TvSeries")
                        .HasForeignKey("MediaLinkId");

                    b.Navigation("MediaLink");
                });

            modelBuilder.Entity("csharp_boolflix.Models.MediaLink", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Genres");

                    b.Navigation("Movies");

                    b.Navigation("TvSeries");
                });
#pragma warning restore 612, 618
        }
    }
}
