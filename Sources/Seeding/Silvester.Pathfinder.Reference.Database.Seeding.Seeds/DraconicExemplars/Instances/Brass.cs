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
    public class Brass : Template
    {
        public static readonly Guid ID = Guid.Parse("af05e094-0452-408c-97ab-125ce5857f33");
        
        protected override DraconicExemplar GetDraconicExemplar()
        {
            return new DraconicExemplar
            {
                Id = ID, 
                Dragon = "Brass",
                EffectShapeId = EffectShapes.Instances.Line.ID,
                DamageTypeId = DamageTypes.Instances.Fire.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95adabd8-8876-4e9f-96f6-45ed6946ca14"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 13
            };
        }
    }
}
