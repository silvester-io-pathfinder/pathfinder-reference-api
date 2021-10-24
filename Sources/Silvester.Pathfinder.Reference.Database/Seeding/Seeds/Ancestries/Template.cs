using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries
{
    public abstract class Template : EntityTemplate<Ancestry>
    {
        protected override Ancestry GetEntity(ModelBuilder builder)
        {
            Ancestry ancestry = GetAncestry();

            builder.AddTraits(ancestry, GetTraits());
            builder.HasJoinData<Ancestry, Language>(ancestry, GetLanguages());

            return ancestry;
        }

        protected abstract Ancestry GetAncestry();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<Guid> GetLanguages();
    }
}
