using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class GroupCoercionFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("ccdd4b23-9813-407e-a7a6-8bc2cdafbab5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Group Coercion",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0482965b-932e-407e-a445-337a78cb3eca"), Type = Utilities.Text.TextBlockType.Text, Text = "When you Coerce, you can compare your Intimidation check result to the Will DCs of two targets instead of one. It’s possible to get a different degree of success for each target. The number of targets you can Coerce in a single action increases to four if you’re an expert, 10 if you’re a master, and 25 if you’re legendary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("1ebd72e0-3e61-42ad-b3b7-8f68c2094de2"), RequiredSkillId = Skills.Instances.Intimidation.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("0407ea05-b8dd-4db0-a643-8d76de565968"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 262
            };
        }
    }
}
