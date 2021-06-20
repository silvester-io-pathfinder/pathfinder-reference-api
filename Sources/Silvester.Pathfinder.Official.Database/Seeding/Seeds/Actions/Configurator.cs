using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions
{
    public class Configurator : SearchableEntityConfigurator<Models.Action>
    {
        public override Expression<Func<Models.Action, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Requirements, e.Trigger};
        }
    }
}