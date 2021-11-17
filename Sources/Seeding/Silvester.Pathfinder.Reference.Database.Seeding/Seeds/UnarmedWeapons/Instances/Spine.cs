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
    public class Spine : Template
    {
        public static readonly Guid ID = Guid.Parse("d1b8e052-2d4e-43c0-a402-3506a79b3be9");
        
        protected override UnarmedWeapon GetUnarmedWeapon()
        {
            return new UnarmedWeapon
            {
                Id = ID, 
                Name = "Spine"
            };
        }
    }
}
