using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.PreciousMaterialItems.Instances
{
    public class Orichalcum : Template
    {
        public static readonly Guid ID = Guid.Parse("39e8c4f1-5f34-4398-b73a-e65f18f52bf8");

        protected override PreciousMaterialItem GetPreciousMaterialItem()
        {
            return new PreciousMaterialItem
            {
                Id = ID,
                Name = "Orichalcum",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("335d178d-d113-456c-a618-f8dd8c50fe7f"), "The most rare and valuable skymetal, orichalcum is coveted for its incredible time-related magical properties. This dull, coppery metal isn't as physically sturdy as adamantine, but orichalcum's time-bending properties protect it, granting it greater Hardness and Hit Points. If an orichalcum item takes damage but isn't destroyed, it repairs itself completely 24 hours later.");;
        }

        protected override IEnumerable<PreciousMaterialItemVariant> GetPreciousMaterialItemVariants()
        {
            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("31d18aeb-79bd-4991-99f8-dfc09ab52345"),
                Name = "Orichalcum Chunk",
                Level = 0,
                Price = 100000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("fa9262de-46c8-44f1-981e-f8cb520f804d"),
                Name = "Orichalcum Ingot",
                Level = 0,
                Price = 1000000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };

            yield return new PreciousMaterialItemVariant
            {
                Id = Guid.Parse("a9b6b5b7-7f44-4ad2-98b2-3da3f2b7e9cd"),
                Name = "Orichalcum Object (High Grade)",
                Level = 17,
                Price = 1000000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e63a5447-95f4-4cf9-b5f5-de6f1c3ef257"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("3055a838-d38f-44d5-86e7-88086e516496"), Traits.Instances.Precious.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4da215b2-f40c-407d-a519-6fd406cd27b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 579
            };
        }
    }
}
