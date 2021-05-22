using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Sling : Template
    {
        public static readonly Guid ID = Guid.Parse("92c0ebe3-618f-45e8-b9e2-cbd47a96ea96");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Sling",
                CriticalEffect = "The target must succeed at a Fortitude save against your class DC or be stunned 1."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46e50f08-f9eb-48a9-8b34-6193132a526a"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
