using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class SovereignSteel : Template
    {
        public static readonly Guid ID = Guid.Parse("026b29b3-636f-4d3c-b8fb-7168090f3155");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Sovereign Steel"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b43177bf-d305-434a-bbcb-0ef6fc2e5bf8"), Type = TextBlockType.Text, Text = "Created by Black Sovereign Kevoth-Kul, this unique alloy of cold iron and the skymetal noqual can provide protection from magical assault. The process of cold-forging the two materials together is quite complicated and precise. Characters in search of sovereign steel weapons and armor will almost assuredly have to travel to Starfall to procure gear made from this rare alloy. While some believe it possible to craft shields of sovereign steel as well, in one of his fits, Kevoth-Kul yelled that he had no use for them and banned anyone from making such a thing. So far, his smiths have been too afraid to confirm whether or not it was a joke. All sovereign steel items (including weapon and armor below) have a +4 circumstance bonus on saves against magic that the item makes, and grant their bonus to saves the owner makes specifically to protect the item from magic (such as against the rusting grasp spell)." };
        }

        protected override IEnumerable<PreciousMaterialItem> GetItems()
        {
            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("a5beb3d5-8cba-4766-94ab-ceb2a3653394"),
                Hardness = 7,
                HitPoints = 28,
                BrokenThreshold = 14,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("52a40eef-6687-449c-bf27-9506b071ec83"),
                Hardness = 10,
                HitPoints = 40,
                BrokenThreshold = 20,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("40e7c28a-84bf-4785-a720-ed10505fde11"),
                Hardness = 11,
                HitPoints = 44,
                BrokenThreshold = 22,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("e93ab034-c640-40d6-96f8-ea8f1f083feb"),
                Hardness = 14,
                HitPoints = 56,
                BrokenThreshold = 28,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("6ca82cc1-ae59-466e-b3c2-0a2d6635e7ec"),
                Hardness = 22,
                HitPoints = 88,
                BrokenThreshold = 44,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.StandardGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("3e745203-bc40-431a-a1dd-a47df30d371b"),
                Hardness = 28,
                HitPoints = 112,
                BrokenThreshold = 56,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };
        }

        protected override IEnumerable<PreciousMaterialVariant> GetVariants()
        {
            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("6ec03653-f64d-4b18-8cc4-c83bcdbdebda"),
                Name = "Sovereign Steel Chunk",
                BulkId = Bulks.Instances.LightBulk.ID,
                ItemLevel = 0,
                Price = 70000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("a2888ed2-ec5c-4bfc-a606-85eaec351e8f"),
                Name = "Sovereign Steel Ingot",
                BulkId = Bulks.Instances.LightBulk.ID,
                ItemLevel = 0,
                Price = 700000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("81db1090-4b6a-46f0-b66e-ee03a8713344"),
                Name = "Sovereign Steel Object",
                NameAddendum = "Standard Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 9,
                Price = 50000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("050d3b7e-0c23-4976-a84d-629a8ff4f9f9"),
                Name = "Sovereign Steel Object",
                NameAddendum = "High Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 17,
                Price = 800000
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Precious.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d3dd22f-8299-4fe8-a03e-b9d130117699"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 77
            };
        }
    }
}
