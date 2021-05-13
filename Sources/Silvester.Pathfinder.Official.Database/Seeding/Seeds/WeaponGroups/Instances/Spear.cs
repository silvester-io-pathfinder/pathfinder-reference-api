using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Spear : Template
    {
        public static readonly Guid ID = Guid.Parse("2a230c64-c4ef-4f84-ac75-a285f53bf115");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Spear",
                CriticalEffect = "The weapon pierces the target, weakening its attacks. The target is clumsy 1 until the start of your next turn."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("959a550b-9440-493a-8e31-eaa6df2e5127"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
