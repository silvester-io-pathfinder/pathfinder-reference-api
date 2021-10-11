using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class TerrifiedRetreatFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("064e540b-673f-4abb-bacc-fda48911b21a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrified Retreat",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8f33acf-ba7f-4aec-a5e0-962dd317b1f8"), Type = Utilities.Text.TextBlockType.Text, Text = "When you critically succeed at the Demoralize action, if the target’s level is lower than yours, the target is fleeing for 1 round." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("878125cb-4413-4304-826e-2a6f9f1e1351"), RequiredSkillId = Skills.Instances.Intimidation.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID};
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
                Id = Guid.Parse("b6087768-b6e3-48eb-a160-e851b7ad56d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 267
            };
        }
    }
}
