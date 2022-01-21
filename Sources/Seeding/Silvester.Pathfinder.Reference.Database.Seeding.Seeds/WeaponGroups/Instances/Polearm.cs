using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Polearm : Template
    {
        public static readonly Guid ID = Guid.Parse("edfa81fd-1aca-46de-a75b-deb0465712ad");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Polearm",
                CriticalEffect = "The target is moved 5 feet in a direction of your choice. This is forced movement."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90e5aac2-6b2e-49a0-a2c2-93e8009d194b"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
