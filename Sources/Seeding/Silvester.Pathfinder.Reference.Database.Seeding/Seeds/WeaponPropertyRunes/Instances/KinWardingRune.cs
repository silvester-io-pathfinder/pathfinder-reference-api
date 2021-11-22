using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class KinWardingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("086a6b79-6f3d-4c16-8699-fc22f8157eaa");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Kin-Warding",
                Usage = "Etched onto a clan dagger."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("540c6e2d-b323-4467-978f-6b975fc1bfd6"),
                ItemLevel = 3,
                Price = 5200,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("7b26edf9-7025-4308-8b24-08abfe562ef7"), Type = TextBlockType.Text, Text = "A kin-warding clan dagger can deflect attacks aimed at your allies. When you use the weapon's parry trait, you can point the clan dagger at an adjacent ally instead of defending yourself, creating a shield of runes around them. The runic barrier grants your ally the weapon's circumstance bonus to AC, but you do not gain the bonus yourself."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Dwarf.ID;
            yield return Traits.Instances.Magical.ID;
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
