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
    public class Line : Template
    {
        public static readonly Guid ID = Guid.Parse("738fd960-231e-495d-ba27-199e178f4279");
        
        protected override EffectArea GetEffectArea()
        {
            return new EffectArea
            {
                Id = ID, 
                Name = "Line",
            };
        }
    }
}
