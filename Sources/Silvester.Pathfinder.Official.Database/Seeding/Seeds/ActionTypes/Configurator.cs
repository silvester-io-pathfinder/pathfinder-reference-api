using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes
{
    public class Configurator : EntityConfigurator<ActionType>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            /*builder
                .Entity<ActionType>()
                .OwnsMany(e => e.Effects, oe => oe.WithOwner().HasForeignKey(nameof(IOwnedEntity.OwnerId)));*/
        }
    }
}
