using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class KinWarding : Template
    {
        public static readonly Guid ID = Guid.Parse("086a6b79-6f3d-4c16-8699-fc22f8157eaa");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Kin-Warding",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("692b36b1-2c87-4d77-9542-d81dff1ff942"), "A kin-warding clan dagger can deflect attacks aimed at your allies.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("540c6e2d-b323-4467-978f-6b975fc1bfd6"),
                Name = "Kin-Warding",
                Usage = "Etched onto a clan dagger.",
                Level = 3,
                Price = 5200,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("7b26edf9-7025-4308-8b24-08abfe562ef7"), "When you use the weapon's parry trait, you can point the clan dagger at an adjacent ally instead of defending yourself, creating a shield of runes around them. The runic barrier grants your ally the weapon's circumstance bonus to AC, but you do not gain the bonus yourself.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2e2ee9d6-530b-4b18-9105-e31db18e9ee4"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("ca559cfe-b96a-494e-b6fe-fc352e22cdec"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("39223f46-b5ac-49b2-bbd8-207c684c114d"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef747e30-00e0-404b-8792-ce8c9370eb31"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 75
            };
        }
    }
}
