using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Valet : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Valet", 
                Description = "You can command your familiar to deliver you items more efficiently. Your familiar doesn't use its 2 actions immediately upon your command. Instead, up to twice before the end of your turn, you can have your familiar Interact to retrieve an item of light or negligible Bulk you are wearing and place it into one of your free hands. The familiar can't use this ability to retrieve stowed items. If the familiar has a different number of actions, it can retrieve one item for each action it has when commanded this way."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 147
            };
        }
    }
}
