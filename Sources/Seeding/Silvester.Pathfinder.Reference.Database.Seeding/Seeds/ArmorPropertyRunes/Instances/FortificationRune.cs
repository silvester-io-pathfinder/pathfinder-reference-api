using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class FortificationRune : Template
    {
        public static readonly Guid ID = Guid.Parse("010de771-6941-4a89-a142-c369c9fbdbd2");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Fortification",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0e0f934f-3816-48c9-8ece-1e2da97d197a"), Type = TextBlockType.Text, Text = "A fortification rune wards against the most deadly attacks." };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("b34ac828-abc6-4fdd-a309-78d87ea92417"),
                Benefits = "Each time you're critically hit while wearing the etched armor, attempt a DC 17 flat check. On a success, it becomes a normal hit. This property thickens the armor, increasing its Bulk by 1 and the Strength required to reduce its penalties by 2.",
                ItemLevel = 12,
                Price = 200000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };

            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("94dfd0a1-3b85-4515-98f5-838b4071e110"),
                Benefits = "Each time you're critically hit while wearing the etched armor, attempt a DC 14 flat check. On a success, it becomes a normal hit. This property thickens the armor, increasing its Bulk by 1 and the Strength required to reduce its penalties by 2.",
                ItemLevel = 18,
                Price = 2400000,
                PotencyId = Potencies.Instances.Greater.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42a06e50-9396-42ee-a2b1-85ab6a2b25e1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 582
            };
        }

    }
}
