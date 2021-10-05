using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Axe : Template
    {
        public static readonly Guid ID = Guid.Parse("efc95190-6796-43f8-a457-743c988a0c3b");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Axe",
                CriticalEffect = "Choose one creature adjacent to the initial target and within reach. If its AC is lower than your attack roll result for the critical hit, you deal damage to that creature equal to the result of the weapon damage die you rolled (including extra dice for its potency rune, if any). This amount isn’t doubled, and no bonuses or other additional dice apply to this damage."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c05cfd3c-0e8b-49aa-8f8c-ca35c30e5f53"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
