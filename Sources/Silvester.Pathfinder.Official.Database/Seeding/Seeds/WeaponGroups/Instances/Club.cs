using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Club : Template
    {
        public static readonly Guid ID = Guid.Parse("b43977e7-788a-4a38-be49-2ed575e74362");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Club",
                CriticalEffect = "You knock the target away from you up to 10 feet (you choose the distance). This is forced movement."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af9b1037-1d63-4bd5-b3ac-18594e8ec42a"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
