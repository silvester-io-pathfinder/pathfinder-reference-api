using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineAllies.Instances
{
    public class Steed : Template
    {
        public static readonly Guid ID = Guid.Parse("ad6e4191-b85b-49c8-8c47-1874182f1e9b");
        
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
                Id = Guid.Parse("7c1c36ef-ef3f-4d7f-9a51-12816767bfd1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
