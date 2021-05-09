using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Pick : AbstractWeaponGroupTemplate
    {
        public static readonly Guid ID = Guid.Parse("1c0f6d9d-1473-4505-8aa5-819a7fb94220");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Pick",
                CriticalEffect = "The weapon viciously pierces the target, who takes 2 additional damage per weapon damage die."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9b50137-8062-4ad4-9610-4dedde9b4e0c"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
