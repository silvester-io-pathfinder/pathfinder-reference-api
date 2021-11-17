using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class TouchTelepathy : Template
    {
        public static readonly Guid ID = Guid.Parse("bade4a66-22b6-4fa4-9f6f-0b2f06e7e7cf");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Touch Telepathy", 
                Description = "Your familiar can telepathically communicate with you via touch. If it also has the speech ability, it can telepathically communicate via touch with any creature if they share a language."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6ed94e9-7715-47be-87e2-73a2960d6d55"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
