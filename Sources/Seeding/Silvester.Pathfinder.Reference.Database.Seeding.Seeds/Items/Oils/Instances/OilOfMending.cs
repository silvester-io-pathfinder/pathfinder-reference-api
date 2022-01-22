using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Oils.Instances
{
    public class OilOfMending : Template
    {
        public static readonly Guid ID = Guid.Parse("e5d21234-d147-4ade-bbd0-5308360e03aa");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Oil of Mending",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("98575c59-7bb7-4076-bf80-dc8668755f5e"), "A vial of oil of mending appears to have countless translucent threads swirling within. Applying this oil to an item casts a 2nd-level mending spell to repair the item.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("459d560b-996b-4a2b-ad94-56dcddd61780"),
                Name = "Oil of Mending",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 3,
                Price = 900,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bff673ae-550c-497f-aeb2-d3af284e195a"), ActionTypes.Instances.LongAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact (1 Minute)");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4982b082-3797-4546-a49c-ddf7fea2d222"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("a5445003-7beb-4abe-ae8d-e0f5be6ceb33"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("06441508-a64b-4e0b-b236-21fc642c5470"), Traits.Instances.Oil.ID);
            builder.Add(Guid.Parse("9f9aef0a-c32c-476d-8bb3-a4f2ecab846e"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cfc2fa6-17a3-439a-96e2-a12ca3657a6e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 56
            };
        }
    }
}
