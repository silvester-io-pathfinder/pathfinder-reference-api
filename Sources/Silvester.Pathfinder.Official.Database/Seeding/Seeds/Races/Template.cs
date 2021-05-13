using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races
{
    public abstract class Template : EntityTemplate<Race>
    {
        protected override Race GetEntity(ModelBuilder builder)
        {
            Race race = GetRace();

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Race, Trait>((race.Id, traitId));
            }

            foreach (Guid languageId in GetLanguages())
            {
                builder.HasJoinData<Race, Language>((race.Id, languageId));
            }

            return race;
        }

        protected abstract Race GetRace();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<Guid> GetLanguages();
    }
}
