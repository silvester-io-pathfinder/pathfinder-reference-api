using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class WeaponProficiencyFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("8b9edbcc-05ce-4df7-bc51-910ff6be643d"),
                Name = "Weapon Proficiency",
                Level = 1,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time you do, you become trained in additional weapons as appropriate, following the above progression."
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("485c9894-7bac-4b39-a277-004d316976ae"), Text = "You become trained in all simple weapons. If you were already trained in all simple weapons, you become trained in all martial weapons. If you were already trained in all martial weapons, you become trained in one advanced weapon of your choice." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
