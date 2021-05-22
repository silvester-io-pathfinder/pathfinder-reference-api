using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class UnholyRune : Template
    {
        public static readonly Guid ID = Guid.Parse("97c626c9-64b6-4b0b-ac3b-c362d7d661c3");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Unholy",
                Usage = "Etched onto a weapon without a holy rune.",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("06e47d8f-a1bd-4f8e-997d-08e750dd6d8b"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Command",
                Frequency = "Once per day.",
                Trigger = "You critically succeed at an attack roll against a good creature with the weapon.",
                Effect = "The target takes persistent bleed damage equal to 1d8 per weapon damage die of the etched weapon."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("d86da8fd-78d2-420d-a04e-304c93154c7b"),
                ItemLevel = 11,
                Price = 140000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("957ce6ff-ee9e-43b2-bd73-0d65204bf7d8"), Type = TextBlockType.Text, Text = "An unholy rune instills fiendish power into the etched weapon. A weapon with this rune deals an additional 1d6 evil damage when it hits a good target. If you are good, you are enfeebled 2 while carrying or wielding this weapon."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3c98b15-fdac-4f6c-982a-c904d7964247"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
