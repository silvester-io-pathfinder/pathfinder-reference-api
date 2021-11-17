using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Accompanist : Template
    {
        public static readonly Guid ID = Guid.Parse("f2436d5a-c1f1-4f1b-aad1-025f654cac38");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Accompanist", 
                Description = "Your familiar helps you perform. Whenever you attempt a Performance check, if your familiar is nearby and can act, it accompanies you with chirps, claps, or its own miniature instrument. This grants you a +1 circumstance bonus, or +2 if you're a master in Performance."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1059f4a1-bd33-4ebe-995a-f50180fad7bf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
