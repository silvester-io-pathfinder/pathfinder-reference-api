using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Deities
{
    public abstract class Template : EntityTemplate<Deity>
    {
        protected override Deity GetEntity(ModelBuilder builder)
        {
            Deity deity = GetDeity();

            foreach(Guid followerAlignmentId in GetFollowerAlignments())
            {
                builder.HasJoinData<Alignment, Deity>((followerAlignmentId, deity.Id));
            }

            foreach (Guid divineFontId in GetDivineFonts())
            {
                builder.HasJoinData<DivineFont, Deity>((divineFontId, deity.Id));
            }

            foreach (Guid domainId in GetDomains())
            {
                builder.HasJoinData<Domain, Deity>((domainId, deity.Id));
            }

            foreach (Guid skillId in GetDivineSkills())
            {
                builder.HasJoinData<Skill, Deity>((skillId, deity.Id));
            }

            SourcePage sourcePage = GetSourcePage();
            deity.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            return deity;
        }

        protected abstract Deity GetDeity();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetFollowerAlignments();
        protected abstract IEnumerable<Guid> GetDivineFonts();
        protected abstract IEnumerable<Guid> GetDivineSkills();
        protected abstract IEnumerable<Guid> GetDomains();
    }
}
