using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class CorrosiveRune : Template
    {
        public static readonly Guid ID = Guid.Parse("83bb5d56-43f3-42c8-bd77-d8f5e7209d22");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Corrosive",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("70aebf9d-a280-4f70-9822-ea951a9c0023"),
                ItemLevel = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("1cb19254-c8f0-4214-8e82-4070dd4a805c"), Type = TextBlockType.Text, Text = "Acid sizzles across the surface of the weapon. When you hit with the weapon, add 1d6 acid damage to the damage dealt. In addition, on a critical hit, the target’s armor (if any) takes 3d6 acid damage (before applying Hardness); if the target has a shield raised, the shield takes this damage instead."},
                },
            };

            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("7e9d4453-15b3-4ce9-b9b7-305949c66255"),
                ItemLevel = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("df27e8fb-9b52-4d80-8f87-fff9fbbbdda1"), Type = TextBlockType.Text, Text = "The acid damage dealt by this weapon ignores the target’s acid resistance. Increase the acid damage dealt to armor or a shield on a critical hit to 6d6."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Acid.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f05c6e85-4bec-4f0b-ade0-8f0e7e85e5f9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
