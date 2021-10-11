using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class GladHandFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("6f59e2f4-2100-436d-8cf8-266585faa937");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glad-Hand",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0c298c6-63be-431c-80e9-5a95ec712f73"), Type = Utilities.Text.TextBlockType.Text, Text = "First impressions are your strong suit. When you meet someone in a casual or social situation, you can immediately attempt a Diplomacy check to Make an Impression on that creature rather than needing to converse for 1 minute. You take a –5 penalty to the check. If you fail or critically fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("0a89ce88-3517-439b-8149-414aa59fbd80"), RequiredSkillId = Skills.Instances.Diplomacy.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
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
                Id = Guid.Parse("4fdb3c7b-5813-4355-8adb-c85f59841105"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 261
            };
        }
    }
}
