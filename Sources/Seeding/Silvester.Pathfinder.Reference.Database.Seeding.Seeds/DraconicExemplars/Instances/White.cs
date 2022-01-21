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
    public class White : Template
    {
        public static readonly Guid ID = Guid.Parse("b113b618-a891-417a-ade6-2c30837d00c5");
        
        protected override DraconicExemplar GetDraconicExemplar()
        {
            return new DraconicExemplar
            {
                Id = ID, 
                Dragon = "White",
                EffectShapeId = EffectShapes.Instances.Cone.ID,
                DamageTypeId = DamageTypes.Instances.Cold.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49983cc0-b2fe-484a-bbae-2b06d78db7ab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 13
            };
        }
    }
}
