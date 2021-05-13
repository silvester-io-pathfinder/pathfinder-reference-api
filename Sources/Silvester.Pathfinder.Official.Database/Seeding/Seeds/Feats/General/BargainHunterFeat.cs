using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class BargainHunterFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("6684d89b-1994-4fa9-8b6b-c5123b642e86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bargain Hunter",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46646590-2516-4adb-9ae5-7c050520e480"), Type = Utilities.Text.TextBlockType.Text, Text = "You can Earn Income (page 236) using Diplomacy, spending your days hunting for bargains and reselling at a profit. You can also spend time specifically sniffing out a great bargain on an item; this works as if you were using Earn Income with Diplomacy, except instead of gaining money, you purchase the item at a discount equal to the money you would have gained, gaining the item for free if your earned income equals or exceeds its cost. Finally, if you select Bargain Hunter during character creation at 1st level, you start play with an additional 2 gp." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("076dadf7-1f3a-450a-9a4b-360c571f6070"), RequiredSkillId = Skills.Instances.Diplomacy.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
