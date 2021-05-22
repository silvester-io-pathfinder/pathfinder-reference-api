using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class FlamingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("aa35dfd4-adc6-4890-a6aa-f9aa6b9a481c");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Flaming",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("b58e2a96-37d4-4fba-88d3-6e0b7c5f343f"),
                ItemLevel = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("0d37b169-ac4c-45c4-989b-5bfa75d0123d"), Type = TextBlockType.Text, Text = "This weapon is empowered by flickering flame. The weapon deals an additional 1d6 fire damage on a successful Strike, plus 1d10 persistent fire damage on a critical hit."},
                },
            };

            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("77655a2a-e1e7-4374-89e2-c54b011d95bd"),
                ItemLevel = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("0f90f3f7-66ed-43ac-bc3d-c28968b5fbec"), Type = TextBlockType.Text, Text = "Increase the persistent damage on a critical hit to 2d10. Fire damage dealt by this weapon (including the persistent fire damage) ignores the target’s fire resistance."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f008cc0e-bd01-44ab-a73e-95aa6e09ac04"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
