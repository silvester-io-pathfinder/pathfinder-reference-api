using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Potions.Instances
{
    public class PotionOfUndetectability : Template
    {
        public static readonly Guid ID = Guid.Parse("36a982a9-1c1e-40bb-9d42-8827e7a4b071");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Potion of Undetectability",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e7d02d30-484d-4723-a85e-90d8f2e31269"), "Drinking this dull-black liquid makes you undetectable to divinations. This grants the same effects as mind blank, but without the bonus against mental effects. You also gain the effects of a 4th-level invisibility spell, which protects against see invisibility spells of 8th level and lower and has a DC of 36 against true seeing. The potion�s effects last for 10 minutes.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("598df404-eec1-4dd2-9bbf-aaeb7a24a5b5"),
                Name = "Potion of Undetectability",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 18,
                Price = 440000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("38ad7da2-b834-4978-a4af-5e066f161102"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e24d8645-4a9f-4a86-b6e9-8c115c69f1b8"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("781dd6e8-4121-48b0-b2d9-f1827e665582"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("1d3e23bd-d340-4a94-b1ab-7999b2ac8565"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d76d9cc0-89dc-442c-b8a2-12cc3fa1dfe5"), Traits.Instances.Potion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4147f6e-9b36-4cd7-9480-3c083327500d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
