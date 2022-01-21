using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Fanged : Template
    {
        public static readonly Guid ID = Guid.Parse("5177baf7-6d72-4d50-9512-794efc688ed2");

        public static readonly Guid STANDARD_ID = Guid.Parse("db105573-25e1-4803-9e25-811346a8da0d");
        public static readonly Guid GREATER_ID = Guid.Parse("9f5e2688-784b-4a15-8ae5-f103a6413907");
        public static readonly Guid MAJOR_ID = Guid.Parse("46f1ef88-310c-4de5-a0ae-76442580b751");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Fanged",
            };
        }

        protected override void GetInlineActions(IInlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("b45a6362-e7b4-472e-b234-ec7d466b9010"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
            {
                action
                    .Kind("Interact")
                    .Traits(traits =>
                    {
                        traits.Add(Guid.Parse("4c480719-6583-4828-b64b-d9b5d193ca70"), Traits.Instances.Magical.ID);
                        traits.Add(Guid.Parse("0d91f946-f7d0-467d-9c87-d9ab4ce4a6bf"), Traits.Instances.Polymorph.ID);
                        traits.Add(Guid.Parse("b9fbbbd6-9394-4f1c-91fb-95b39ff6281a"), Traits.Instances.Transmutation.ID);
                    })
                    .Details(effect =>
                    {
                        effect.Text(Guid.Parse("d40f59b4-da7a-40fd-9f94-d18f72008cf3"), "You transform into a Small or Medium animal that wields the fanged weapon in its jaws; the animal matches the animal you are most closely associated with (a lizardfolk would turn into a lizard, a kitsune into a fox, a deer instinct barbarian into a deer, etc.) or a wolf if no specific animal is applicable. While in this form, you can attack with the fanged weapon even though you don't have any hands. However, you can attack only with the fanged weapon and you don't have hands or the ability to hold items. For effects dependent on how many hands you are using to hold the item, such as the two-hand trait, you are holding the weapon in two hands. You can Dismiss this effect, and it ends automatically if you drop the fanged weapon (whether or not of your own volition).");
                    });
            });
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Fanged",
                Usage = "Etched onto a melee weapon.",
                Level = 2,
                Price = 3000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Fanged (Greater)",
                Usage = "Etched onto a melee weapon.",
                Level = 8,
                Price = 42500,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("471b49d8-badc-479b-a867-48daf9c94ce6"), "In animal form, you gain low-light vision and a +5-foot item bonus to your Speed.")
                    .Build()
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = MAJOR_ID,
                Name = "Fanged (Major)",
                Usage = "Etched onto a melee weapon.",
                Level = 15,
                Price = 600000,
                PotencyId = Potencies.Instances.Major.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("90925e08-1ba0-44e9-8e55-c41ec9c64a3e"), "In animal form, you gain low-light vision, imprecise scent to a range of 30 feet, and a +10-foot item bonus to your Speed.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ff3bc4ff-288d-41cd-af31-88656686052a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("aebd47cb-ece2-4f28-9b58-f54614e9ec77"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06894736-3382-4600-ba24-bf00e03b7bcf"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 106
            };
        }
    }
}
