using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances
{
    public class Flail : Template
    {
        public static readonly Guid ID = Guid.Parse("708c03ec-921c-4296-8a96-4b48e8c48245");

        protected override WeaponGroup GetWeaponGroup()
        {
            return new WeaponGroup
            {
                Id = ID,
                Name = "Flail",
                CriticalEffect = "The target is knocked prone."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07214271-97e3-4978-bcf6-5820a660fd4c"),
                SourceId = CoreRulebook.ID,
                Page = 284
            };
        }
    }
}
