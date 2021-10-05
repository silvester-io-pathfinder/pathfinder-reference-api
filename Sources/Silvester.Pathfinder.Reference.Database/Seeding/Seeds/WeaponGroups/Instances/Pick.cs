using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Pick : Template
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
