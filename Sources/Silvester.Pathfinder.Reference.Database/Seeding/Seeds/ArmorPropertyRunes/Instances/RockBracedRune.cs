using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class RockBracedRune : Template
    {
        public static readonly Guid ID = Guid.Parse("1add97fa-232b-4aed-a710-d41d42352ae1");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Rock-Braced",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d27ca5bd-e42f-4d6b-8432-838373be0fa3"), Type = TextBlockType.Text, Text = "Rock-braced armor makes you as hard to move as a boulder. " };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("a42afb26-c1df-4f95-acc5-bd3c1a58a58b"),
                Benefits = "Whenever another creature attempts to forcibly move you from your space, you gain a +4 item bonus to your Fortitude DC against the check to move you. If the creature would not normally need to attempt a check to move you, then the creature must succeed at an Athletics check against your Fortitude DC (including the +4 item bonus) or you are unmoved.",
                ItemLevel = 13,
                Price = 300000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Dwarf.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Saggorak.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3541d89b-6928-49a6-902e-f05be310dcb3"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 75
            };
        }
    }
}
