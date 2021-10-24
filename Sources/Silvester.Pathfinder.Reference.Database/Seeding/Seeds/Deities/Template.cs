using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities
{
    public abstract class Template : EntityTemplate<Deity>
    {
        protected override Deity GetEntity(ModelBuilder builder)
        {
            Deity deity = GetDeity();

            builder.AddSourcePage(deity, GetSourcePage(), e => e.SourcePageId);
            builder.HasJoinData<Deity, Alignment>(deity, GetFollowerAlignments());
            builder.HasJoinData<Deity, DivineFont>(deity, GetDivineFonts());
            builder.HasJoinData<Deity, Domain>(deity, GetDomains());
            builder.HasJoinData<Deity, Skill>(deity, GetDivineSkills());
            
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
