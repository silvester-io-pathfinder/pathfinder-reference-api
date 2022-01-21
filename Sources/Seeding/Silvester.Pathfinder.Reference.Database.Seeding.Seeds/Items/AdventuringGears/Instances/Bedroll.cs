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
    public class Bedroll : Template
    {
        public static readonly Guid ID = Guid.Parse("2e760e65-7138-4baf-8b51-9d7d08d02195");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Bedroll",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d680c63c-d31e-4133-859e-7c464cb0fce9"), "This consists of two woolen sheets sewn together along the bottom and one side to create a bag for sleeping in. Some have cloth straps along the open side so the bedroll can be tied closed while you are sleeping. It can be rolled and tied into a tight coil for storage or transport. Most people use a blanket with the bedroll to stay warm or provide a ground cushion.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("7a3d3987-e617-4974-84bc-22af6c7ad54c"),
                Name = "Bedroll",
                Level = 0,
                Price = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c62c1853-80fb-4c06-ab1c-8ebd1fbe0930"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
