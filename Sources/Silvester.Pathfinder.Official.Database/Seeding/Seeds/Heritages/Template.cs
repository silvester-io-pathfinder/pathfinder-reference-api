using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Heritages
{
    public abstract class Template : EntityTemplate<Heritage>
    {
        protected override Heritage GetEntity(ModelBuilder builder)
        {
            Heritage heritage = GetHeritage();

            foreach(Guid raceId in GetRaces())
            {
                builder.HasJoinData<Race, Heritage>((raceId, heritage.Id));
            }

            return heritage;
        }

        protected abstract Heritage GetHeritage();
        protected abstract IEnumerable<Guid> GetRaces();
    }
}
