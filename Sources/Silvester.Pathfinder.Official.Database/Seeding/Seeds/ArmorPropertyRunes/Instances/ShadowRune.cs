using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class ShadowRune : Template
    {
        public static readonly Guid ID = Guid.Parse("5bbaaa06-0e1b-4418-acd3-8b16548ac945");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Shadow",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f9c96673-ed3c-491c-96e1-52de805aefdc"), Type = TextBlockType.Text, Text = "Armor with this rune becomes hazy black." };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("de50faa8-b8e8-42c3-8599-5364a5e14508"),
                Benefits = "You gain a +1 item bonus to Stealth checks while wearing the armor.",
                ItemLevel = 5,
                Price = 5500,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("e98665b6-0191-4089-a300-05b800d482d7"),
                Benefits = "You gain a +2 item bonus to Stealth checks while wearing the armor.",
                ItemLevel = 9,
                Price = 65000,
                PotencyId = Potencies.Instances.Greater.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("74d3a787-2cf5-4833-a7c6-26c700233510"),
                Benefits = "You gain a +3 item bonus to Stealth checks while wearing the armor.",
                ItemLevel = 17,
                Price = 1400000,
                PotencyId = Potencies.Instances.Major.ID,
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
                Id = Guid.Parse("4d3bb1bb-092d-4e4e-8ef7-3bcb435cff87"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }

    }
}
