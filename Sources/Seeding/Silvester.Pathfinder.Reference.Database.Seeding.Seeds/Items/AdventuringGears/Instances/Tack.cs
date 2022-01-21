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
    public class Tack : Template
    {
        public static readonly Guid ID = Guid.Parse("ef7d64e3-04b3-4af5-9c92-47885fc41838");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Tack",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b136ce98-72fc-4270-a6e8-55a8f4fe90e8"), "Tack includes all the gear required to outfit a riding animal, including a saddle, bit and bridle, and stirrups if necessary. Especially large or oddly shaped animals might require specialty saddles. These can be more expensive or hard to find, as determined by the GM. The Bulk value given is for tack worn by a creature. If carried, the Bulk increases to 2.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3d24a222-654f-4edd-a0f5-c5a2fbcf0594"),
                Name = "Tack",
                Price = 400,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c3f6602-bc8e-4e39-ac83-df1a85eb1af8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
