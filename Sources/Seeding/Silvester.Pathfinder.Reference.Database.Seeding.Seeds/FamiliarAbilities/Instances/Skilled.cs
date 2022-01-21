using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Skilled : Template
    {
        public static readonly Guid ID = Guid.Parse("133eb8bc-ebf7-42e0-bc88-45550b4fa0c7");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Skilled", 
                Description = "Choose a skill other than Acrobatics or Stealth. Your familiar's modifier for that skill is equal to your level plus your key spellcasting ability modifier, rather than just your level. You can select this ability repeatedly, choosing a different skill each time."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a2eaf9d-09e1-4dc6-bb13-605bed3c2779"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
