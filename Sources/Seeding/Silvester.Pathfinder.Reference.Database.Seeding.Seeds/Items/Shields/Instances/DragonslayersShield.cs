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
    public class DragonslayersShield : Template
    {
        public static readonly Guid ID = Guid.Parse("5c50182f-66d3-482d-b924-5c949d068b55");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Dragonslayer's Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cce62121-4daf-4edf-85b6-ff27522639e4"), "A dragonslayer�s shield is a steel shield covered with dragonhide from a certain type of dragon, which distinguishes each shield from the others. While raised, this steel shield (Hardness 8, HP 32, BT 16) grants its circumstance bonus to Reflex saves against area effects (as well as to AC, as normal).");
            builder.Text(Guid.Parse("0381fad0-efdb-44c3-950c-32b24eeb803d"), "While you hold the shield, it also grants you a +2 circumstance bonus to Will saves against a dragon�s frightful presence ability. The shield has resistance 10 against the damage type corresponding to the type of dragon whose hide was used in its creation (see dragonhide on page 579); this applies after reducing the damage for Hardness, so when you use Shield Block, the dragonslayer�s shield takes 18 less damage from attacks of that damage type. You can use Shield Block against attacks that deal damage of that type.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a7fc6167-28a5-4e8f-833e-05118b8d34f3"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f589840b-4c21-484a-a5f9-a076b6d6c1d8"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("6df1f11b-0702-4bc5-ba03-36d02652b2c4"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("cc00ae3d-aa54-4b81-9231-f97e8059941c"),
                Name = "Dragonslayer's Shield",
                CraftingRequirements = "The initial raw materials must include at least 30 gp of dragonhide.",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                BrokenThreshold = 16,
                Hardness = 8,
                HitPoints = 32,
                Price = 67000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe5d03f7-2415-46a7-b21f-7f7ae892c6b2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 587
            };
        }
    }
}
