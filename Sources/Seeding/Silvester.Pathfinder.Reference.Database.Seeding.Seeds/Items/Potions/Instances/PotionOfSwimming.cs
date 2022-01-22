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
    public class PotionOfSwimming : Template
    {
        public static readonly Guid ID = Guid.Parse("e1082203-48f3-4222-8d44-f96e5cf67307");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Potion of Swimming",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("17e75790-47a3-49b1-afde-07a4e49545ba"), "This potion tastes like salt water, and sandy grit settles to the bottom of its container.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("5246a8a5-6b01-42b2-8c55-c875d5b93352"),
                Name = "Potion of Swimming",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 5000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("af58dd7f-f248-4abd-8091-5c49ba66e6d6"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("3a2f2736-4578-4563-b6b2-9b03ad6c1c8e"), "When you drink it, you gain a swim Speed equal to your land Speed for 10 minutes.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("913bf020-ad08-42e2-ac0c-7b3321be0a08"),
                Name = "Potion of Swimming (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 11,
                Price = 25000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8712b519-3e84-4ed8-be94-0e90dcc4d592"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e54f6936-60a2-4aba-aabe-96be348a5fb7"), "When you drink it, you gain a swim Speed equal to your land Speed for 1 hour.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fd4925a3-20d2-466b-bb0e-7f1f49a00d41"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("d24049e4-1c64-4b49-8e3b-d63c652aafe5"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("20009d5e-c43f-4402-9a62-17144bcdcd3e"), Traits.Instances.Potion.ID);
            builder.Add(Guid.Parse("12a3968d-7c8e-408b-95bc-2c8297e805c3"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5293587-0169-495e-8239-0ce150690f04"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 563
            };
        }
    }
}
