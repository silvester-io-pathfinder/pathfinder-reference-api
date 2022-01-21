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
    public class MessengersRing : Template
    {
        public static readonly Guid ID = Guid.Parse("1c526ef6-b15f-4dc1-878a-d81010158f3c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Messenger's Ring",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("84832ec9-fa45-4535-95b7-aca9ef1ec005"), "This silver signet ring changes to match the insignia of a lord or organization you serve (or your own face, if you serve no one else). It grants you a +2 item bonus to Diplomacy checks and lets you cast message as an arcane innate spell at will.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6cb1581f-f596-487c-b1f1-a9c6ec1ab535"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("f95a85c0-f935-4e1a-b2ee-7bb97ece8d09"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("624d4197-28f9-4a4a-b5c1-ec3238bbaa0c"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("a8273854-7656-43d6-9f62-6e9aa6dad5b4"),
                Name = "Messenger's Ring",
                Usage = "Worn.",
                Level = 9,
                Price = 70000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f052a3e8-e05f-4add-a385-9b42549c7f2e"), ActionTypes.Instances.NoAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("1 minute (Envision)")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("596c3185-225a-4234-9c36-e9de89f3990d"), "The ring casts animal messenger to your specification. The animal is a magical creature that springs from the ring, and its appearance suits the iconography or heraldry of the lord or organization represented by the ring.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("57bff46a-37ab-4577-9da3-39c7d27a5f5f"),
                Name = "Messenger's Ring (Greater)",
                Usage = "Worn.",
                Level = 17,
                Price = 1350000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("bb756aaf-b0ed-4623-852d-889da6f08d4d"), "The ring grants a +3 bonus and can be activated in an additional way.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("79c598db-10c4-46d0-ba3a-1f8b2aa73d4d"), ActionTypes.Instances.NoAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("1 minute (Envision)")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("2de6f4b2-a64d-46a4-8b9d-0f54a2d679c4"), "The ring casts animal messenger to your specification. The animal is a magical creature that springs from the ring, and its appearance suits the iconography or heraldry of the lord or organization represented by the ring.");
                            });
                    })
                    .Add(Guid.Parse("f4f14237-3181-4cb0-b978-612960e5838f"), ActionTypes.Instances.ThreeActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per hour.")
                            .Details(effects =>
                            {
                                effects.Text(Guid.Parse("5493b37f-a0bc-4a90-bc5a-fe9922e41aa3"), "The ring casts Sending to your specifications.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1919e89f-0d9b-45df-9da1-8b568a8dd12e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 613
            };
        }
    }
}
