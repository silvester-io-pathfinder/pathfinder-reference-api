using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
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
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("89e2759c-4a2d-41aa-8bdb-d1bfe921a06e"), "You need these tools to create items from raw materials with the Craft skill. Different sets are needed for different work, as determined by the GM; for example, blacksmith's tools differ from woodworker's tools. If you wear your artisan's tools, you can draw and replace them as part of the action that uses them.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("974370d7-6d61-425b-b1e4-7f9ae7d515f7"),
                Name = "Artisan's Tools",
                Level = 0,
                Hands = "2", 
                Price = 400,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("49550bef-0174-48f3-a399-d132552bfbc1"),
                Name = "Artisan's Tools (Sterling)",
                Level = 3,
                Hands = "2", 
                Price = 5000,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                  .Text(Guid.Parse("e7c82114-6b6b-4ad1-bcff-6321b77a9f07"), "Sterling artisan's tools give you a +1 item bonus to the check.")
                  .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8b6158c-86ae-4c20-94bc-b29b056974e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page =  287
            };
        }
    }
}
