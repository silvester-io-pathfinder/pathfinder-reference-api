using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class XXTemplate : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = DeityCategories.Instances..ID, 
                AlignmentId = Alignments.Instances..ID,
                Name = "", 
                Description = "",
                Edicts = "",
                Anathema = "",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances..ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances..ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances..ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances..ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances..ID,
                Page = 
            };
        }
    }
}
