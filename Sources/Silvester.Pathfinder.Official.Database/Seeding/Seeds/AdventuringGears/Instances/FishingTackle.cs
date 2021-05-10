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
    public class FishingTackle : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("48f8e6d1-38dd-4ae7-966b-d85778977991");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Fishing Tackle",
                Hands = "2",
                ItemLevel = "0",
                Price = 80,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("d542a4a9-c904-4f82-a535-381329b4378d"),
                NameAddendum = "Professional",
                DescriptionAddendum = "Professional fishing tackle grants a +1 item bonus to checks to fish.",
                ItemLevel = 3,
                Price = 2000,
                Hands = 2,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f46a0e3c-1746-40bc-8f13-fd6c86e3bd18"), Type = TextBlockType.Text, Text = "This kit include a collapsible fishing pole, fishhooks, line, lures, and a fishing net." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f62d0ad-0edc-4537-97d7-517bae0d0072"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
