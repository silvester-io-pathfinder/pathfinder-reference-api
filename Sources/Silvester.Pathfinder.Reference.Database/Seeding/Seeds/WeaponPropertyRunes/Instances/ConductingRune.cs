using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class ConductingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("bf9f7ffc-b647-48f0-b818-557d23de1511");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Conducting",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("ece62494-d652-4ea8-96d9-3a1cb7348265"),
                ItemLevel = 7,
                Price = 30000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("dbed857f-4af5-4a1c-8a71-d1bde6b1f7d1"), Type = TextBlockType.Text, Text = "A conducting weapon can channel energy through it. The weapon gains the resonant weapon trait, except that when you Conduct Energy, the weapon deals an additional 1d8 damage of the selected type instead of 1 additional damage per die; if the weapon already had the resonant weapon trait, it deals 1d8 damage plus 1 damage per die instead. On a critical hit, the weapon deals 1d8 persistent damage of the same type."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86667daa-a9b2-40bf-9716-504bb98f8e8a"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 139
            };
        }
    }
}
