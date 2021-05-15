using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class ShiftingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("327ed57b-80ae-431c-8611-310c9e4667f1");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Shifting",
                Usage = "Etched onto a melee weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("5be2c09b-99e6-4d4a-ab43-90c92dce906b"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Interact",
                Effect = "The weapon takes the shape of another melee weapon that requires the same number of hands to wield. The weapon’s runes and any precious material it’s made of apply to the weapon’s new shape. Any property runes that can’t apply to the new form are suppressed until the item takes a shape to which they can apply."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("b0fddee5-3b99-44a0-b38b-603c6b91442a"),
                ItemLevel = 6,
                Price = 22500,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("35aab7a3-912e-47aa-912d-5bdaaac06309"), Type = TextBlockType.Text, Text = "With a moment of manipulation, you can shift this weapon into a different weapon with a similar form."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
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
