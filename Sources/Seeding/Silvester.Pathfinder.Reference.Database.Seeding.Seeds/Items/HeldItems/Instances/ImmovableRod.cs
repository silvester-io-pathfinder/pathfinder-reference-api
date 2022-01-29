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
    public class ImmovableRod : Template
    {
        public static readonly Guid ID = Guid.Parse("261f6405-21d6-4b46-bbb0-9790425d1f51");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Immovable Rod",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f6695993-0560-4442-a41c-a71f44ef42e2"), "This flat iron bar is almost completely nondescript, except for one small button appearing on its surface.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("17b0483c-5896-4917-b098-f3040651fe2d"),
                Name = "Immovable Rod",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                Price = 60000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("301315d4-cf5b-4364-a2bc-18b512c8a04d"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("ef0d792c-e6fd-41f8-aaeb-ffd4adb3d1e2"), "You push the button to anchor the rod in place. It doesn't move, defying gravity if need be. If the button is pushed again, the rod deactivates, ending the anchoring magic. While anchored, the rod can be moved only if 8,000 pounds of pressure are applied to it or if a creature uses Athletics to Force Open the rod with a DC of 40 (though most intelligent creatures can just push the button to release the rod).");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d2ca008e-f877-4dc3-b256-27950abf4831"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95cf87f8-ffd1-47a4-88a2-e7ecb728e875"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 574
            };
        }
    }
}
