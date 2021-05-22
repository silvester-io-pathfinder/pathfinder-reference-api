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
    public class Erastil : Template
    {
        public static readonly Guid ID = Guid.Parse("fb7a9b85-7e2f-4c85-84e2-1b5fd70f9e63");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = LawfulGood.ID,
                Name = "Erastil", 
                Description = "Old Deadeye is god of family, farming, hunting, and trade. Long ago he was a horned god of the hunt, but his worship evolved to focus on rural communities.",
                Edicts = "Care for your home and family, fulfill your duties, keep the peace, protect the community.",
                Anathema = "Abandon your home in its time of need, choose yourself over your community, tarnish your reputation, tell lies.",
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
            yield return Earth.ID;
            yield return Family.ID;
            yield return Wealth.ID;
            yield return Domains.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulGood.ID;
            yield return NeutralGood.ID;
            yield return LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26514168-e4c0-47a6-a22c-b1aed5d3ab9b"),
                SourceId = CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
