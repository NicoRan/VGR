﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VGR.Data.Context;

namespace VGR.Data.Migrations
{
    [DbContext(typeof(VGRDbContext))]
    [Migration("20200320191115_seeding")]
    partial class seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VGR.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a969892f-f15a-41b3-86d8-382d142d8809"),
                            CommentText = "Steam says that it requires Bethesda account to play this game? Is this true? Do I need to create yet another useless account in order to play a game, or can I skip it and play without it?",
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(2115),
                            EmailAddress = "mark@yahoo.com",
                            ReviewId = new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"),
                            UserName = "mark"
                        },
                        new
                        {
                            Id = new Guid("3be08a57-3e60-4243-9b2c-c0b846460187"),
                            CommentText = "Until I read this, I was completely comfortable waiting for a sale. I feel like punishing Bethesda for their shenanigans of the last couple of years. But then... I read a review that makes the game sound even better than Doom 2016 and I almost can't wait now. AND, I feel like it's important to reward bad companies when they do right by gamers.",
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5723),
                            EmailAddress = "yeppers@gmail.com",
                            ReviewId = new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"),
                            UserName = "yeppers"
                        },
                        new
                        {
                            Id = new Guid("f1e738ad-766f-4d7b-9868-f83a45778e0a"),
                            CommentText = "I thought it was pretty fun. I much prefer Apex's movement and ping system, the one in CoD feels a little laggy. The respawning I think needs to be tweaked or limited further, there's no real penalty for death until the very end. I'm on the fence about the gas, it kills super quick which is both good and bad, really limits flanking tactics towards the end but it's nice to not worry about your back.",
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5781),
                            EmailAddress = "zeekez@mail.com",
                            ReviewId = new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"),
                            UserName = "zeekez"
                        },
                        new
                        {
                            Id = new Guid("1d0b32b3-2ca4-478c-9022-4c5baa6ad0d5"),
                            CommentText = "This review has a mistake though and I don't understand why the hate against the killstreaks. The review says killstreaks are spammed in last circle but they are disabled already in last or before last circle. You can't use any of them anymore then at least not the airstrike and cluster strike. So I don't know why the review says you can do this and even says this as a negative when both are disabled for this very reason.",
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5783),
                            EmailAddress = "neonanderson@abv.bg",
                            ReviewId = new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"),
                            UserName = "NeonAnderson"
                        },
                        new
                        {
                            Id = new Guid("0e56d020-3e23-4ab1-a75c-c4895bce32ec"),
                            CommentText = "I'll just pick up the whole pack at some point. I've never actually played any Halo game other than the first one, despite loving the Fall of Reach novel and lore. I'm looking forward to playing the whole franchise back to back.",
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5785),
                            EmailAddress = "brendissimo@gmail.com",
                            ReviewId = new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"),
                            UserName = "Brendissimo"
                        },
                        new
                        {
                            Id = new Guid("3f4b5752-2a34-4f32-83bd-ecff75ae2347"),
                            CommentText = "I can't find anywhere if I can split screen coop with it. Really want to coop the campaign with a friend, that was my favorite part of playing it on the xbox.",
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5787),
                            EmailAddress = "kirby@mail.bg",
                            ReviewId = new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"),
                            UserName = "Kirby_MegatonPunch"
                        });
                });

            modelBuilder.Entity("VGR.Models.PowerUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "58ba9e42-a3f2-4fe6-97a1-ef2b0e84d620",
                            Email = "johnsmith@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "johnny"
                        });
                });

            modelBuilder.Entity("VGR.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GamePublisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PowerUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoReview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PowerUserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"),
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 615, DateTimeKind.Utc).AddTicks(6065),
                            GameName = "Doom Eternal",
                            GamePublisher = "Bethesda Softworks",
                            PowerUserId = new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"),
                            ReleaseYear = "2020",
                            ReviewText = "I just finished Doom Eternal and I'm feeling anxious and exhausted. I've kneed the underside of my desk too many times to count from tensing up. My hands are soft from sweating and my knuckles crack when I try to make a fist. Doom Eternal is a celebration of excess. Excess in sin, in violence, scale, speed, and volume. I've never played a shooter this intense and demanding. Doom Eternal also runs beautifully on a wide range of hardware and feels designed for a mouse and keyboard first.It's a modern classic, with a few caveats. Cheap deaths from getting stuck on geometry happen too often. There are six or seven layers of unnecessary progression. Doom's dark humor has mostly been traded in for deep lore and a high - fantasy cosmology.And the strain from a heavy focus on resource management is felt at every difficulty level.I worry that for some, it could be Doom: But Too Much. But too much works for me as Eternal's guiding light. The moment to moment combat is distilled panic rather than empowerment. I live for the fleeting moments my head gets above water within the hurricane of light and noise and extravagant violence, and I pull off a feat of accuracy and reflex I never thought I was capable of before.",
                            VideoReview = "https://www.youtube.com/watch?v=VFin3rU5uFQ"
                        },
                        new
                        {
                            Id = new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"),
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(248),
                            GameName = "Call of Duty: Warzone",
                            GamePublisher = "Activision",
                            PowerUserId = new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"),
                            ReleaseYear = "2020",
                            ReviewText = "The latest Call of Duty from Infinity Ward shipped without an answer to Black Ops 4’s Blackout, but it has since been supplemented by Warzone--a completely standalone battle royale built off of the backbone of Modern Warfare. Not only is it a smarter way to ensure it's not tied to each annual release in the series, but Warzone gives the series its own identity within the competitive genre. It might not be apparent at first, though, especially when you take into consideration how much Warzone borrows from other popular battle royale games. It incorporates a ping system similar to the one in Apex Legends, letting you tag enemy positions, points of interest, and loot for teammates at the press of a button (albeit mapped to a button that's harder to reach quickly, mitigating some of its convenience). It plays out on a massive map akin to PlayerUnknown's Battlegrounds, where large swathes of open land are ripe for snipers while dense suburbs make for exhilarating and chaotic close-quarters skirmishes. And like the ones in Fortnite, color-coded chests overflowing with loot are easy to hunt down when you are within earshot of their signature emanating jingle.",
                            VideoReview = "https://www.youtube.com/watch?v=rH_KQ34QjMI"
                        },
                        new
                        {
                            Id = new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"),
                            CreatedOn = new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(314),
                            GameName = " Halo: The Master Chief Collection",
                            GamePublisher = "Xbox Game Studios",
                            PowerUserId = new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"),
                            ReleaseYear = "2020",
                            ReviewText = "Halo: Combat Evolved is on PC. Again. Unlike its original release back in 2003, this new release has the fancy campaign graphics of the 2011 Xbox Anniversary remake, along with multiplayer matchmaking and other perks of the Master Chief Collection, like being available on Steam. Developer 343 did a surprise launch today with no lead-up announcement, though there was a hint that Combat Evolved might be coming soon. This is the second game in the MCC to hit PC following Halo: Reach back in December. Three months, with a holiday break in the middle, feels like a speedy turnaround for a new PC port. The whole collection was in development throughout 2019, but it's encouraging that Halo: CE didn't need a ton of beta testing. 343 Industries ran a couple beta flights in January and February, and we'll have the full thing in our hands soon. On Steam, you can buy the whole Master Chief Collection for $40, or you can buy individual games for $10 apiece (assuming they all cost the same as Halo: Reach). This version of Halo: Combat Evolved has an unlocked framerate, FOV options, and supports high resolutions like 4K. The original PC version still has an active playerbase today thanks to a long-lived modding and mapmaking scene, which 343 called a community tradition in a recent blog post.",
                            VideoReview = "https://www.youtube.com/watch?v=qmHPc_TL6bE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("VGR.Models.PowerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("VGR.Models.PowerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VGR.Models.PowerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("VGR.Models.PowerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VGR.Models.Comment", b =>
                {
                    b.HasOne("VGR.Models.Review", "Review")
                        .WithMany("Comments")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VGR.Models.Review", b =>
                {
                    b.HasOne("VGR.Models.PowerUser", "PowerUser")
                        .WithMany("Reviews")
                        .HasForeignKey("PowerUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}