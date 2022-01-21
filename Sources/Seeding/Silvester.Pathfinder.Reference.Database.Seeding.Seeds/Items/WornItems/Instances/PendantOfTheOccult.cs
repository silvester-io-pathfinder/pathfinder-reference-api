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
    public class PendantOfTheOccult : Template
    {
        public static readonly Guid ID = Guid.Parse("7ff62fc4-aee6-4ae1-adc3-03e46051ea67");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Pendant of the Occult",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e8776252-ac4a-40f2-80c6-7243ab03c838"), "This amulet is hollow and shaped in the form of an unblinking eye. Its cavity typically holds some fragment of occult text. While wearing the pendant, you gain a +1 item bonus to Occultism checks, and you can cast the guidance cantrip as an occult innate spell.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a54b0457-098b-45df-ba6c-b5e43946a499"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("c58f6c44-5d2f-449a-b49e-7b6b630e1ebb"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("b849e21e-e084-4641-9c03-c49e6d5bae87"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("fc6aec59-9ce9-4f43-ba3e-4374b306853a"),
                Name = "Pendant of the Occult",
                Usage = "Worn.",
                Level = 3,
                Price = 6000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("62bcc065-107d-4440-9024-ec7f55b25a64"),
                Name = "Pendant of the Occult (Greater)",
                Usage = "Worn.",
                Level = 9,
                Price = 65000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("28f71e81-d1fc-4e5f-9410-f80779b2df0f"), "The pendant grants a +2 item bonus and can be activated.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1a6d67dd-1ad7-4fcf-882a-4d1fcc6cb246"), ActionTypes.Instances.NoAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("10 minutes (Cast a Spell)")
                            .Frequency("Once per day.")
                            .Details(effects =>
                            {
                                effects.Text(Guid.Parse("31ffd278-dfaa-4b56-900d-1808201e2f6b"), "You cast a 4th-level Dream Message spell.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e722ace9-af38-4620-b932-f804befe3199"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 613
            };
        }
    }
}
