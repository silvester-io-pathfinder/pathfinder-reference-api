using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.EffectAreas.Instances
{
    public class Emanation : Template
    {
        public static readonly Guid ID = Guid.Parse("74ab4ddc-0011-49be-8440-2aa28dcd8a2f");
        
        protected override EffectArea GetEffectArea()
        {
            return new EffectArea
            {
                Id = ID, 
                Name = "Emanation",
            };
        }
    }
}
