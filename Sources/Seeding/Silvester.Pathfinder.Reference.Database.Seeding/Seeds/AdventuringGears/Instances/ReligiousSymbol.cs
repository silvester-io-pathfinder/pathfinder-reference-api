using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "1",
                ItemLevel = 0,
                Price = 200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("eb2f18d5-6185-4cc9-82c9-8d2b3b9bc3ed"), Type = TextBlockType.Text, Text = "This piece of wood or silver is emblazoned with an image representing a deity. Some divine spellcasters, such as clerics, can use a religious symbol of their deity as a divine focus to use certain abilities and cast some spells. A religious symbol must be held in one hand to use it." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3ef583de-ca10-46ae-b1b5-e2b11c34def9"),
                NameAddendum = "Wooden",
                ItemLevel = 0,
                Price = 10,
                Hands = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fb9a0eb4-e301-45ff-a99f-5b1d3f129fea"),
                NameAddendum = "Silver",
                ItemLevel = 0,
                Price = 200,
                Hands = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4d2d39f-3945-47a2-b7c9-ebcd371cdf6f"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
