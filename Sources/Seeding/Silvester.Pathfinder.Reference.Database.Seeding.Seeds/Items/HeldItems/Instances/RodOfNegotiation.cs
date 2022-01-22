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
    public class RodOfNegotiation : Template
    {
        public static readonly Guid ID = Guid.Parse("49a1080b-fc74-4756-84d9-ec387ba67b86");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Rod of Negotiation",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a5ce80c8-54a5-4777-92db-0df77f99a331"), "This long, plain, leaden rod can disrupt magic.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("2c81802f-a7c2-4851-93a8-b7fa8d9d876c"),
                Name = "Rod of Negotiation",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 14,
                Price = 430000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fb10a4c0-5213-4bc9-92cc-8891131718ac"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("bf165e78-0916-4488-9a94-fb5f436097a8"), "This rod emits a thin, gray beam that negates a spell or magic item, casting a 6th-level dispel magic spell with a counteract modifier of +23. Once");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1a2be427-03c3-4b42-b37f-60134bdc071e"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("23895eee-8f7b-4c76-a1ea-686a866df9ba"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d1bb511-b3f0-4662-b76e-a3879f019079"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 574
            };
        }
    }
}
