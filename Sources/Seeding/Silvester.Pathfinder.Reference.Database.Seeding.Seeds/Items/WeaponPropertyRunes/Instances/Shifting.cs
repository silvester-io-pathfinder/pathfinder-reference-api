using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Shifting : Template
    {
        public static readonly Guid ID = Guid.Parse("327ed57b-80ae-431c-8611-310c9e4667f1");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Shifting",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d741cf8a-3c8c-4a09-a02a-27e96eb3ac35"), "With a moment of manipulation, you can shift this weapon into a different weapon with a similar form.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("b0fddee5-3b99-44a0-b38b-603c6b91442a"),
                Name = "Shifting",
                Usage = "Etched onto a melee weapon.",
                Level = 6,
                Price = 22500,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("17f8aceb-899f-459a-9169-b16793bc0e33"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("a74e7402-b33c-4b2e-bb87-8611dbf62feb"), "The weapon takes the shape of another melee weapon that requires the same number of hands to wield. The weapon�s runes and any precious material it�s made of apply to the weapon�s new shape. Any property runes that can�t apply to the new form are suppressed until the item takes a shape to which they can apply.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b6fca7ff-0ff9-4bf0-b217-a24934658ae7"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("c4201ea8-36f9-408c-a500-856b3b7aecf5"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45fce989-96d3-4b4d-8f52-5bc1fb8731ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
