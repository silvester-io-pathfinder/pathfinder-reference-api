using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Potions.Instances
{
    public class BarkskinPotion : Template
    {
        public static readonly Guid ID = Guid.Parse("a3ef687e-87b2-41ad-8488-341d05040b23");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Barkskin Potion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e131cb5a-e534-4c61-bd2a-314a8c0ef268"), "After you drink this bitter draft, your skin thickens like bark. You gain the effects of a 2nd-level barkskin spell for 10 minutes.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("9d38193d-37eb-4d53-a66b-e23ce1568e5f"),
                Name = "Barkskin Potion",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 4,
                Price = 1500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("33de2995-c55c-4a97-bdff-77564922b3b5"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("366361aa-f0a3-4144-a002-99d7ea3ea6af"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("6439fa89-fa74-40fe-823c-56eeadde5593"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("fe11c9ed-897c-4e71-aaa3-ae6a39d50185"), Traits.Instances.Potion.ID);
            builder.Add(Guid.Parse("53ab7d6b-2d81-4f19-8934-de100a819cd2"), Traits.Instances.Primal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("925a71d8-4a96-4927-96da-ca43c28e74fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 562
            };
        }
    }
}
