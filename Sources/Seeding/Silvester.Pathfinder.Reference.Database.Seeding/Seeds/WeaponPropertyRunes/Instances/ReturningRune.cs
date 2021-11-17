using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class ReturningRune : Template
    {
        public static readonly Guid ID = Guid.Parse("89332a34-0067-4b4f-b5a8-ce00c41c6935");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Returning",
                Usage = "Etched on a thrown weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("75f92632-1173-4d98-8546-7d8e023ce6e0"),
                ItemLevel = 3,
                Price = 5500,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("14bb656e-55be-4111-aa46-a37ddf6df5db"), Type = TextBlockType.Text, Text = "When you make a thrown Strike with this weapon, it flies back to your hand after the Strike is complete. If your hands are full when the weapon returns, it falls to the ground in your space."},
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
                Id = Guid.Parse("c3da8b5c-3de7-416a-aea4-91db6e328f7a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
