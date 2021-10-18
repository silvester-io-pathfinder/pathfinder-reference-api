using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendarySneakFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("ff4b4b20-73c2-4a67-a1a5-e504c8aa2dc6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Sneak",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e989ca3-733a-4120-aa84-aaba3aa053f8"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re always sneaking unless you choose to be seen, even when there’s nowhere to hide. You can Hide and Sneak even without cover or being concealed. When you employ an exploration tactic other than Avoiding Notice, you also gain the benefits of Avoiding Notice unless you choose not to. See page 479 for more information about exploration tactics." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("9e063be7-70e3-495c-a14b-42ccfeb7ba35"), RequiredSkillId = Skills.Instances.Stealth.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
            yield return new HaveSpecificFeatPrerequisite { Id = Guid.Parse("fe2db99c-0cb7-491a-bf8c-edcf43c84c46"), RequiredFeatId = SwiftSneakFeat.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c06eadf5-e78f-409e-b0d1-1209a172f418"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 263
            };
        }
    }
}
