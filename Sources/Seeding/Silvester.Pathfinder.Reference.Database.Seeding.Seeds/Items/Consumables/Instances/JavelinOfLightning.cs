using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Consumables.Instances
{
    public class XXTemplate : Template
    {
        public static readonly Guid ID = Guid.Parse("af05f559-1a85-41e5-b01b-7155088b57d0");

        protected override Consumable GetConsumable()
        {
            return new Consumable
            {
                Id = ID,
                Name = "Javelin of Lightning",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("505af2e3-dce3-485a-b39f-b85431cfecc8"), "This item looks like a normal javelin carved with lightning-bolt motifs. If thrown without being activated, it wobbles in the air and fails to strike true. When you Activate the javelin, your command makes the carvings crackle with electricity. You then hurl the javelin. It shatters immediately after leaving your hand and unleashes its magic as a 4th-level lightning bolt originating from your space. The bolt deals 5d12 electricity damage and has a Reflex save DC of 25.");
        }

        protected override IEnumerable<ConsumableVariant> GetConsumableVariants()
        {
            yield return new ConsumableVariant
            {
                Id = Guid.Parse("a4458e32-8af9-48b9-90bf-d7909bf17ddc"),
                Name = "Javelin of Lightning",
                CraftingRequirements = "Supply a casting of lightning bolt (4th level).",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                Price = 11000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("24063b8b-7431-46f6-8cd3-6f3ad70ee62a"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action.Kind("Command, Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("87778f65-124b-4725-8ba5-3092d56e0b41"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("91ca4e09-d0b3-4cd8-a6a4-219a7df9c997"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("126ed0c6-1e46-4670-9804-5b03e65daf03"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("610d314c-47d9-4bdf-b84e-e5fc84c9e8c3"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a7ca678-13de-49cb-ad74-9914048e4182"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 571
            };
        }
    }
}
