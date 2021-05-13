using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Stats.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterials.Instances
{
    public class Orichalcum : Template
    {
        public static readonly Guid ID = Guid.Parse("949a7996-a817-48bf-b947-3646e248a25a");

        protected override PreciousMaterial GetMaterial()
        {
            return new PreciousMaterial
            {
                Id = ID,
                Name = "Orichalcum"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("335d178d-d113-456c-a618-f8dd8c50fe7f"), Type = TextBlockType.Text, Text = "The most rare and valuable skymetal, orichalcum is coveted for its incredible time-related magical properties. This dull, coppery metal isn’t as physically sturdy as adamantine, but orichalcum’s time-bending properties protect it, granting it greater Hardness and Hit Points. If an orichalcum item takes damage but isn’t destroyed, it repairs itself completely 24 hours later." };
        }

        protected override IEnumerable<PreciousMaterialItem> GetItems()
        {
            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("1aa57de0-59fb-4126-ace0-f4dc969c1da7"),
                Hardness = 16,
                HitPoints = 64,
                BrokenThreshold = 32,
                CategoryId = PreciousMaterialItemCategories.Instances.ThinItems.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("cf4aeb8d-0188-409b-83cc-6555205461d7"),
                Hardness = 18,
                HitPoints = 72,
                BrokenThreshold = 36,
                CategoryId = PreciousMaterialItemCategories.Instances.Items.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };

            yield return new PreciousMaterialItem
            {
                Id = Guid.Parse("f93d7557-ce24-4342-bc5d-cfcd2924f585"),
                Hardness = 35,
                HitPoints = 140,
                BrokenThreshold = 70,
                CategoryId = PreciousMaterialItemCategories.Instances.Structures.ID,
                GradeId = ItemGrades.Instances.HighGrade.ID,
            };
        }

        protected override IEnumerable<PreciousMaterialVariant> GetVariants()
        {
            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("31d18aeb-79bd-4991-99f8-dfc09ab52345"),
                Name = "Orichalcum Chunk",
                BulkId = Bulks.Instances.LightBulk.ID,
                ItemLevel = 0,
                Price = 100000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("fa9262de-46c8-44f1-981e-f8cb520f804d"),
                Name = "Orichalcum Ingot",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 0,
                Price = 1000000
            };

            yield return new PreciousMaterialVariant
            {
                Id = Guid.Parse("a9b6b5b7-7f44-4ad2-98b2-3da3f2b7e9cd"),
                Name = "Orichalcum Object",
                NameAddendum = "High Grade",
                BulkId = Bulks.Instances.OneBulk.ID,
                ItemLevel = 17,
                Price = 1000000
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
                Id = Guid.Parse("ca4df887-a752-4ced-a3b8-979e8c224943"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 579
            };
        }
    }
}
