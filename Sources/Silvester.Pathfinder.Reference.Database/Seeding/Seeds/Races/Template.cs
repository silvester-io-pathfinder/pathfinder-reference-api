using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races
{
    public abstract class Template : EntityTemplate<Race>
    {
        protected override Race GetEntity(ModelBuilder builder)
        {
            Race race = GetRace();

            builder.AddTraits(race, GetTraits());
            builder.HasJoinData<Race, Language>(race, GetLanguages());

            return race;
        }

        protected abstract Race GetRace();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<Guid> GetLanguages();
    }
}
