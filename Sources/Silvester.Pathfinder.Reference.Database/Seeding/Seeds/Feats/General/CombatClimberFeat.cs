using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class CombatClimberFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("269b8813-ba84-42c6-9b73-11de579797bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combat Climber",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2d3b438-cbb4-43c2-88c1-3903570434c4"), Type = TextBlockType.Text, Text = "Your techniques allow you to fight as you climb. You’re not flat-footed while Climbing and can Climb with a hand occupied. You must still use another hand and both legs to Climb." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("b25cd8ca-09c2-421c-9fba-b012a04e9085"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("b3610fdd-73d0-4c90-bb75-49367d7ba2fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 260
            };
        }
    }
}
