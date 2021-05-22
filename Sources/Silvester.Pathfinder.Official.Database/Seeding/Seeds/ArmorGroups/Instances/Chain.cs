using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class Chain : Template
    {
        public static readonly Guid ID = Guid.Parse("abd3005a-9803-4d55-9d51-3ff92bc49ee7");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup
            {
                Id = ID,
                Name = "Chain",
                ArmorSpecializationEffect = "The armor is so flexible it can bend with a critical hit and absorb some of the blow. Reduce the damage from critical hits by either 4 + the value of the armor’s potency rune for medium armor, or 6 + the value of the armor’s potency rune for heavy armor. This can’t reduce the damage to less than the damage rolled for the hit before doubling for a critical hit."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84067774-efc8-4ba0-b924-ffcda0592a6f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
