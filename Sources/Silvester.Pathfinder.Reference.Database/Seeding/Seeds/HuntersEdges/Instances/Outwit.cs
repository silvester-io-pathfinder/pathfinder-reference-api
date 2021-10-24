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
    public class Outwit : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override HuntersEdge GetHuntersEdge()
        {
            return new HuntersEdge
            {
                Id = ID, 
                Name = "Outwit",
                Description = "You are talented at outwitting and evading your prey. You gain a +2 circumstance bonus to Deception checks, Intimidation checks, Stealth checks, and any checks to Recall Knowledge about the prey, and a +1 circumstance bonus to AC against your prey’s attacks."
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
