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
    public class SalveOfSlipperiness : Template
    {
        public static readonly Guid ID = Guid.Parse("e91321ad-7036-4b12-b768-bd6996104cfd");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Salve of Slipperiness",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("00a00658-24d8-455f-ba3c-15c40d1c6020"), "This greenish, persistent grease can be applied to armor to make it extremely slippery for 8 hours, granting the wearer a +2 item bonus to Acrobatics checks to Escape or to Squeeze.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("25284831-a9f3-464d-9197-d3c60ac4f519"),
                Name = "Salve of Slipperiness",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 5,
                Price = 2500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9d34c8a7-2835-428a-ba43-dc630f106d76"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("251a395e-db25-46cd-8403-3fc11182f55f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("bb3b20ab-76b1-4682-b889-0aa01d89bd27"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("05943ddb-3ef9-4a14-adb3-c2c770d026b5"), Traits.Instances.Oil.ID);
            builder.Add(Guid.Parse("cae3f0c7-f24c-42e8-88a7-9b54feea7fc9"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("273469be-0945-4f8c-8ba0-872b141210c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 562
            };
        }
    }
}
