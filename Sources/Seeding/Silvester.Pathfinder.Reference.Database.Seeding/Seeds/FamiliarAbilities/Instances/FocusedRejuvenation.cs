using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class FocusedRejuvenation : Template
    {
        public static readonly Guid ID = Guid.Parse("4272ba4c-8150-46ab-b2cd-a16b87fb1529");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Focused Rejuvenation", 
                Description = "When you Refocus, you generate magical energy that heals your familiar. Your familiar regains 1 Hit Point per level whenever you Refocus."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec6f91a9-9d0c-493d-ac3f-cfc83f27859e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
