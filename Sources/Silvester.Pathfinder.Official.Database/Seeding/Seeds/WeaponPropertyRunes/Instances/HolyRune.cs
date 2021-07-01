using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class HolyRune : Template
    {
        public static readonly Guid ID = Guid.Parse("0347c95e-2227-4c7c-92f2-d37d77e78e7d");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Holy",
                Usage = "Etched onto a weapon without an unholy rune.",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("d2975b34-2c3a-4eb1-9dbe-8cc0fa325187"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Command",
                Frequency = "One per day.",
                Trigger = "You critically succeed at an attack roll against an evil creature with the weapon.",
                Effect = "You regain HP equal to double the evil creature’s level. This is a good, positive, healing effect."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("86c792b6-6ee5-46a1-9688-3799a701c313"),
                Price = 140000,
                ItemLevel = 11,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("af94facc-6c5b-47fe-a33e-cb9711835db1"), Type = TextBlockType.Text, Text = "Holy weapons command powerful celestial energy. A weapon with this rune deals an extra 1d6 good damage against evil targets. If you are evil, you are enfeebled 2 while carrying or wielding this weapon."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Good.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2f90062-1822-4d66-b634-4704a77549e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
