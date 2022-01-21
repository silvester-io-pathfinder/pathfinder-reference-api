using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Wheelbarrow : Template
    {
        public static readonly Guid ID = Guid.Parse("558eec23-35fc-495a-8506-4f7159303420");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Wheelbarrow",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4527bb4c-69b3-4c30-b035-1282a673fb8a"), "This small, hand-propelled vehicle has a single wheel and is designed to carry large loads over a distance. A wheelbarrow can typically hold up to 5 Bulk of objects without issue. The GM might rule that it can hold more Bulk of particular items, such as sand, or less Bulk of other items, like awkwardly shaped rocks.");;
            builder.Text(Guid.Parse("dd7ea85b-9ea1-4aa3-83ac-8d05b67c50af"), "You can raise or place a wheelbarrow using an Interact action and can Stride your normal Speed while you have the wheelbarrow raised, though you're encumbered while pushing a wheelbarrow. You can Release a wheelbarrow as normal, but a loaded wheelbarrow has a chance of tipping over if you don't place it down with care. When you Release a wheelbarrow, attempt a DC 7 flat check. On a failure, the wheelbarrow tips over, spilling its contents into a randomly determined adjacent space.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b857b9fd-fdc6-4b4e-83e7-471a00253833"),
                Name = "Wheelbarrow",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.FiveBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c364895-e81a-4551-ac6e-df1ac3d66f6f"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 93
            };
        }
    }
}
