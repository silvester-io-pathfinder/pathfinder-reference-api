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
    public class HollyAndMistletoe : Template
    {
        public static readonly Guid ID = Guid.Parse("ba1e620a-1e7f-49c8-904d-52ed144470f8");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Holly and Mistletoe",
                
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7b3f776e-63f5-412d-83c0-33b11f2c35c6"), "Plants of supernatural significance provide a primal focus for primal spellcasters, such as druids, when using certain abilities and casting some spells. A bundle of holly and mistletoe must be held in one hand to use it. Other primal foci exist for druids focused on other aspects of nature.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c93d6820-2ab3-490c-82ea-23521778d89e"),
                Name = "Holly and Mistletoe",
                Hands = "1",
                Level = 0,
                Price = 0,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48037943-1577-48cb-827e-bce1ab507149"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
