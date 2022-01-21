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
    public class Brilliant : Template
    {
        public static readonly Guid ID = Guid.Parse("b40e28e1-f014-462d-bb2e-ae685b942def");

        public static readonly Guid STANDARD_ID = Guid.Parse("07cc14e3-ac41-472d-9228-6d469b6cf8c6");
        public static readonly Guid GREATER_ID = Guid.Parse("fab13a38-9f8b-4a13-b5ab-3a3188d3742c");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Brilliant",
            };
        }

        protected override void GetInlineActions(IInlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("6f7cd08c-c9a7-4aed-b6e3-5a6511bc8014"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
            {
                action
                    .Kind("Command")
                    .Traits(traits =>
                    {
                        traits.Add(Guid.Parse("f80ef60a-7c77-49e3-b241-98d405dafbab"), Traits.Instances.Light.ID);
                    })
                    .Details(effect =>
                    {
                        effect.Text(Guid.Parse("2376a378-954c-442f-9768-7e41b1d22e7b"), "You plunge your weapon into darkness to return the light. Attempt a counteract check with a counteract level of 5 and a +19 counteract modifier to end a magical darkness effect whose area is within reach of the weapon.");
                    });
            });
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Brilliant",
                Usage = "Etched onto a weapon.",
                Level = 12,
                Price = 200000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Brilliant (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 18,
                Price = 2400000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("cfff4bb6-e232-44b3-bb94-b28d33216c0b"), "The save DC is 41, the counteract level is 9, the counteract modifier is +31, and damage dealt by this weapon ignores the target's fire, good, or positive resistance.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a45f442b-4b22-4082-b7b5-51bbe43ba733"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("53adcf44-a950-463b-9c71-e30291142dd0"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec538c73-3b5e-42db-bc85-d6dd52215d59"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 180
            };
        }
    }
}
