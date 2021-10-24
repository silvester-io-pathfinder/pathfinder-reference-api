using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineAllies.Instances
{
    public class Shield : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DivineAlly GetDivineAlly()
        {
            return new DivineAlly
            {
                Id = ID, 
                Name = "Shield",
                Description = "A spirit of protection dwells within your shield. In your hands, the shield's Hardness increases by 2 and its HP and BT increase by half."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
