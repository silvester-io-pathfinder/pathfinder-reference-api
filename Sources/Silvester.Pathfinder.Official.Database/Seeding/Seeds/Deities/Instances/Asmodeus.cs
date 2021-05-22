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
    public class Asmodeus : Template
    {
        public static readonly Guid ID = Guid.Parse("f2906fe1-abeb-4b90-ac82-5578c5d87b6b");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = LawfulEvil.ID,
                Name = "Asmodeus", 
                Description = "The Prince of Darkness reigns over contracts, pride, slavery, and tyranny, and he delights in tempting mortals to the path of evil. He promotes strict hierarchies where everyone knows their place, and he takes advantage of order for his own selfish benefit.",
                Edicts = "Negotiate contracts to your best advantage, rule tyrannically and torture weaker beings, show subservience to your betters.",
                Anathema = "Break a contract, free a slave, insult Asmodeus by showing mercy to your enemies.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Deception.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Confidence.ID;
            yield return Fire.ID;
            yield return Trickery.ID;
            yield return Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7b62774-0f40-4bd0-862f-69e825bf36d1"),
                SourceId = CoreRulebook.ID,
                Page = 437
            };
        }
    }
}
