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
    public class OilOfPotency : Template
    {
        public static readonly Guid ID = Guid.Parse("5438094f-d13d-4423-9f12-5f2b4ae21540");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Oil of Potency",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("dfd18daf-d9f6-4764-a0fa-20a3849f9e57"), "When you apply this thick, viscous oil to a non-magical weapon or suit of armor, that item immediately becomes magically potent. If the item is a weapon, it temporarily becomes a +1 striking weapon, or, if it's armor, it temporarily becomes +1 resilient armor. This lasts for 1 minute.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("a537c8e0-fbb3-4c07-8d73-c41435cb3e6d"),
                Name = "Oil of Potency",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 2,
                Price = 700,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a805a7d8-2078-4d96-93df-a61c97985f96"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("508990e4-8460-4c7e-815c-19761b8a4405"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("b7e738f8-2e76-4564-a631-9357b74f6c51"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("294f1632-8242-4d4e-a8e3-a24b3f6774b7"), Traits.Instances.Oil.ID);
            builder.Add(Guid.Parse("674c361c-a160-4ada-b842-19b2fd16d952"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d8e889e-7d32-4623-a65b-fd73816b87a8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 562
            };
        }
    }
}
