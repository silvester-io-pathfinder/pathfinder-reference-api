using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems.Instances
{
    public class HornOfFog : Template
    {
        public static readonly Guid ID = Guid.Parse("5c51f43c-52c6-40e1-a037-1c5e3cc24d59");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Horn of Fog",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("948bb151-a04e-4d08-b854-7bc1f413fc6c"), "This large ram's horn perpetually glistens with tiny droplets of water, much like condensation.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("5e1b2af2-e9fc-49e4-987f-282216d5d79c"),
                Name = "Horn of Fog",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 23000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a241bc4c-ab5e-498f-afc2-9ae8210d67d1"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("f605bb69-aeae-4dd6-9a9c-3a61419c63a7"), "You activate the horn by blowing deeply into it, causing it to issue forth a low blast and cast a 2nd-level obscuring mist spell. You can Dismiss the mist at any time by blowing a second note on the horn using an Interact action.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7b56a59c-aec4-45b0-b114-f2f246b43453"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("155009f1-8d5f-42c2-87f0-f91d96e59678"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("381cde5e-f038-42f8-a657-edc169b5fc06"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccd887e2-a1b0-472b-88d3-c9795f3f100f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 573
            };
        }
    }
}
