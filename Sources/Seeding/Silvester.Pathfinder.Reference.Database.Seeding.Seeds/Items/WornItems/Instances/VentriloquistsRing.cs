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
    public class VentriloquistsRing : Template
    {
        public static readonly Guid ID = Guid.Parse("19c06563-fdcf-4dd4-b336-a2af34cf6342");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ventriloquist's Ring",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c1ebf627-4590-4766-a1b2-18f07bc82674"), "This elegant copper ring has miniature images of songbirds engraved around its circumference. You gain a +1 item bonus to Deception checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("06c0feb8-4ee8-4355-a7ea-d890d7c4598a"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("a7fbfd88-9c43-4fae-a494-867b18858337"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("fccb0427-415c-4be5-b8a1-91aec3404be4"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("af26232d-ad3c-4ed9-8f8d-d61bf89105b5"),
                Name = "Ventriloquist's Ring",
                Usage = "Worn.",
                Level = 3,
                Price = 6000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()

                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("093e2a9e-7984-4925-9e93-3e643289799f"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("a6740e66-7aea-4597-a72c-25f21b83c67d"), "Twisting the ring around your finger allows you to magically throw your voice, with the effects of a ventriloquism spell (DC 19).");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("0986d76c-77fe-4236-a1af-84358b1490a0"),
                Name = "Ventriloquist's Ring (Greater)",
                Usage = "Worn.",
                Level = 9,
                Price = 67000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("221c3461-03bc-4f3a-aeb4-45c1e83d0fcb"), "The ring grants a +2 bonus. When you activate the ring, you gain the effects of 2nd-level ventriloquism (DC 27). You can activate the ring any number of times per day.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b9e2a52c-10d3-4965-9c2f-c677fb9f5536"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("e62f3026-486f-4342-8852-792351a8f88b"), "Twisting the ring around your finger allows you to magically throw your voice, with the effects of a 2nd-level ventriloquism spell (DC 27).");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0497f9b9-894f-4fdb-b05f-25c873314697"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 617
            };
        }
    }
}
