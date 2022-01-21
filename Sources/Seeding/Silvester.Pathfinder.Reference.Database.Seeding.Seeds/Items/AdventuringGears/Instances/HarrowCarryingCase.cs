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
    public class HarrowCarryingCase : Template
    {
        public static readonly Guid ID = Guid.Parse("0f0bf997-7653-4941-af5f-375d4f5786a3");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Harrow Carrying Case",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4fd60da6-f092-412a-9481-c5583ba16d35"), "This elegant wooden case contains a recessed section to hold a simple or common harrow deck and a harrow mat. The case features a watertight seal to protect its contents from the elements and everyday wear and tear.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ac8c5e72-51c5-4d43-a75c-77125b7418ad"),
                Name = "Harrow Carrying Case",
                Hands = "1",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7ed5c0c-f9d3-4672-b084-b24ffea26ce1"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
