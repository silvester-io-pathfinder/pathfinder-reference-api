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
    public class DecanterOfEndlessWater : Template
    {
        public static readonly Guid ID = Guid.Parse("e2e7b899-5dc2-4bbd-b320-9597dd235c46");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Decanter of Endless Water",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c74b64c9-14b4-466a-8657-5fc3512f75d1"), "This item looks like an ordinary glass flask full of water. The stopper can't be removed unless you speak one of the item's three command words, each of which causes water to pour forth in a different way. Pulling the stopper straight out creates fresh water, and rotating it as you pull creates salt water. Any effect of the decanter lasts until the decanter is plugged (with its own stopper, a finger, or the like).");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("2cd951ba-6585-4403-98a3-77a02f2abebb"),
                Name = "Decanter of Endless Water",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 7,
                Price = 32000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f0895f6d-b959-495c-9ba3-af2557cda7e6"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("30931ec3-dac2-4a38-af3d-40cffe90c159"), "Speaking \"stream\", you cause water to pour at a rate of 1 gallon per round.");
                            });
                    })
                    .Add(Guid.Parse("3bc74153-db4e-4a86-a6e1-16e1e8cbc7aa"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("7c0b0575-f5d4-49b5-9049-74b7e0bed9b7"), "Speaking \"fountain\", you cause water to pour in a 5-foot-long stream at a rate of 5 gallons per round.");
                            });
                    })
                    .Add(Guid.Parse("9b3cdb3d-d1e0-4922-b769-b17d19ae2962"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("9ad2f61a-824e-4802-b232-5b493eb53e0c"), "Speaking \"geyser\", you cause a powerful deluge of water to erupt at a rate of 15 gallons per round. You can direct the stream at a creature, subjecting it to the effects of hydraulic push (spell attack roll +15). You can repeat this once per round as long as the geyser continues, spending an Interact action to direct the geyser each time.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4a2e1ee6-4bab-4e0c-9524-22dd1ff55aac"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("dda3d230-24db-4721-b128-71a05acc76b3"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("8eb5c112-585d-421e-b357-879934fb0c91"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7bfd0a09-38a5-48ef-b454-c1065bfdc827"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 573
            };
        }
    }
}
