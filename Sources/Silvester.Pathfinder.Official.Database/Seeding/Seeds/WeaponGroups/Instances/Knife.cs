using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Knife : Template
    {
        public static readonly Guid ID = Guid.Parse("b50c2993-dcd3-4379-9b32-8bd6b9dff973");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Knife",
                CriticalEffect = "The target takes 1d6 persistent bleed damage. You gain an item bonus to this bleed damage equal to the weapon’s item bonus to attack rolls."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37932381-100d-4cc9-9e6b-c6701b919705"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
