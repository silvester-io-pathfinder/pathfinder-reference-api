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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class RingOfManiacalDevices : Template
    {
        public static readonly Guid ID = Guid.Parse("da0d0ac0-e47b-4b18-9fad-11b011ab1734");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Maniacal Devices",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("dc2b3087-8ad5-48c6-b949-b74fd7706c81"), "This ring seems like simple tarnished brass, but it enhances your curiosity about traps and devices of all kinds. You can use an Interact action to pull a set of thieves� tools from the ring. These tools appear in your hand and fold back into the ring if they would leave your possession. They grant you a +2 item bonus to Thievery checks to Disable a Device and to Pick a Lock, and the ring�s insights grant you the same bonus to Crafting checks to Craft and Repair snares and traps.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8f047668-1959-481c-a6f6-858ff10fada2"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("c5fa6caf-6445-4020-bdd3-97b8735bf420"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("a812cfac-63ba-408c-8434-02ae2ffbf516"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("630facc1-17d9-4af2-993c-7172241f065a"),
                Name = "Ring of Maniacal Devices",
                Usage = "Worn.",
                Level = 11,
                Price = 117500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6814c221-024f-424c-aebc-b259f6517b97"), ActionTypes.Instances.NoAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("10 minutes (Interact)")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("2a353287-08ef-4896-9481-83c18fc00729"), "You create a 4th-level glyph of warding containing fireball. You can have only one glyph of warding from a ring of maniacal devices active at a time, even if you have multiple rings, and the spell ends if you lose your investiture in the ring.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("7b91b416-0ef2-4475-9cc6-e5879564707f"),
                Name = "Ring of Maniacal Devices (Greater)",
                Usage = "Worn.",
                Level = 18,
                Price = 425000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("67190a9b-6af4-4b6d-8524-98a256ea54b5"), "The ring grants a +3 bonus. Activating it creates an 8th-level Glyph of Warding containing your choice of either Prismatic Spray or 7th-level Fireball.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f3e65582-2758-4471-9584-e7e4e82706b7"), ActionTypes.Instances.NoAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("10 minutes (Interact)")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("dcb5256c-282c-4433-b66a-ab15818de386"), "You create a 8th-level glyph of warding containing a 7th-level Fireball or a Prismatic Spray. You can have only one glyph of warding from a ring of maniacal devices active at a time, even if you have multiple rings, and the spell ends if you lose your investiture in the ring.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9934c37a-8009-4dad-8f85-fd3c7ea7d397"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 614
            };
        }
    }
}
