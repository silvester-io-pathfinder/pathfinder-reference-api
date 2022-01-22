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
    public class ShrinkingPotion : Template
    {
        public static readonly Guid ID = Guid.Parse("cb6297e6-7862-4e28-b19f-4c5ee949df2a");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Shrinking Potion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5f5c59fe-be4d-4f96-88fa-64ecaa112ff8"), "This fungus-flavored potion conveys the effects of the shrink spell to make you and all your gear smaller.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("21ad4d5c-1452-4073-965f-1691f34c31d5"),
                Name = "Shrinking Potion",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 4,
                Price = 1500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("42dca1d4-f893-4b76-a715-fc2970cbeab0"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("79901f13-1d97-4285-800b-53fd0464602b"), "After an onset of 1 minute, you become small for 10 minutes.");
                            });
                    })
                    .Build()
            };

            yield return new PotionVariant
            {
                Id = Guid.Parse("05f04ccf-9ddf-475b-b3f6-e05ce602f1cd"),
                Name = "Shrinking Potion (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 8,
                Price = 9000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d922e3e6-b53c-446d-80a1-728a5dbc4077"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("40ecabbc-04a1-491d-8af3-b1df55c8dca3"), "You become small for 1 hour, and gain the effects of a 4th-level Shrink spell. In addition, you gain a +2 item bonus to Stealth checks while shrunken.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("25af84ae-46e1-475d-bdc9-19646183e7a5"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("91a554d4-a777-497f-b039-65f68aa53581"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ca78d307-6332-42af-a760-bf8e6255c8bd"), Traits.Instances.Potion.ID);
            builder.Add(Guid.Parse("7393c2d7-ffa1-4523-aa1a-4f53d775f3a0"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc4f248d-a2b6-40a5-a817-ff231479efbb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 564
            };
        }
    }
}
