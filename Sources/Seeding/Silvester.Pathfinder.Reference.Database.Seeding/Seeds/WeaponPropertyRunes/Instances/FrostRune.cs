using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class FrostRune : Template
    {
        public static readonly Guid ID = Guid.Parse("fb4d332f-a643-4f63-8c5f-b99383dbef4a");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Frost",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("1b57fea8-cdc8-4899-8cdb-f84700bfe741"),
                ItemLevel = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("c027d501-04ab-4699-b417-55d66cbf3da9"), Type = TextBlockType.Text, Text = "This weapon is empowered with freezing ice. It deals an additional 1d6 cold damage on a successful Strike. On a critical hit, the target is also slowed 1 until the end of your next turn unless it succeeds at a DC 24 Fortitude save."},
                },
            };

            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("86cccc3e-defb-448b-82a7-48b14c021cb5"),
                ItemLevel = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("741897ff-c80f-4e5d-ac1e-72c809c9fef5"), Type = TextBlockType.Text, Text = "The save DC is 34. Cold damage dealt by this weapon ignores the target's cold resistance."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb151d6c-36e8-4369-a797-3feab8022e4e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
