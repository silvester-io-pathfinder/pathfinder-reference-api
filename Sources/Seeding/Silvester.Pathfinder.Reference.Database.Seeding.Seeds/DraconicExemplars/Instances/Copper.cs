using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DraconicExemplars.Instances
{
    public class Copper : Template
    {
        public static readonly Guid ID = Guid.Parse("c78d3fa9-37ad-4b4f-bdca-12dc50bfc975");
        
        protected override DraconicExemplar GetDraconicExemplar()
        {
            return new DraconicExemplar
            {
                Id = ID, 
                Dragon = "Copper",
                EffectShapeId = EffectShapes.Instances.Line.ID,
                DamageTypeId = DamageTypes.Instances.Acid.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("470a2721-806f-4cbb-9966-8b87e498ee21"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 13
            };
        }
    }
}
