using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class DisruptingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("28896ad6-948f-4a6d-943d-40daa0d11b80");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Disrupting",
                Usage = "Etched onto a melee weapon."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("aec8ff2c-14fc-4cc8-81af-3cd75de33eb4"),
                ItemLevel = 5,
                Price = 15000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("a85cc247-1c72-4c15-9e45-a5216ca4c938"), Type = TextBlockType.Text, Text = "A disrupting weapon pulses with positive energy.The weapon deals an extra 1d6 positive damage to undead. On a critical hit, the undead is also enfeebled 1 until the end of your next turn."},
                },
            };
            
           yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("76aadc75-c6fe-4a63-9fce-78bc73f54dd2"),
                ItemLevel = 14,
                Price = 430000,
                PotencyId = Potencies.Instances.Greater.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("d153920f-4c9c-4a88-a3a8-6a1a3c54ecf4"), Type = TextBlockType.Text, Text = "Increase the extra damage to 2d6. On a critical hit, instead of being enfeebled 1, the undead creature must attempt a DC 34 Fortitude save with the following effects. This is an incapacitation effect."},
                },
                RollableEffect = new RollableEffect
                {
                    Id = Guid.Parse("ad329a6e-7b83-49d8-8df6-2f29902844aa"),
                    CriticalSuccess = "It’s enfeebled 1 until the end of your next turn.",
                    Success = "It’s enfeebled 2 until the end of your next turn.",
                    Failure = "It’s enfeebled 3 until the end of your next turn.",
                    CriticalFailure = "It’s destroyed."
                }
            };
        }

        protected override IEnumerable<Guid> GetPotencyTraits(WeaponPropertyRunePotencyBinding potency)
        {
            if(potency.PotencyId == Potencies.Instances.Greater.ID)
            {
                return new[] { Traits.Instances.Uncommon.ID };
            }

            return base.GetPotencyTraits(potency);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f46eeebe-1fa9-444b-8878-db7ed8c47bde"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
