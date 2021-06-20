using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells
{
    public class SearchConfigurator : SearchableEntityConfigurator<Spell>
    {
        public override Expression<Func<Spell, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Addendum, e.Area, e.CastTime, e.Cost, e.Duration, e.Requirements, e.Targets, e.Trigger };
        }
    }
}
