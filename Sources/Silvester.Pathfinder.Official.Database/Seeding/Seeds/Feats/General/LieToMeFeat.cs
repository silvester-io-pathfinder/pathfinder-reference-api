using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LieToMeFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("1332e046-d8ea-4a33-9a07-69308317891c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lie to Me",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d1ff363-b4d4-43e3-910c-dac144202e6d"), Type = Utilities.Text.TextBlockType.Text, Text = "You can use Deception to weave traps to trip up anyone trying to deceive you. If you can engage in conversation with someone trying to Lie to you, use your Deception DC if it is higher than your Perception DC to determine whether they succeed. This doesn’t apply if you don’t have a back-and-forth dialogue, such as when someone attempts to Lie during a long speech." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("bf1b0a30-16b8-401c-bc11-83ddb3de79a8"), RequiredSkillId = Skills.Instances.Deception.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
