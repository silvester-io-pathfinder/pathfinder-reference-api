using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MagicAmmunitions.Instances
{
    public class ClimbingBolt : Template
    {
        public static readonly Guid ID = Guid.Parse("77e28cb5-12ad-49fe-9ab6-f8faf4c1174f");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Climbing Bolt",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("18b4cf97-b49a-4aaa-bf3c-213c601f8ee6"), "The shaft of this bolt is wrapped with fine twine. When the bolt strikes a solid surface, the twine unwinds and enlarges into a 50-foot-long rope, securely fastened to the surface the bolt struck. The rope can be pulled free with an Interact action and a successful DC 20 Athletics check.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("b3efa6c7-6dd0-456a-95ac-3100c98ae120"),
                Name = "Climbing Bolt",
                Level = 4,
                Price = 1500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }
         
        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fb5d7416-44fb-43f4-a212-0b07097d344c"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("6952c63e-8a74-4c11-96de-fd2df37c202f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("a78e3bf9-1382-4dd5-b8b3-675d178adeb7"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.Bolts.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56f08363-6cfb-42f6-ba51-6b23da106bed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 559
            };
        }
    }
}
