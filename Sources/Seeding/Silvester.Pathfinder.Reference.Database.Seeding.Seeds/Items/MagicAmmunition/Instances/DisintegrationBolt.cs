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
    public class DisintegrationBolt : Template
    {
        public static readonly Guid ID = Guid.Parse("b7a8fc36-2f4e-4416-a35b-ebe859f95f2e");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Disintegration Bolt",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c3faef7b-2784-4453-8220-3dc461173544"), "The shaft of this bolt is scorched and blackened, and handling it coats your fingers with a fine black powder. When an activated disintegration bolt hits a target, it is subject to a disintegrate spell requiring a DC 34 Fortitude save. As with the spell, a critical hit on the attack roll causes the target's saving throw outcome to be one degree worse.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("50253c3e-02d4-4ad5-ab6a-4d2b5aa23d5c"),
                Name = "Disintegration Bolt",
                CraftingRequirements = "Supply one casting of disintegrate.",
                Level = 15,
                Price = 130000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("91e46d2e-50a3-496e-9c2b-2fc7a5c62b40"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2df78d61-cb42-4be5-b326-11d3139c89bf"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("075be598-1738-4a10-9646-c15df35800de"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("7de57a7c-b514-403f-b2e8-ab156be0e8cb"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.Bolts.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d7dacf9-c241-42b1-aab4-63e39906046d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 559
            };
        }
    }
}
