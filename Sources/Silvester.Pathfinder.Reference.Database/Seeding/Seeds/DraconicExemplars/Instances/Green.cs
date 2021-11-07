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
    public class Green : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DraconicExemplar GetDraconicExemplar()
        {
            return new DraconicExemplar
            {
                Id = ID, 
                Dragon = "Green",
                EffectAreaId = EffectAreas.Instances.Cone.ID,
                DamageTypeId = DamageTypes.Instances.Poison.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
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
