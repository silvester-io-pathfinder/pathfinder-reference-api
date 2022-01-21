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
    public class Talon : Template
    {
        public static readonly Guid ID = Guid.Parse("0baf22c4-df74-4f6b-9b07-b7d091191c68");
        
        protected override UnarmedWeapon GetUnarmedWeapon()
        {
            return new UnarmedWeapon
            {
                Id = ID, 
                Name = "Talon"
            };
        }
    }
}
