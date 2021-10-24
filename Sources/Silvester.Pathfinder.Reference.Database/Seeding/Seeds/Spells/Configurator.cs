using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells
{
    public class SearchConfigurator : SearchableEntityConfigurator<Spell>
    {
        public override Expression<Func<Spell, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Addendum, e.Area, e.CastTime, e.Cost, e.Duration, e.Requirements, e.Targets, e.Trigger };
        }
    }
}
