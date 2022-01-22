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
    public class PotionOfLeaping : Template
    {
        public static readonly Guid ID = Guid.Parse("67766328-21e7-47cc-aff6-242bb5926782");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Potion of Leaping",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1942e1f8-7acf-42dc-9591-0246310e67bc"), "For 1 minute after you drink this fizzy potion, whenever you Leap, you gain the effect of the 1st-level jump spell");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("bc79febd-5f86-4a97-838d-bcf510ced83e"),
                Name = "Potion of Leaping",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 5,
                Price = 2100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("423209b3-042c-4074-8ae7-34ee9df944a7"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("21286ce0-0e09-4934-bc23-be8d5915b7f4"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("b2071a48-7e95-4c42-ab24-42289b8001eb"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("20da3d64-4840-4c33-862d-10e91094d6b1"), Traits.Instances.Potion.ID);
            builder.Add(Guid.Parse("0f57c2bf-3938-4d33-8039-b7f605647d84"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7fa27d26-120e-400d-8e97-a7452d71bffc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
