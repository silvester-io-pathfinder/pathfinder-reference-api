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
    public class Extending : Template
    {
        public static readonly Guid ID = Guid.Parse("6f7111d8-3114-4569-b1eb-eedaf1e4b0af");

        public static readonly Guid STANDARD_ID = Guid.Parse("e1d1d544-89e4-4fc3-81fe-f4730bc1d99b");
        public static readonly Guid GREATER_ID = Guid.Parse("2a1dbd35-cbfb-4d80-b8b2-2b81ebc50b2d");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Extending",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Extending",
                Usage = "Etched onto a melee weapon.",
                Level = 9,
                Price = 70000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f95b2b63-6687-4bcd-820f-8c8edf46d2cf"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7dc9ffda-1d21-44c9-8224-a5b466e0f409"), "You extend your weapon for an instant, giving you an impossible reach. You Strike with the weapon, and you have reach 60 feet for the Strike.");
                            });
                    })
                    .Build()
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Extending (Greater)",
                Usage = "Etched onto a melee weapon.",
                Level = 13,
                Price = 300000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2a369094-454f-4cbe-a2e3-162c4f33a520"), "The activation grants you reach 120 feet for the Strike.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("65f7b907-1aa4-4c80-b1d2-8215e7f3c262"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("32d170f3-4076-4f8b-9839-611159d98cd4"), "You extend your weapon for an instant, giving you an impossible reach. You Strike with the weapon, and you have reach 120 feet for the Strike.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a19dd24f-10ff-4637-803f-cef780d7767c"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("dd455721-ed11-4f10-9748-e475968a77fb"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("227a3492-5bcd-46b0-8137-e0280e017bf3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 184
            };
        }
    }
}
