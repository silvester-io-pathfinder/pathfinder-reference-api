using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages
{
    public abstract class Template : EntityTemplate<Heritage>
    {
        protected override Heritage GetEntity(ModelBuilder builder)
        {
            Heritage heritage = GetHeritage();

            builder.HasJoinData<Heritage, Ancestry>(heritage, GetAncestries());
            
            return heritage;
        }

        protected abstract Heritage GetHeritage();
        protected abstract IEnumerable<Guid> GetAncestries();
    }
}
