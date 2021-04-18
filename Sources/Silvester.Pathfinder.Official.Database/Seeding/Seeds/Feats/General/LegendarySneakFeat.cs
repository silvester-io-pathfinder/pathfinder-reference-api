using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LegendarySneakFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("ff4b4b20-73c2-4a67-a1a5-e504c8aa2dc6"),
                Name = "Legendary Sneak",
                Level = 15
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e989ca3-733a-4120-aa84-aaba3aa053f8"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re always sneaking unless you choose to be seen, even when there’s nowhere to hide. You can Hide and Sneak even without cover or being concealed. When you employ an exploration tactic other than Avoiding Notice, you also gain the benefits of Avoiding Notice unless you choose not to. See page 479 for more information about exploration tactics." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("9e063be7-70e3-495c-a14b-42ccfeb7ba35"), RequiredSkillId = seeder.GetSkill("Stealth"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
            yield return new FeatPrerequisite { Id = Guid.Parse("fe2db99c-0cb7-491a-bf8c-edcf43c84c46"), RequiredFeatId = SwiftSneakFeat.ID };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
