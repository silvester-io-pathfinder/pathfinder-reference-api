using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class WoundingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("819a6e90-6506-4cc3-8938-f0ffbffc01b2");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Wounding",
                Usage = "Etched onto a piercing or slashing melee weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("f4de6228-1e02-4a73-a6ed-a7f328a26eac"),
                ItemLevel = 7,
                Price = 34000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("8b173bbe-1116-4a16-a533-5d3a6b6ad049"), Type = TextBlockType.Text, Text = "Weapons with wounding runes are said to thirst for blood. When you hit a creature with a wounding weapon, you deal an extra 1d6 persistent bleed damage. On a critical hit, it instead deals 1d12 persistent bleed damage."},
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35747fc8-b2c2-48f4-92b0-9ed7d31417e8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
