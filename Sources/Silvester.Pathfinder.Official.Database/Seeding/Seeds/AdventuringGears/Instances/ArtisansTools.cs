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
    public class ArtisansTools : Template
    {
        public static readonly Guid ID = Guid.Parse("dea91016-311a-4e85-9672-aa9bc2b5da99");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Artisan's Tools",
                Hands = "0",
                ItemLevel = "0",
                Price = 400,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("342e6d20-16d7-46bd-ac63-8d4669d81aec"),
                NameAddendum = "Sterling",
                DescriptionAddendum = "Sterling artisan's tools give you a +1 item bonus to the check.",
                ItemLevel = 3,
                Price = 50,
                Hands = 2,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("89e2759c-4a2d-41aa-8bdb-d1bfe921a06e"), Type = TextBlockType.Text, Text = "You need these tools to create items from raw materials with the Craft skill. Different sets are needed for different work, as determined by the GM; for example, blacksmith's tools differ from woodworker's tools. If you wear your artisan's tools, you can draw and replace them as part of the action that uses them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8b6158c-86ae-4c20-94bc-b29b056974e2"),
                SourceId = CoreRulebook.ID,
                Page =  287
            };
        }
    }
}
