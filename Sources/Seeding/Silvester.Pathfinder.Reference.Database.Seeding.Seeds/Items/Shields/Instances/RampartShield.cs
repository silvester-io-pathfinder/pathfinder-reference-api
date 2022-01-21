using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class RampartShield : Template
    {
        public static readonly Guid ID = Guid.Parse("88620026-16f7-4a0e-8d82-2ed0c2b33ad2");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Rampart Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1cddbea8-65b2-4cc2-ad71-f7a4345e82ce"), "This massive tower shield (Hardness 10, HP 60, BT 30) is painted a cool cyan green and is decorated with an image of Absalom's mother-sphinx emerging from a cresting wave.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("85a4e602-79fa-473b-b4e8-628907beac9a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e6e8e803-4cc3-4566-b192-b6a441fc0dee"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("47811bc2-95de-4941-ab55-17379198dea7"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("60a1d336-45de-42e4-85e2-fcf9ec9601d5"),
                Name = "Rampart Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 12,
                BrokenThreshold = 30,
                Hardness = 10,
                HitPoints = 60,
                Price = 190000,
                BulkId = Bulks.Instances.FourBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("07b0cb21-6911-4876-b2e8-77a6e064966a"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e762e343-1671-405c-9337-b17b5b735d31"), "You transform the shield into a 1-foot-thick, 10-foot-by-10-foot stone rampart topped with a battlement and adorned with the flags of Absalom. If any part of the rampart would pass through any creatures or objects, the activation fails. At the center of each 5-foot length of the rampart is an arrow slit. The rampart has AC 10, Hardness 15, and 30 Hit Points. The rampart is immune to critical hits and precision damage. Attacks that would destroy the rampart cause it to instead revert back to its shield form and drop to the ground in an open space below the rampart. When this happens, the shield loses 30 Hit Points. You can Dismiss the activation, causing the wall to revert back to its shield form. The shield then returns secured to your arm if you are adjacent to the rampart, or drops to the ground in an open space if you're not adjacent to the rampart. If neither destroyed nor Dismissed, the rampart reverts back to a shield automatically after 1 hour.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56841247-2a82-4fc3-8f01-c02bd729db19"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 30
            };
        }
    }
}
