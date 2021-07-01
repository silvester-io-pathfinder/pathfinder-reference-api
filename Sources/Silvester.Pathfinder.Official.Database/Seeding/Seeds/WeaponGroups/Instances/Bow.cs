using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Bow : Template
    {
        public static readonly Guid ID = Guid.Parse("ed766d26-c252-4a47-8e6c-44031f691653");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Bow",
                CriticalEffect = "If the target of the critical hit is adjacent to a surface, it gets stuck to that surface by the missile. The target is immobilized and must spend an Interact action to attempt a DC 10 Athletics check to pull the missile free; it can’t move from its space until it succeeds. The creature doesn’t become stuck if it is incorporeal, is liquid (like a water elemental or some oozes), or could otherwise escape without effort."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13185dec-473d-468f-9088-4789da47e099"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
