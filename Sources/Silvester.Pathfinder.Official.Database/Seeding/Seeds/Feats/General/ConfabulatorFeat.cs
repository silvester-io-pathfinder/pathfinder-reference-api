using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ConfabulatorFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("38b0c4f7-2ad6-4c04-928d-dc53f2ff39b7"),
                Name = "Confabulator",
                Level = 2
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2084aa10-37e6-4665-b379-32a1c378e09e"), Type = Utilities.Text.TextBlockType.Text, Text = "Even when caught in falsehoods, you pile lie upon lie. Reduce the circumstance bonus a target gains for your previous attempts to Create a Diversion or Lie to it from +4 to +2. If you’re a master in Deception, reduce the bonus to +1, and if you’re legendary, your targets don’t get these bonuses at all." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("89f13323-62f1-4f79-ae26-dfb3dd7edeec"), RequiredSkillId = seeder.GetSkill("Deception"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
