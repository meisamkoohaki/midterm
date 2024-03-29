﻿// <auto-generated />
using System;
using MT200412272.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MT200412272.Migrations
{
    [DbContext(typeof(MT200412272Context))]
    partial class MT200412272ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MT200412272.Models.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("comment")
                        .HasMaxLength(500);

                    b.Property<DateTime>("date");

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("Forum");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            comment = "It is a good webpage!",
                            date = new DateTime(2010, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            name = "Meisam"
                        },
                        new
                        {
                            Id = 2,
                            comment = "It is awsome!",
                            date = new DateTime(2010, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            name = "Koohaki"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
