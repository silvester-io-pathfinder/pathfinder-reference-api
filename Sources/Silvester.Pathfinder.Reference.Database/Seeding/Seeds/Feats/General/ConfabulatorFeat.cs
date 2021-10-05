using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ConfabulatorFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("38b0c4f7-2ad6-4c04-928d-dc53f2ff39b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Confabulator",
                Level = 2,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2084aa10-37e6-4665-b379-32a1c378e09e"), Type = Utilities.Text.TextBlockType.Text, Text = "Even when caught in falsehoods, you pile lie upon lie. Reduce the circumstance bonus a target gains for your previous attempts to Create a Diversion or Lie to it from +4 to +2. If you’re a master in Deception, reduce the bonus to +1, and if you’re legendary, your targets don’t get these bonuses at all." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("89f13323-62f1-4f79-ae26-dfb3dd7edeec"), RequiredSkillId = Skills.Instances.Deception.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
