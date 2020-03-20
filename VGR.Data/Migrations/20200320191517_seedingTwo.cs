using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VGR.Data.Migrations
{
    public partial class seedingTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"),
                column: "ConcurrencyStamp",
                value: "7220c3ce-360d-47ff-a91c-6d43398b03cb");

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentText", "CreatedOn", "EmailAddress", "ReviewId", "UserName" },
                values: new object[,]
                {
                    { new Guid("838bb772-b227-466e-8cb3-92d17b7f5919"), "Steam says that it requires Bethesda account to play this game? Is this true? Do I need to create yet another useless account in order to play a game, or can I skip it and play without it?", new DateTime(2020, 3, 20, 19, 15, 17, 196, DateTimeKind.Utc).AddTicks(5609), "mark@yahoo.com", new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"), "mark" },
                    { new Guid("1d9515f5-7bc7-4284-a4b4-4c9dda6397fa"), "Until I read this, I was completely comfortable waiting for a sale. I feel like punishing Bethesda for their shenanigans of the last couple of years. But then... I read a review that makes the game sound even better than Doom 2016 and I almost can't wait now. AND, I feel like it's important to reward bad companies when they do right by gamers.", new DateTime(2020, 3, 20, 19, 15, 17, 196, DateTimeKind.Utc).AddTicks(8988), "yeppers@gmail.com", new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"), "yeppers" },
                    { new Guid("502d7c4e-ab79-4ac2-b3d4-de7ea12acf38"), "I thought it was pretty fun. I much prefer Apex's movement and ping system, the one in CoD feels a little laggy. The respawning I think needs to be tweaked or limited further, there's no real penalty for death until the very end. I'm on the fence about the gas, it kills super quick which is both good and bad, really limits flanking tactics towards the end but it's nice to not worry about your back.", new DateTime(2020, 3, 20, 19, 15, 17, 196, DateTimeKind.Utc).AddTicks(9053), "zeekez@mail.com", new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"), "zeekez" },
                    { new Guid("0feeac7e-6d59-4342-b5ee-71349fef76d1"), "This review has a mistake though and I don't understand why the hate against the killstreaks. The review says killstreaks are spammed in last circle but they are disabled already in last or before last circle. You can't use any of them anymore then at least not the airstrike and cluster strike. So I don't know why the review says you can do this and even says this as a negative when both are disabled for this very reason.", new DateTime(2020, 3, 20, 19, 15, 17, 196, DateTimeKind.Utc).AddTicks(9057), "neonanderson@abv.bg", new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"), "NeonAnderson" },
                    { new Guid("0a98e203-c211-4bd8-a364-d09d9a2ba312"), "I'll just pick up the whole pack at some point. I've never actually played any Halo game other than the first one, despite loving the Fall of Reach novel and lore. I'm looking forward to playing the whole franchise back to back.", new DateTime(2020, 3, 20, 19, 15, 17, 196, DateTimeKind.Utc).AddTicks(9076), "brendissimo@gmail.com", new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"), "Brendissimo" },
                    { new Guid("c7a5a9da-047c-47ec-aae9-8e93dd704888"), "I can't find anywhere if I can split screen coop with it. Really want to coop the campaign with a friend, that was my favorite part of playing it on the xbox.", new DateTime(2020, 3, 20, 19, 15, 17, 196, DateTimeKind.Utc).AddTicks(9080), "kirby@mail.bg", new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"), "Kirby_MegatonPunch" }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"),
                columns: new[] { "CreatedOn", "VideoReview" },
                values: new object[] { new DateTime(2020, 3, 20, 19, 15, 17, 195, DateTimeKind.Utc).AddTicks(9692), "https://www.youtube.com/embed/VFin3rU5uFQ" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"),
                columns: new[] { "CreatedOn", "VideoReview" },
                values: new object[] { new DateTime(2020, 3, 20, 19, 15, 17, 196, DateTimeKind.Utc).AddTicks(3959), "https://www.youtube.com/embed/rH_KQ34QjMI" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"),
                columns: new[] { "CreatedOn", "VideoReview" },
                values: new object[] { new DateTime(2020, 3, 20, 19, 15, 17, 196, DateTimeKind.Utc).AddTicks(4033), "https://www.youtube.com/embed/qmHPc_TL6bE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0a98e203-c211-4bd8-a364-d09d9a2ba312"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0feeac7e-6d59-4342-b5ee-71349fef76d1"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1d9515f5-7bc7-4284-a4b4-4c9dda6397fa"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("502d7c4e-ab79-4ac2-b3d4-de7ea12acf38"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("838bb772-b227-466e-8cb3-92d17b7f5919"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c7a5a9da-047c-47ec-aae9-8e93dd704888"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8c09d76b-ae1e-48ba-8af3-dfb85889053e"),
                column: "ConcurrencyStamp",
                value: "58ba9e42-a3f2-4fe6-97a1-ef2b0e84d620");

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

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("19fb565f-df92-4f81-ac42-bc256d10469a"),
                columns: new[] { "CreatedOn", "VideoReview" },
                values: new object[] { new DateTime(2020, 3, 20, 19, 11, 14, 615, DateTimeKind.Utc).AddTicks(6065), "https://www.youtube.com/watch?v=VFin3rU5uFQ" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("49b52950-a806-4075-8260-9ba0bdc1ab06"),
                columns: new[] { "CreatedOn", "VideoReview" },
                values: new object[] { new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(248), "https://www.youtube.com/watch?v=rH_KQ34QjMI" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6c296d75-bcd2-4711-9a28-6d0b6bcaa34b"),
                columns: new[] { "CreatedOn", "VideoReview" },
                values: new object[] { new DateTime(2020, 3, 20, 19, 11, 14, 616, DateTimeKind.Utc).AddTicks(314), "https://www.youtube.com/watch?v=qmHPc_TL6bE" });
        }
    }
}
