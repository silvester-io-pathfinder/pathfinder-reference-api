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
    public class Quill : Template
    {
        public static readonly Guid ID = Guid.Parse("02ce6e20-054e-4a77-8059-98d65c47232c");
        
        protected override UnarmedWeapon GetUnarmedWeapon()
        {
            return new UnarmedWeapon
            {
                Id = ID, 
                Name = "Quill"
            };
        }
    }
}
