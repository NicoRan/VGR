using Microsoft.EntityFrameworkCore;
using System;
using VGR.Models;

namespace VGR.Data.Seeder
{
    public static class ModelBuilderExtensions
    {
        public static void Seeder(this ModelBuilder builder)
        {

            //SEEDING USER

            var user1 = new PowerUser
            {
                Id = Guid.Parse("8C09D76B-AE1E-48BA-8AF3-DFB85889053E"),
                UserName = "johnny",
                Email = "johnsmith@gmail.com"
            };

            builder.Entity<PowerUser>().HasData(user1);

            //SEEDING REVIEWS

            var review1 = new Review
            {
                Id = Guid.Parse("19FB565F-DF92-4F81-AC42-BC256D10469A"),
                CreatedOn = DateTime.UtcNow,
                GameName = "Doom Eternal",
                GamePublisher = "Bethesda Softworks",
                ReleaseYear = "2020",
                VideoReview = "https://www.youtube.com/embed/VFin3rU5uFQ",
                PowerUserId = user1.Id,
                ReviewText = "I just finished Doom Eternal and I'm feeling anxious and exhausted. I've kneed the underside of my desk too many times to count from tensing up. My hands are soft from sweating and my knuckles crack when I try to make a fist. Doom Eternal is a celebration of excess. Excess in sin, in violence, scale, speed, and volume. I've never played a shooter this intense and demanding. Doom Eternal also runs beautifully on a wide range of hardware and feels designed for a mouse and keyboard first.It's a modern classic, with a few caveats. Cheap deaths from getting stuck on geometry happen too often. There are six or seven layers of unnecessary progression. Doom's dark humor has mostly been traded in for deep lore and a high - fantasy cosmology.And the strain from a heavy focus on resource management is felt at every difficulty level.I worry that for some, it could be Doom: But Too Much. But too much works for me as Eternal's guiding light. The moment to moment combat is distilled panic rather than empowerment. I live for the fleeting moments my head gets above water within the hurricane of light and noise and extravagant violence, and I pull off a feat of accuracy and reflex I never thought I was capable of before."

            };

            var review2 = new Review
            {
                Id = Guid.Parse("49B52950-A806-4075-8260-9BA0BDC1AB06"),
                CreatedOn = DateTime.UtcNow,
                GameName = "Call of Duty: Warzone",
                GamePublisher = "Activision",
                ReleaseYear = "2020",
                PowerUserId = user1.Id,
                VideoReview = "https://www.youtube.com/embed/rH_KQ34QjMI",
                ReviewText = "The latest Call of Duty from Infinity Ward shipped without an answer to Black Ops 4’s Blackout, but it has since been supplemented by Warzone--a completely standalone battle royale built off of the backbone of Modern Warfare. Not only is it a smarter way to ensure it's not tied to each annual release in the series, but Warzone gives the series its own identity within the competitive genre. It might not be apparent at first, though, especially when you take into consideration how much Warzone borrows from other popular battle royale games. It incorporates a ping system similar to the one in Apex Legends, letting you tag enemy positions, points of interest, and loot for teammates at the press of a button (albeit mapped to a button that's harder to reach quickly, mitigating some of its convenience). It plays out on a massive map akin to PlayerUnknown's Battlegrounds, where large swathes of open land are ripe for snipers while dense suburbs make for exhilarating and chaotic close-quarters skirmishes. And like the ones in Fortnite, color-coded chests overflowing with loot are easy to hunt down when you are within earshot of their signature emanating jingle."
            };

            var review3 = new Review
            {
                Id = Guid.Parse("6C296D75-BCD2-4711-9A28-6D0B6BCAA34B"),
                CreatedOn = DateTime.UtcNow,
                GameName = " Halo: The Master Chief Collection",
                GamePublisher = "Xbox Game Studios",
                ReleaseYear = "2020",
                PowerUserId = user1.Id,
                VideoReview = "https://www.youtube.com/embed/qmHPc_TL6bE",
                ReviewText = "Halo: Combat Evolved is on PC. Again. Unlike its original release back in 2003, this new release has the fancy campaign graphics of the 2011 Xbox Anniversary remake, along with multiplayer matchmaking and other perks of the Master Chief Collection, like being available on Steam. Developer 343 did a surprise launch today with no lead-up announcement, though there was a hint that Combat Evolved might be coming soon. This is the second game in the MCC to hit PC following Halo: Reach back in December. Three months, with a holiday break in the middle, feels like a speedy turnaround for a new PC port. The whole collection was in development throughout 2019, but it's encouraging that Halo: CE didn't need a ton of beta testing. 343 Industries ran a couple beta flights in January and February, and we'll have the full thing in our hands soon. On Steam, you can buy the whole Master Chief Collection for $40, or you can buy individual games for $10 apiece (assuming they all cost the same as Halo: Reach). This version of Halo: Combat Evolved has an unlocked framerate, FOV options, and supports high resolutions like 4K. The original PC version still has an active playerbase today thanks to a long-lived modding and mapmaking scene, which 343 called a community tradition in a recent blog post."
            };

            builder.Entity<Review>().HasData(review1, review2, review3);

            //SEEDING COMMENTS

            var comment1 = new Comment
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
                EmailAddress = "mark@yahoo.com",
                UserName = "mark",
                ReviewId = review1.Id,
                CommentText = "Steam says that it requires Bethesda account to play this game? Is this true? Do I need to create yet another useless account in order to play a game, or can I skip it and play without it?"
            };

            var comment2 = new Comment
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
                EmailAddress = "yeppers@gmail.com",
                UserName = "yeppers",
                ReviewId = review1.Id,
                CommentText = "Until I read this, I was completely comfortable waiting for a sale. I feel like punishing Bethesda for their shenanigans of the last couple of years. But then... I read a review that makes the game sound even better than Doom 2016 and I almost can't wait now. AND, I feel like it's important to reward bad companies when they do right by gamers."
            };

            var comment3 = new Comment
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
                EmailAddress = "zeekez@mail.com",
                UserName = "zeekez",
                ReviewId = review2.Id,
                CommentText = "I thought it was pretty fun. I much prefer Apex's movement and ping system, the one in CoD feels a little laggy. The respawning I think needs to be tweaked or limited further, there's no real penalty for death until the very end. I'm on the fence about the gas, it kills super quick which is both good and bad, really limits flanking tactics towards the end but it's nice to not worry about your back."
            };

            var comment4 = new Comment
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
                EmailAddress = "neonanderson@abv.bg",
                UserName = "NeonAnderson",
                ReviewId = review2.Id,
                CommentText = "This review has a mistake though and I don't understand why the hate against the killstreaks. The review says killstreaks are spammed in last circle but they are disabled already in last or before last circle. You can't use any of them anymore then at least not the airstrike and cluster strike. So I don't know why the review says you can do this and even says this as a negative when both are disabled for this very reason."
            };

            var comment5 = new Comment
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
                EmailAddress = "brendissimo@gmail.com",
                UserName = "Brendissimo",
                ReviewId = review3.Id,
                CommentText = "I'll just pick up the whole pack at some point. I've never actually played any Halo game other than the first one, despite loving the Fall of Reach novel and lore. I'm looking forward to playing the whole franchise back to back."
            };

            var comment6 = new Comment
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.UtcNow,
                EmailAddress = "kirby@mail.bg",
                UserName = "Kirby_MegatonPunch",
                ReviewId = review3.Id,
                CommentText = "I can't find anywhere if I can split screen coop with it. Really want to coop the campaign with a friend, that was my favorite part of playing it on the xbox."
            };

            builder.Entity<Comment>().HasData(comment1, comment2, comment3, comment4, comment5, comment6);
        }
    }
}
