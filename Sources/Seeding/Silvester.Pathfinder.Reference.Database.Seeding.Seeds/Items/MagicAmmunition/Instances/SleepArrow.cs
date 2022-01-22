using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MagicAmmunitions.Instances
{
    public class SleepArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("2fd43804-4bc4-4695-8d53-0d2acf429d66");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Sleep Arrow",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("01e04c3e-943e-4d1b-910a-f73155c6d104"), "Sleep arrows often have shafts of deep blue or black, and their fletching is exceptionally soft and downy. An activated sleep arrow deals no damage, but a living creature hit by it is subject to the effects of a sleep spell (DC 17).");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("91aa7d78-5594-4e83-87ce-955cb8bbf1aa"),
                Name = "Sleep Arrow",
                CraftingRequirements = "Supply one casting of sleep.",
                Level = 3,
                Price = 1100,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0da2a851-809a-4c9d-814d-448a1849013e"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5c10c14b-7a10-4b0d-a2d1-d25b48dc92d4"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("4e0729bb-d197-4c04-ad30-35b29229bae1"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("6550d623-2628-4bcd-8968-9359923578db"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("cd89afc5-be73-41f6-bd50-b8aa3b6d105c"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("0fe8a116-1918-4899-92a8-041a1fdffb8a"), Traits.Instances.Sleep.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.Arrows.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6988b664-ae33-4f16-8aca-9c40e01be899"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 560
            };
        }
    }
}
