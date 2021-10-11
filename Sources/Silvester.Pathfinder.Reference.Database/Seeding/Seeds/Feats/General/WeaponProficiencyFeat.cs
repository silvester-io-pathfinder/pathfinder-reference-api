using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class WeaponProficiencyFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("8b9edbcc-05ce-4df7-bc51-910ff6be643d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Weapon Proficiency",
                Level = 1,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time you do, you become trained in additional weapons as appropriate, following the above progression.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("485c9894-7bac-4b39-a277-004d316976ae"), Type = Utilities.Text.TextBlockType.Text, Text = "You become trained in all simple weapons. If you were already trained in all simple weapons, you become trained in all martial weapons. If you were already trained in all martial weapons, you become trained in one advanced weapon of your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00720f4b-275a-4782-80d4-1eaf500d60fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 269
            };
        }
    }
}
