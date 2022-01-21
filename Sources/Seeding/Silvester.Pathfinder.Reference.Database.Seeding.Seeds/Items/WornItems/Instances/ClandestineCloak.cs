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
    public class ClandestineCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("11b7fe2a-49e4-4e9a-83fe-ed95bc70dc58");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Clandestine Cloak",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1077adcf-f544-4536-af97-612416a7d351"), "When you pull up the hood of this nondescript gray cloak (an Interact action), you become drab and uninteresting, gaining a +1 item bonus to Stealth checks and to Deception checks to Impersonate a forgettable background character, such as a servant, but also taking a �1 item penalty to Diplomacy and Intimidation checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0933eb4c-33c7-4699-86a5-78c9ce2e84d5"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("835c5845-156a-4474-b0be-08c83964d473"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("6d1b5339-8ce2-47f5-acd7-c607bc94b36a"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("2af1f55f-5afe-47f8-9edd-5018464f9054"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("d8114eab-0e0a-43a7-bced-2726d0d61532"),
                Name = "Clandestine Cloak",
                Usage = "Worn cloak.",
                Level = 6,
                Price = 23000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e45ced7a-e1fd-4e65-b53f-4229fc381387"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision, Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("77a45e29-8ee3-4758-beed-562c54e44dda"), "You pull the cloak�s hood up and gain the benefits of nondetection for 1 hour or until you pull the hood back down, whichever comes first.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("34ee4aba-fd4a-4cfd-8783-1d0f084bcc1f"),
                Name = "Clandestine Cloak (Greater)",
                Usage = "Worn cloak.",
                Level = 10,
                Price = 90000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("178c7550-38f3-405f-9ac2-d0e3287d440f"), "The item bonus is +2, and when you activate the cloak, you gain the benefits of 5th-level nondetection for 8 hours.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3b3ae3c9-c3a4-4bc8-9a43-6abbfe400543"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision, Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("40967fbe-41d4-4fe6-abad-1da0b2757eae"), "You pull the cloak's hood up and gain the benefits of 5th-level nondetection for 8 hours or until you pull the hood back down, whichever comes first.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7a3e7e8-116f-46d2-9aad-5f1b40693305"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 608
            };
        }
    }
}
