using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class BattleCryFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("5ac7371e-af01-460e-a188-198481c67505");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battle Cry",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1fe89bb7-ca01-4a5f-9d34-8699b45c9829"), Type = Utilities.Text.TextBlockType.Text, Text = "When you roll initiative, you can yell a mighty battle cry and Demoralize an observed foe as a free action. If you’re legendary in Intimidation, you can use a reaction to Demoralize your foe when you critically succeed at an attack roll." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("d1f28e19-88e4-4a8e-969a-581b93527bc7"), RequiredSkillId = Skills.Instances.Intimidation.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
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
                Id = Guid.Parse("a6c1c329-5e27-40b0-961f-bf3a23479fa8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 258
            };
        }
    }
}
