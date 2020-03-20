using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VGR.Data.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_PowerUserId",
                table: "Reviews");

            migrationBuilder.AlterColumn<Guid>(
                name: "PowerUserId",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"), 0, "58ba9e42-a3f2-4fe6-97a1-ef2b0e84d620", "johnsmith@gmail.com", false, false, null, null, null, null, null, false, null, false, "johnny" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedOn", "GameName", "GamePublisher", "PowerUserId", "ReleaseYear", "ReviewText", "VideoReview" },
                values: new object[] { new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"), new DateTime(2020, 3, 20, 19, 11, 14, 615, DateTimeKind.Utc).AddTicks(6065), "Doom Eternal", "Bethesda Softworks", new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"), "2020", "I just finished Doom Eternal and I'm feeling anxious and exhausted. I've kneed the underside of my desk too many times to count from tensing up. My hands are soft from sweating and my knuckles crack when I try to make a fist. Doom Eternal is a celebration of excess. Excess in sin, in violence, scale, speed, and volume. I've never played a shooter this intense and demanding. Doom Eternal also runs beautifully on a wide range of hardware and feels designed for a mouse and keyboard first.It's a modern classic, with a few caveats. Cheap deaths from getting stuck on geometry happen too often. There are six or seven layers of unnecessary progression. Doom's dark humor has mostly been traded in for deep lore and a high - fantasy cosmology.And the strain from a heavy focus on resource management is felt at every difficulty level.I worry that for some, it could be Doom: But Too Much. But too much works for me as Eternal's guiding light. The moment to moment combat is distilled panic rather than empowerment. I live for the fleeting moments my head gets above water within the hurricane of light and noise and extravagant violence, and I pull off a feat of accuracy and reflex I never thought I was capable of before.", "https://www.youtube.com/watch?v=VFin3rU5uFQ" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedOn", "GameName", "GamePublisher", "PowerUserId", "ReleaseYear", "ReviewText", "VideoReview" },
                values: new object[] { new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"), new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(248), "Call of Duty: Warzone", "Activision", new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"), "2020", "The latest Call of Duty from Infinity Ward shipped without an answer to Black Ops 4’s Blackout, but it has since been supplemented by Warzone--a completely standalone battle royale built off of the backbone of Modern Warfare. Not only is it a smarter way to ensure it's not tied to each annual release in the series, but Warzone gives the series its own identity within the competitive genre. It might not be apparent at first, though, especially when you take into consideration how much Warzone borrows from other popular battle royale games. It incorporates a ping system similar to the one in Apex Legends, letting you tag enemy positions, points of interest, and loot for teammates at the press of a button (albeit mapped to a button that's harder to reach quickly, mitigating some of its convenience). It plays out on a massive map akin to PlayerUnknown's Battlegrounds, where large swathes of open land are ripe for snipers while dense suburbs make for exhilarating and chaotic close-quarters skirmishes. And like the ones in Fortnite, color-coded chests overflowing with loot are easy to hunt down when you are within earshot of their signature emanating jingle.", "https://www.youtube.com/watch?v=rH_KQ34QjMI" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedOn", "GameName", "GamePublisher", "PowerUserId", "ReleaseYear", "ReviewText", "VideoReview" },
                values: new object[] { new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"), new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(314), " Halo: The Master Chief Collection", "Xbox Game Studios", new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"), "2020", "Halo: Combat Evolved is on PC. Again. Unlike its original release back in 2003, this new release has the fancy campaign graphics of the 2011 Xbox Anniversary remake, along with multiplayer matchmaking and other perks of the Master Chief Collection, like being available on Steam. Developer 343 did a surprise launch today with no lead-up announcement, though there was a hint that Combat Evolved might be coming soon. This is the second game in the MCC to hit PC following Halo: Reach back in December. Three months, with a holiday break in the middle, feels like a speedy turnaround for a new PC port. The whole collection was in development throughout 2019, but it's encouraging that Halo: CE didn't need a ton of beta testing. 343 Industries ran a couple beta flights in January and February, and we'll have the full thing in our hands soon. On Steam, you can buy the whole Master Chief Collection for $40, or you can buy individual games for $10 apiece (assuming they all cost the same as Halo: Reach). This version of Halo: Combat Evolved has an unlocked framerate, FOV options, and supports high resolutions like 4K. The original PC version still has an active playerbase today thanks to a long-lived modding and mapmaking scene, which 343 called a community tradition in a recent blog post.", "https://www.youtube.com/watch?v=qmHPc_TL6bE" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentText", "CreatedOn", "EmailAddress", "ReviewId", "UserName" },
                values: new object[,]
                {
                    { new Guid("a969892f-f15a-41b3-86d8-382d142d8809"), "Steam says that it requires Bethesda account to play this game? Is this true? Do I need to create yet another useless account in order to play a game, or can I skip it and play without it?", new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(2115), "mark@yahoo.com", new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"), "mark" },
                    { new Guid("3be08a57-3e60-4243-9b2c-c0b846460187"), "Until I read this, I was completely comfortable waiting for a sale. I feel like punishing Bethesda for their shenanigans of the last couple of years. But then... I read a review that makes the game sound even better than Doom 2016 and I almost can't wait now. AND, I feel like it's important to reward bad companies when they do right by gamers.", new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5723), "yeppers@gmail.com", new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"), "yeppers" },
                    { new Guid("f1e738ad-766f-4d7b-9868-f83a45778e0a"), "I thought it was pretty fun. I much prefer Apex's movement and ping system, the one in CoD feels a little laggy. The respawning I think needs to be tweaked or limited further, there's no real penalty for death until the very end. I'm on the fence about the gas, it kills super quick which is both good and bad, really limits flanking tactics towards the end but it's nice to not worry about your back.", new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5781), "zeekez@mail.com", new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"), "zeekez" },
                    { new Guid("1d0b32b3-2ca4-478c-9022-4c5baa6ad0d5"), "This review has a mistake though and I don't understand why the hate against the killstreaks. The review says killstreaks are spammed in last circle but they are disabled already in last or before last circle. You can't use any of them anymore then at least not the airstrike and cluster strike. So I don't know why the review says you can do this and even says this as a negative when both are disabled for this very reason.", new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5783), "neonanderson@abv.bg", new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"), "NeonAnderson" },
                    { new Guid("0e56d020-3e23-4ab1-a75c-c4895bce32ec"), "I'll just pick up the whole pack at some point. I've never actually played any Halo game other than the first one, despite loving the Fall of Reach novel and lore. I'm looking forward to playing the whole franchise back to back.", new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5785), "brendissimo@gmail.com", new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"), "Brendissimo" },
                    { new Guid("3f4b5752-2a34-4f32-83bd-ecff75ae2347"), "I can't find anywhere if I can split screen coop with it. Really want to coop the campaign with a friend, that was my favorite part of playing it on the xbox.", new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(5787), "kirby@mail.bg", new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"), "Kirby_MegatonPunch" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_PowerUserId",
                table: "Reviews",
                column: "PowerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_PowerUserId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0e56d020-3e23-4ab1-a75c-c4895bce32ec"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1d0b32b3-2ca4-478c-9022-4c5baa6ad0d5"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("3be08a57-3e60-4243-9b2c-c0b846460187"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("3f4b5752-2a34-4f32-83bd-ecff75ae2347"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a969892f-f15a-41b3-86d8-382d142d8809"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f1e738ad-766f-4d7b-9868-f83a45778e0a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"));

            migrationBuilder.AlterColumn<Guid>(
                name: "PowerUserId",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_PowerUserId",
                table: "Reviews",
                column: "PowerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
