using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class AssuranceFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("e4c0f632-f086-40f7-81c4-2d54f1bcb5b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assurance",
                Level = 1,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time, choose a different skill and gain the benefits for that skill.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ed675fc-6c30-4ded-a479-961f8bdd3227"), Type = TextBlockType.Text, Text = "Even in the worst circumstances, you can perform basic tasks. Choose a skill you’re trained in. You can forgo rolling a skill check for that skill to instead receive a result of 10 + your proficiency bonus (do not apply any other bonuses, penalties, or modifiers)." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("79c0f62e-189b-4c8f-b18c-349f2f4237eb"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef33c35c-df1e-4dbc-a3c3-118d5f2f54fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 258
            };
        }
    }
}
