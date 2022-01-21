using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class SturdyShield : Template
    {
        public static readonly Guid ID = Guid.Parse("a82655cc-188e-4ea5-a1a4-1b05c0956727");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Sturdy Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("50824849-9174-426f-9190-dabcc7b3c70b"), "With a superior design and excellent craftsmanship, this steel shield has higher Hardness than its non-magical counterparts, making it harder to break and destroy.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("62002716-409c-46b0-9af3-307b3404d5dd"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("9382c14f-26fb-4570-af72-1321a30b916d"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("d46dc19c-9d2e-4f8a-83c0-4e8a8f6db473"),
                Name = "Sturdy Shield (Minor)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 4,
                BrokenThreshold = 32,
                Hardness = 8,
                HitPoints = 64,
                Price = 10000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a7b47a60-dbd6-4f3d-a9a7-8fba71f29b13"), "The shield has Hardness 8, HP 64, and BT 32")
                    .Build()
            };

            yield return new ShieldVariant
            {
                Id = Guid.Parse("9ea59a3f-b32d-490c-870d-480dfd0422f9"),
                Name = "Sturdy Shield (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 7,
                BrokenThreshold = 40,
                Hardness = 10,
                HitPoints = 80,
                Price = 36000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("32ee8f8f-e3bd-473a-a639-d8952c614401"), "The shield has Hardness 10, HP 80, and BT 40")
                    .Build()
            };

            yield return new ShieldVariant
            {
                Id = Guid.Parse("20f1c61c-70e5-446f-bc90-b08d68d1d63c"),
                Name = "Sturdy Shield (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                BrokenThreshold = 52,
                Hardness = 13,
                HitPoints = 104,
                Price = 100000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ac7592fd-6d43-4f86-80e8-115b0bfd8a5b"), "The shield has Hardness 13, HP 104, and BT 52")
                    .Build()
            };

            yield return new ShieldVariant
            {
                Id = Guid.Parse("b3f16760-5396-43ff-888b-7346e5741603"),
                Name = "Sturdy Shield (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 13,
                BrokenThreshold = 60,
                Hardness = 15,
                HitPoints = 120,
                Price = 300000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2603c028-0ce9-4005-8e91-86512155b660"), "The shield has Hardness 15, HP 120, and BT 60")
                    .Build()
            };

            yield return new ShieldVariant
            {
                Id = Guid.Parse("32c461c8-23e4-4856-957c-a37975b23e71"),
                Name = "Sturdy Shield (Major)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 16,
                BrokenThreshold = 68,
                Hardness = 17,
                HitPoints = 138,
                Price = 1000000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1ebad17f-ea0a-4e15-9536-57a1c6d83c39"), "The shield has Hardness 17, HP 138, and BT 68")
                    .Build()
            };

            yield return new ShieldVariant
            {
                Id = Guid.Parse("70b8aad8-ec8d-4174-a3b4-a1b6bc248556"),
                Name = "Sturdy Shield (Supreme)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 19,
                BrokenThreshold = 80,
                Hardness = 20,
                HitPoints = 160,
                Price = 4000000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c8ec93c5-ee6c-4433-b8f2-09c8c3630825"), "The shield has Hardness 20, HP 160, and BT 80")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05368565-b914-4463-94e8-226c6b56a53f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 588
            };
        }
    }
}
