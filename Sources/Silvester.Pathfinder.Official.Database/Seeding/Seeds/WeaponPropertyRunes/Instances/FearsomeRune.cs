using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class FearsomeRune : Template
    {
        public static readonly Guid ID = Guid.Parse("0cf9a028-72a8-44ad-82c6-72f6bd9351a3");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Fearsome",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("f40bf60b-e57d-4021-b7b9-4b98c8eb62c6"),
                ItemLevel = 5,
                Price = 16000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("db638e68-2428-4c0c-a41d-1bf5043b1264"), Type = TextBlockType.Text, Text = "When you critically hit with this weapon, the target becomes frightened 1."},
                },
            };

            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("e2c40d60-9c36-4dfa-a877-2c240993a9e2"),
                ItemLevel = 12,
                Price = 200000,
                PotencyId = Potencies.Instances.Greater.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("ddbe3dfd-fdd0-498c-a580-58bf270bb7fe"), Type = TextBlockType.Text, Text = "When you critically hit with this weapon, the target becomes frightened 2."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f7cd5a7-5142-4f35-a103-b8146f1739a0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 260
            };
        }
    }
}
