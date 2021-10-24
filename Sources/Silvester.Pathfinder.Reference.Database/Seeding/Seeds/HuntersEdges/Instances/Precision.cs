using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HuntersEdges.Instances
{
    public class Precision : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HuntersEdge GetHuntersEdge()
        {
            return new HuntersEdge
            {
                Id = ID, 
                Name = "Precision",
                Description = "You have trained to aim for your prey’s weak points. The first time you hit your hunted prey in a round, you also deal 1d8 additional precision damage. (Precision damage increases the damage you already deal, using the same type, but is ineffective against creatures that lack vital organs or weak points.) At 11th level, the extra damage increases to 2d8 precision damage, and at 19th level, the extra damage increases to 3d8 precision damage."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
