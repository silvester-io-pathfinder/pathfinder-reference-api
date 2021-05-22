using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class KeenRune : Template
    {
        public static readonly Guid ID = Guid.Parse("06c3e60c-a8fd-4ded-9b23-23f224927ac2");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Keen",
                Usage = "Etched onto a piercing or slashing melee weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("660df2ec-e557-4f8b-b764-68de9070e59f"),
                ItemLevel = 13,
                Price = 300000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("2437c2d7-9210-4723-8ecd-2b926c969c00"), Type = TextBlockType.Text, Text = "The edges of a keen weapon are preternaturally sharp. Attacks with this weapon are a critical hit on a 19 on the die as long as that result is a success. This property has no effect on a 19 if the result would be a failure."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f0b6a4c-4daa-48ff-b82e-8e061658825b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
