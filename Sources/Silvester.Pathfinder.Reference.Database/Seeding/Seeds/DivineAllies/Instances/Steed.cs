using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineAllies.Instances
{
    public class Steed : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DivineAlly GetDivineAlly()
        {
            return new DivineAlly
            {
                Id = ID, 
                Name = "Steed",
                Description = "You gain a young animal companion as a mount. Ordinarily, your animal companion is one that has the mount special ability, such as a horse. You can select a different animal companion (GM's discretion), but this ability doesn't grant it the mount special ability."
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
