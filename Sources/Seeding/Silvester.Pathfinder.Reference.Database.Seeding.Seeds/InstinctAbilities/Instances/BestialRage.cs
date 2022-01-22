using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InstinctAbilities.Instances
{
    public class BestialRage : Template
    {
        public static readonly Guid ID = Guid.Parse("a731cc55-2763-42d5-8f74-08da2075736a");
        
        protected override InstinctAbility GetInstinctAbility()
        {
            return new InstinctAbility
            {
                Id = ID, 
                Name = "Bestial Rage",
                Description = "When you Rage, you gain your chosen animal's unarmed attack (or attacks). The specific attack gained, the damage it deals, and its traits are listed in the table Animal Instincts. These attacks are in the brawling group. Your Rage action gains the morph, primal, and transmutation traits.",
            };
        }

        protected override Table? GetTable()
        {
            return new TableBuilder("64516cdd-9224-4a60-a924-4c4870d0357f")
                .AddColumn("98131dee-5407-478c-b4c4-8aea6aede2d0", "Animal")
                .AddColumn("a479c7c7-4733-404a-a5f8-86fca9d395ae", "Attack")
                .AddColumn("1bf21bd2-d2d2-4781-869d-dba8ed657135", "Damage")
                .AddColumn("a9307cc5-a8c3-4649-92e0-053d46885d34", "Traits")
                .AddRow("817db501-ecae-4d63-a33b-ed12b67c8e63", row =>
                {
                    row
                        .AddCell("72368490-4105-4819-a9f8-04aee89905f1", "Ape")
                        .AddCell("e6493e8a-ba32-4bb8-bdcd-9fa88dc6c632", "Fist")
                        .AddCell("5c6eea7b-176d-48b3-83e5-657bbcde20f8", "1d10 B")
                        .AddCell("db1c56ed-87a9-43f4-beaf-69e55b267458", "Grapple, Unarmed");
                })
                .AddRow("9960ef7b-4a24-4126-9551-56ec9ab00cdf", row =>
                {
                    row
                        .AddCell("99305c91-23a2-4fa2-a1df-393a9b8212aa", "Bear")
                        .AddCell("4ddd752e-1c79-46ee-8b69-ac8e3a062c39", "Jaws")
                        .AddCell("2d0f2eaa-ec3a-49f5-b5db-853682f93bd9", "1d10 P")
                        .AddCell("9d2372d5-cf12-4e10-b920-080375491aad", "Unarmed");
                })
                .AddRow("52d4c3d0-3ce4-4cdd-b3f3-89b1a45e2ad2", row =>
                {
                    row
                        .AddCell("33efdbdd-ee81-4145-b7e2-1c1906d093e6", "Bear")
                        .AddCell("5d95485c-7ddd-4357-9b66-653c8f8ec63c", "Claw")
                        .AddCell("1064ab84-855d-43db-92b9-610d2fd9b153", "1d6 S")
                        .AddCell("58fdf0c4-938a-4616-8eec-2d7e7e86416a", "Agile, Unarmed");
                })
                .AddRow("48b3e913-6665-4aa0-b962-80cc57634396", row =>
                {
                    row
                        .AddCell("223babf9-0b58-4561-8060-51d3340539e4", "Bull")
                        .AddCell("40899ab6-7330-4039-80be-2c1f1e6d7eb2", "Horn")
                        .AddCell("a72617e7-49d0-44f0-8e6a-b8bed675ae77", "1d10 P")
                        .AddCell("632d0c40-d0bb-4a2c-8b42-791f05ea648a", "Shove, Unarmed");
                })
                .AddRow("0eed2bf9-dda0-4921-ac5c-b549fa61fbbf", row =>
                {
                    row
                        .AddCell("ee554968-e5fd-460d-a289-8c2e67a91e27", "Cat")
                        .AddCell("ca2216d5-a81f-490d-9299-cdf167235c8a", "Jaws")
                        .AddCell("c7633387-1dfe-4dad-814f-c4a5f2e3a3c6", "1d10 P")
                        .AddCell("2401c6da-2b8f-43b6-abff-cb915197a254", "Unarmed");
                })
                .AddRow("f5cdee74-c03e-4ceb-942c-b2f4d3392dfe", row =>
                {
                    row
                        .AddCell("8fcdeb42-9d6d-4dd3-94e9-fb38ac27529b", "Cat")
                        .AddCell("451519ca-0f07-4242-a4b3-2041444171a8", "Claw")
                        .AddCell("e7cb7bcb-15d5-4bb1-9910-ca9740691f94", "1d6 S")
                        .AddCell("872b73b0-8c91-4e6e-aa6e-8af5033f888c", "Agile, Unarmed");
                })
                .AddRow("0be6959a-3a16-4c48-9a22-da39ebb340a5", row =>
                {
                    row
                        .AddCell("d5352165-165c-43b3-8430-f538bbe774b8", "Deer")
                        .AddCell("213b5da7-371b-46e5-872d-8224d9a6f139", "Antler")
                        .AddCell("5747a85f-5161-4368-b679-5a45529c53b4", "1d10 P")
                        .AddCell("6eae0639-9f53-4563-a519-55be7733bcc2", "Grapple, Unarmed");
                })
                .AddRow("830f801c-8cc0-466f-89ea-4565241073ce", row =>
                {
                    row
                        .AddCell("a3d3884d-e041-4701-a875-7c0482e31f73", "Frog")
                        .AddCell("a062c326-54b3-42fa-bd58-ea3eac35e7c4", "Jaws")
                        .AddCell("67474f7c-511d-476f-a4f0-37413d2158b0", "1d10 B")
                        .AddCell("2c8887fb-5631-4b8f-862a-331fa4d1dc51", "Unarmed");
                })
                .AddRow("42472eea-aed1-4ebd-92f3-6886b5cc3707", row =>
                {
                    row
                        .AddCell("e9f29d2a-2f8a-4ce2-843d-e51247267488", "Frog")
                        .AddCell("0ac6c3e5-f55b-4e4b-8971-ec13edbd0dfd", "Tongue")
                        .AddCell("d4230e3d-0a02-4c46-8932-2473817f31f7", "1d10 B")
                        .AddCell("4a3c73b8-9223-4308-ba2a-6572e6ec33a7", "Agile, Unarmed");
                })
                .AddRow("d0697901-2e1a-4f03-bbcb-a56e8a7355bb", row =>
                {
                    row
                        .AddCell("2878764f-b0ad-411d-80ea-ccfd11ef8baa", "Shark")
                        .AddCell("9b1b472b-47fd-445d-b048-4e909b2ce5dc", "Jaws")
                        .AddCell("bbfc1c0f-1d86-4541-9269-a0ab3b7f67a5", "1d10 P")
                        .AddCell("e281ac13-d579-47c2-b77c-28d731a41240", "Grapple, Unarmed");
                })
                .AddRow("24d5cda5-7d53-48b4-b58d-c2823d3ecef0", row =>
                {
                    row
                        .AddCell("2b42f093-6058-4c7e-9e2c-646d7ca0bf19", "Snake")
                        .AddCell("cfaa45bd-db11-473d-91a6-d046218b1c1c", "Jaws")
                        .AddCell("01854949-c4f3-4793-a525-4b8b802e93c3", "1d10 P")
                        .AddCell("f008e3a1-cd6f-405a-8bed-e2a1f2e4613a", "Grapple, Unarmed");
                })
                .AddRow("8ca6f878-4f21-4a37-a322-277803cdaf77", row =>
                {
                    row
                        .AddCell("09a8eabb-b373-4050-b5d0-230ecb936487", "Wolf")
                        .AddCell("e6b4581d-407b-483b-9a1f-11dd9544eb99", "Jaws")
                        .AddCell("b2763ae4-b39d-400d-9d4a-30e7de53566a", "1d10 P")
                        .AddCell("f0d24da9-6a81-410f-94e5-acd3ab428df9", "Trip, Unarmed");
                })
                .Build();
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2b1f4b2-96d2-4a64-83ac-b8e49e44489d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
