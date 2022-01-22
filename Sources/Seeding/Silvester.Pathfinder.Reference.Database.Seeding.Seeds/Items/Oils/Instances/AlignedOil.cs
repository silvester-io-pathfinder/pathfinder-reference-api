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
    public class AlignedOil : Template
    {
        public static readonly Guid ID = Guid.Parse("a1c3f807-b390-4467-938b-776feef3c8af");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Aligned Oil",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5818b829-28fa-45c1-827a-c906858f0a9c"), "This oil fills a weapon with cosmic power of an alignment. Each aligned oil is crafted to one alignment: chaos, evil, good, or law (such as a good-aligned oil). A weapon anointed with this oil gains the effects of the property rune matching its alignment: anarchic (chaos), axiomatic (law), holy (good), or unholy (evil). This lasts for 1 minute.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("1c216ab5-010f-4295-a124-9836e192b9cb"),
                Name = "Aligned Oil",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 9,
                Price = 14000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("765412ff-27b0-4333-901f-f5fe60574b41"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b2ec58d9-9138-4c83-955a-a3a82c915ae7"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("9302ab6e-856b-40c0-ae81-02515e46e860"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("0c32d4ba-0733-4c33-a5ef-010c3da2d6b8"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("cce33c81-03bb-48db-b541-77986a1ed4c3"), Traits.Instances.Oil.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("166cb025-71a6-4da7-b35f-d3c054cbe067"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 561
            };
        }
    }
}
