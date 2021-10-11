using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class RiskySurgeryFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("ba22e2ac-3c75-432b-910d-b825aa2c88bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Risky Surgery",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c80337d2-fdbc-4293-ad72-81e42c1f8f96"), Type = TextBlockType.Text, Text = "Your surgery can bring a patient back from the brink of death, but might push them over the edge. When you Treat Wounds, you can deal 1d8 slashing damage to your patient just before applying the effects of Treat Wounds. If you do, you gain a +2 circumstance bonus to your Medicine check to Treat Wounds, and if you roll a success, you get a critical success instead." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite
            {
                Id = Guid.Parse("d94b4cde-c2ef-4c83-93ca-f943ce42415a"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                RequiredSkillId = Skills.Instances.Medicine.ID,
            };
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
                Id = Guid.Parse("d0d1ce22-7017-4650-bd7b-195c6f87577b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 208
            };
        }
    }
}
