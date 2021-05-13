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
    public class Urgathoa : Template
    {
        public static readonly Guid ID = Guid.Parse("00121d0e-af82-4326-9bfb-90436a71b5b8");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = NeutralEvil.ID,
                Name = "Urgathoa", 
                Description = "The amoral Pallid Princess oversees disease, gluttony, and undeath.",
                Edicts = "Become undead upon death, create or protect the undead, sate your appetites.",
                Anathema = "Deny your appetites, destroy undead, sacrifice your life.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Indulgence.ID;
            yield return Magic.ID;
            yield return Might.ID;
            yield return Undeath.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulEvil.ID;
            yield return NeutralEvil.ID;
            yield return ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e740538-1c2f-4cf8-9b48-91004384b196"),
                SourceId = CoreRulebook.ID,
                Page = 440
            };
        }
    }
}
