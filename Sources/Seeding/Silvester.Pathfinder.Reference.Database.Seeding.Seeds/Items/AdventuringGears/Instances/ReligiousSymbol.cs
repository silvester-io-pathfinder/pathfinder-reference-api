using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class ReligiousSymbol : Template
    {
        public static readonly Guid ID = Guid.Parse("19f6384c-7ccb-48a7-ba5a-610a8477aeb2");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Religious Symbol",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("eb2f18d5-6185-4cc9-82c9-8d2b3b9bc3ed"), "This piece of wood or silver is emblazoned with an image representing a deity. Some divine spellcasters, such as clerics, can use a religious symbol of their deity as a divine focus to use certain abilities and cast some spells. A religious symbol must be held in one hand to use it.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3ef583de-ca10-46ae-b1b5-e2b11c34def9"),
                Name = "Religious Symbol (Wooden)",
                Hands = "1",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fb9a0eb4-e301-45ff-a99f-5b1d3f129fea"),
                Name = "Religious Symbol (Silver)",
                Hands = "1",
                Level = 0,
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4d2d39f-3945-47a2-b7c9-ebcd371cdf6f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
