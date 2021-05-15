using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class CunningRune : Template
    {
        public static readonly Guid ID = Guid.Parse("bab86729-ac81-4292-bf39-e86a51c24fcf");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Cunning",
                Usage = "Etched on a slashing or piercing weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("752ce6e0-d83f-47f5-b05a-29ed9a6bff51"),
                ActionTypeId = ActionTypes.Instances.Free.ID,
                Name = "Envision",
                Frequency = "Once per minute.",
                Requirements = "On your previous action this turn, you used this weapon to hit and damage a creature that has blood or other vital fluids.",
                Effect = "You learn the secrets the weapon gleaned from the creature's blood. Attempt to Recall Knowledge about the target of the required attack, gaining an item bonus to the Recall Knowledge skill check equal to the weapon's item bonus to attack rolls from its potency rune. If the required attack was a critical hit, you also gain a +2 circumstance bonus to this check."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("1e2e2357-47c3-4f71-9491-5aab77b26b6a"),
                Price = 14000,
                ItemLevel = 5,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("fe507108-08ea-4fa8-9696-d9bbcde9f30d"), Type = TextBlockType.Text, Text = "The weapon performs divination magic on the blood of your foes, granting you insight into their abilities and weaknesses."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd320d9a-e42e-4185-87b5-d32e6de99bee"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 123
            };
        }
    }
}
