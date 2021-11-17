using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Dart : Template
    {
        public static readonly Guid ID = Guid.Parse("79516d2f-0c2d-47d3-b411-5b02ae26022f");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Dart",
                CriticalEffect = "The target takes 1d6 persistent bleed damage. You gain an item bonus to this bleed damage equal to the weapon’s item bonus to attack rolls."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef30e546-f103-43c0-aa4b-d9f692ebf9ea"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
