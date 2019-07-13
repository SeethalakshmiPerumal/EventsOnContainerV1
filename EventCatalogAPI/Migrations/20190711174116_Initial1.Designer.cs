﻿// <auto-generated />
using EventCatalogAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventCatalogAPI.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20190711174116_Initial1")]
    partial class Initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.event_category_hilo", "'event_category_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_hilo", "'event_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_location_hilo", "'event_location_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.event_state_hilo", "'event_state_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventCatalogAPI.Domain.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_category_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Event Categories");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("EventCategoryId");

                    b.Property<string>("EventDateTime")
                        .IsRequired();

                    b.Property<int>("EventLocationId");

                    b.Property<int>("EventStateId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("EventCategoryId");

                    b.HasIndex("EventLocationId");

                    b.HasIndex("EventStateId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_location_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Event Locations");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "event_state_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Event States");
                });

            modelBuilder.Entity("EventCatalogAPI.Domain.EventItem", b =>
                {
                    b.HasOne("EventCatalogAPI.Domain.EventCategory", "EventCategory")
                        .WithMany()
                        .HasForeignKey("EventCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventCatalogAPI.Domain.EventLocation", "EventLocation")
                        .WithMany()
                        .HasForeignKey("EventLocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventCatalogAPI.Domain.EventState", "EventState")
                        .WithMany()
                        .HasForeignKey("EventStateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
