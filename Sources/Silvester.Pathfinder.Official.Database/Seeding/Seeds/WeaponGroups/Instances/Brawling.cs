using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Brawling : Template
    {
        public static readonly Guid ID = Guid.Parse("55158194-ce53-4931-818b-5c36289e4dba");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Brawling",
                CriticalEffect = "The target must succeed at a Fortitude save against your class DC or be slowed 1 until the end of your next turn."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4da27636-f6de-4c20-8d3c-ea1806d8bace"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
