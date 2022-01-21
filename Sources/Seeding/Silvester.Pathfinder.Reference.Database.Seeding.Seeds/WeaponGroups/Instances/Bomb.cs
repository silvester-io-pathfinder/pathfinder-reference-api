using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Bomb : Template
    {
        public static readonly Guid ID = Guid.Parse("f5a72ab1-3b4b-4687-b0d7-a0190af5b4f5");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Bomb",
                CriticalEffect = "Increase the radius of the bomb's splash damage (if any) to 10 feet."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d13f187-7489-4fc2-8a53-e40db50971be"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
