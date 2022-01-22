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
    public class ObfuscationOil : Template
    {
        public static readonly Guid ID = Guid.Parse("fe0a4622-7fd8-44aa-8d27-da6ccadbcd82");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Obfuscation Oil",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ff255181-bb98-4e5d-a6c9-6ff1811f69e4"), "You can spread this blue-gray gel on a single item with a Bulk of 3 or less to ward it against magical detection. It becomes immune to divination magic of 8th level or lower (such as locate). This oil is permanent, but it can be removed with acid. Removing the oil in this way usually takes 1 minute for objects with Bulk of 1 or less, or a number of minutes equal to the item�s Bulk.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("09c287ba-d6e3-4bcd-b1d8-c3efa37fd4ec"),
                Name = "Obfuscation Oil",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 15,
                Price = 120000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4a8165fe-505d-4360-90e5-a67b9167134a"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f1e536c4-b2d6-4f59-9047-4e8d52c1ba7f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("1bf6b796-44f4-420c-b5ec-dd21cf067872"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("f1f17c7c-b2e6-46aa-ac42-b43fbb76f123"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("bdb1a54b-87b2-4a59-abaa-aa4feb3fd894"), Traits.Instances.Oil.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6e8346c-82f9-410e-9739-fd8d837c4bc9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 561
            };
        }
    }
}
