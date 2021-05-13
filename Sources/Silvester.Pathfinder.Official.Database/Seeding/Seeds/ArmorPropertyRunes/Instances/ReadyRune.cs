using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class ReadyRune : Template
    {
        public static readonly Guid ID = Guid.Parse("2dcf90ee-e52e-4e69-a809-6790cf49a622");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Ready",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9b5141e5-b893-4888-9173-33d15860de6c"), Type = TextBlockType.Text, Text = "A ready rune draws component pieces of a suit of armor toward one another, making it easier and faster to get into." };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("7e0e2fe0-a05e-45b8-bc1f-f1792e1ffc11"),
                Benefits = "You can don light armor with this rune as a 3-action activity or medium or heavy armor with this rune in 1 minute.",
                ItemLevel = 6,
                Price = 20000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("939ada90-fd7e-487d-9838-5eb1412fa98d"),
                Benefits = "You can don light armor with a greater ready rune as a single action, or medium or heavy armor with a greater ready rune as a 3-action activity.",
                ItemLevel = 11,
                Price = 120000,
                PotencyId = Potencies.Instances.Greater.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08f3aeac-81ce-4aa5-a0cb-47b5535a7619"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 262
            };
        }

    }
}
