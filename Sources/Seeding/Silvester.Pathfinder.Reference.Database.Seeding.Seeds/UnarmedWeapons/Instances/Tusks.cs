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
    public class Tusks : Template
    {
        public static readonly Guid ID = Guid.Parse("ae8517c2-510d-4125-be40-1011fa455976");
        
        protected override UnarmedWeapon GetUnarmedWeapon()
        {
            return new UnarmedWeapon
            {
                Id = ID, 
                Name = "Tusks"
            };
        }
    }
}
