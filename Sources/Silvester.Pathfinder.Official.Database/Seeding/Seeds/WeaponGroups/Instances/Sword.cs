using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Sword : AbstractWeaponGroupTemplate
    {
        public static readonly Guid ID = Guid.Parse("d8d3f1e4-f414-4b0b-889e-e7cf91cd1370");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Sword",
                CriticalEffect = "The target is made off-balance by your attack, becoming flat-footed until the start of your next turn."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f18bfafa-141d-4bc9-b8f4-6113b12080f8"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
