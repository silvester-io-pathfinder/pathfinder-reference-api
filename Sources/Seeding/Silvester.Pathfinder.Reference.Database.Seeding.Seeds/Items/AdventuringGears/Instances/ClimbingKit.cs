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
    public class ClimbingKit : Template
    {
        public static readonly Guid ID = Guid.Parse("517b246c-ab2a-495b-8702-62e266d2251b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Climbing Kit",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e81c9277-3a5f-4edf-b66e-a10171abc5ef"), "This satchel includes 50 feet of rope, pulleys, a dozen pitons, a hammer, a grappling hook, and one set of crampons. Climbing kits allow you to attach yourself to the wall you're Climbing, moving half as quickly as usual (minimum 5 feet) but letting you attempt a DC 5 flat check whenever you critically fail to prevent a fall. A single kit has only enough materials for one climber; each climber needs their own kit. If you wear your climbing kit, you can access it as part of a Climb action.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fd87e75f-0f39-4210-8608-72efa6184146"),
                Name = "Climbing Kit",
                Level = 0,
                Hands = "2",
                Price = 50,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b64044b3-3e0b-4f59-91e2-d6e5e70591f9"),
                Name = "Climbing Kit (Extreme)",
                Hands = "2",
                Level = 3,
                Price = 4000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                  .Text(Guid.Parse("05009862-4432-4fd6-bd4a-288e32dd3119"), "You gain a +1 item bonus to Athletics checks to Climb while using an extreme climbing kit.")
                  .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d6eed41-5de9-4166-bc48-7e39f56e176d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 287
            };
        }
    }
}
