using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Bandalore : Template
    {
        public static readonly Guid ID = Guid.Parse("51fb5299-9995-4a04-81a5-9f3f908700a5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Bandalore",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3088ec34-0c60-433e-8ffa-1a1772c7ef1d"), "Similar to a spool of string, a bandalore consists of two wooden disks connected to a central axle wound with string. By holding the end of the string and releasing the bandalore, a skilled user can move the bandalore up and down, performing a variety of tricks.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("67dda5a2-2e40-44f1-8c49-73e47c74372f"),
                Name = "Bandalore",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 5,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2faf0409-ae85-49f7-a306-6ed48f69c297"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 58
            };
        }
    }
}
