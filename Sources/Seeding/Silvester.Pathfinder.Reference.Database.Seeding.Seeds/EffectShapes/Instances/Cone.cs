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
    public class Cone : Template
    {
        public static readonly Guid ID = Guid.Parse("db900233-b4fe-443e-be72-7e3d2ac667ca");
        
        protected override EffectShape GetEffectShape()
        {
            return new EffectShape
            {
                Id = ID, 
                Name = "Cone",
            };
        }
    }
}
