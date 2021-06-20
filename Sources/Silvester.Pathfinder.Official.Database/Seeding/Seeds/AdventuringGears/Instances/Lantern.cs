using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Lantern : Template
    {
        public static readonly Guid ID = Guid.Parse("6c60bda0-dcce-4507-980b-370cb919c9ed");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Lantern",
                Hands = "1",
                Price = 70,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a33954b8-34d4-47bc-8a43-d7999bf649fa"),
                NameAddendum = "Hooded",
                DescriptionAddendum = "A hooded lantern sheds light in a 30-foot radius (and dim light in the next 30 feet) and is equipped with shutters, which you can close to block the light. Closing or opening the shutters takes an Interact action.",
                ItemLevel = 0,
                Price = 70,
                Hands = 1,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5ae2a0fc-0840-44a9-a9af-044ab1412416"),
                NameAddendum = "Bull's Eye",
                DescriptionAddendum = "A bull’s-eye lantern emits its light in a 60-foot cone (and dim light in the next 60 feet).",
                ItemLevel = 0,
                Price = 100,
                Hands = 1,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("74e5c5e5-3303-4bb6-a982-281e89cd6149"), Type = TextBlockType.Text, Text = "A lantern sheds bright light and requires 1 pint of oil to function for 6 hours." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cb4bae4-fcb4-49d8-b285-31bf3f49bd1e"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
