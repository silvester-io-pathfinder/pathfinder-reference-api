using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Shield : Template
    {
        public static readonly Guid ID = Guid.Parse("01553c8f-e4df-449c-8be8-cb8b30e1569d");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Shield",
                CriticalEffect = "You knock the target back from you 5 feet. This is forced movement."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a44b3cbc-55fe-466c-8fec-95e9cff4fcba"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
