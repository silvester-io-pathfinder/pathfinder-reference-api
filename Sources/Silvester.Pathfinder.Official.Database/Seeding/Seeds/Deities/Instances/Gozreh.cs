using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DivineFonts.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Deities.Instances
{
    public class Gozreh : Template
    {
        public static readonly Guid ID = Guid.Parse("170aa0d1-a909-4a4c-af5e-7177bb1ce6bb");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = TrueNeutral.ID,
                Name = "Gozreh", 
                Description = "A deity of two aspects, known as the Wind and the Waves, Gozreh rules over nature, the sea, and weather. Gozreh is popular with druids and those who seek to preserve the wilds.",
                Edicts = "Cherish, protect, and respect nature in all its forms.",
                Anathema = "Bring civilization to intrude on the wild, create undead, despoil areas of natural beauty.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Survival.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Air.ID;
            yield return Travel.ID;
            yield return Water.ID;
            yield return Domains.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return NeutralGood.ID;
            yield return LawfulNeutral.ID;
            yield return TrueNeutral.ID;
            yield return ChaoticNeutral.ID;
            yield return NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d5cf852-bed1-48db-a64f-adf11b77bfa0"),
                SourceId = CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
