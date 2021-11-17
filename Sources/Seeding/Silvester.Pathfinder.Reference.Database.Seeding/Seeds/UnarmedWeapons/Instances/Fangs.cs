using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.UnarmedWeapons.Instances
{
    public class Fangs : Template
    {
        public static readonly Guid ID = Guid.Parse("d0e48e81-e696-4331-a53f-e5130290ae45");
        
        protected override UnarmedWeapon GetUnarmedWeapon()
        {
            return new UnarmedWeapon
            {
                Id = ID, 
                Name = "Fangs"
            };
        }
    }
}
