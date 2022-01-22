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
    public class InvisibilityPotion : Template
    {
        public static readonly Guid ID = Guid.Parse("c6ee60df-d332-42ca-ac56-601de6ce0c89");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Invisibility Potion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b1351327-47b9-4df2-857b-8f3b9345b790"), "An invisibility potion is colorless and oddly lightweight. Upon drinking it, you gain the effects of a 2nd-level invisibility spell.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("e4a6f87f-5b21-4f6f-8d70-c6ec3cf18865"),
                Name = "Invisibility Potion",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 4,
                Price = 2000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5ccbafb0-00b8-4f14-9169-1a1f622a8dff"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("60893c25-af04-41f4-b6ef-5282da5a68d8"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("05796777-1aa9-4983-8e76-4fef7d50fd09"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("c5703dfb-a331-4d56-97d9-38204f51b949"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("76c12fed-0772-4387-93b1-3bd77a8b1ea3"), Traits.Instances.Potion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c58d10a-bd26-4f13-881e-29e31a422848"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
