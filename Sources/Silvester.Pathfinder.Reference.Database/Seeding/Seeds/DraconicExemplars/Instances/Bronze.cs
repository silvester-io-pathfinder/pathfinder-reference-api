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
    public class Bronze : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DraconicExemplar GetDraconicExemplar()
        {
            return new DraconicExemplar
            {
                Id = ID, 
                Dragon = "Bronze",
                EffectAreaId = EffectAreas.Instances.Line.ID,
                DamageTypeId = DamageTypes.Instances.Electricity.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 13
            };
        }
    }
}
