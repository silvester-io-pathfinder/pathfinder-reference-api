using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.EffectShapes.Instances
{
    public class Burst : Template
    {
        public static readonly Guid ID = Guid.Parse("0e37b810-a9aa-4720-8d13-972cc8fa7e2a");
        
        protected override EffectShape GetEffectShape()
        {
            return new EffectShape
            {
                Id = ID, 
                Name = "Burst",
            };
        }
    }
}
