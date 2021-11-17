using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class PoisonReservoir : Template
    {
        public static readonly Guid ID = Guid.Parse("785c41f2-348f-4223-bffd-72c24a224789");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Poison Reservoir", 
                Description = "Your homunculus familiar has a reservoir for poison, allowing it to apply an injury poison to an adjacent ally's exposed weapon with a single Interact action. You must supply the poison and instill it into this reservoir using two consecutive Interact actions. You must have a homunculus familiar to select this ability."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a9b0d6b-a674-4abe-ba0b-8f130cd1987b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
