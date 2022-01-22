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
    public class PotionOfWaterBreathing : Template
    {
        public static readonly Guid ID = Guid.Parse("4bf86027-6f5d-419d-9b7b-6554727c3306");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Potion of Water Breathing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2c784faa-48be-4455-b4e2-57fd17bda0fb"), "This filmy, gray potion smells of an old fish midden and tastes even worse.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("6aebe7de-fd93-431c-9fee-57d74720fdff"),
                Name = "Potion of Water Breathing",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 3,
                Price = 1100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e77902b0-aada-44b9-9d10-0638a446588d"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("021b4886-dba5-4e24-848d-b6b3e11ec779"), "After drinking this potion, you gain the effects of a 2nd-level water breathing spell for 1 hour.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("efcc3067-90f7-43a1-8e12-7f3896c98059"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("7981d326-d8af-4f07-9941-2af4722b7213"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("0d167859-2ffc-4f28-8cd6-222f7ff31b80"), Traits.Instances.Potion.ID);
            builder.Add(Guid.Parse("1fdf1f08-c3b4-4b48-af47-5fde60fd0d78"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3dd2714d-1bfe-40ae-892c-bcc1e3eeddbb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 564
            };
        }
    }
}
