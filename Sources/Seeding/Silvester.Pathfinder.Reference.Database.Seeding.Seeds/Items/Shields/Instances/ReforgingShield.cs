using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class ReforgingShield : Template
    {
        public static readonly Guid ID = Guid.Parse("81ede87c-4300-45c9-913d-c7c67217717e");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Reforging Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e3a4bd2c-90d0-49ea-aa97-105f33c95c30"), "This steel shield contains a smoldering core of magma that never cools. Whenever the reforging shield's current Hit Points are below its Break Threshold, the shield recovers 5 Hit Points at the start of its wielder's turn each round until it is no longer broken. Each time a character Repairs the shield, the shield recovers double the number of Hit Points. The shield has Hardness 15, HP 120, and BT 60.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("80d87cac-2541-4843-84c2-8b56e04e09ae"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("baf0a7e2-63db-4a1e-be9d-2b7fc1544bfe"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("de33e9bd-e1d9-4731-b58a-a2c4422ae19d"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("93b52b6a-c6be-43df-a243-dba8550e2fa5"),
                Name = "Reforging Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 15,
                BrokenThreshold = 60,
                Hardness = 15,
                HitPoints = 120,
                Price = 600000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b85db0b5-dbf0-4a0f-81a5-923210252dbf"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 76
            };
        }
    }
}
