using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class WallJumpFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("76a68ae1-d7e0-4b2a-af54-4978b06db5cb"),
                Name = "Wall Jump",
                Level = 7
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("8bae76df-a77a-4fb2-a16f-81864f06e55d"), Text = "You can use your momentum from a jump to propel yourself off a wall. If you’re adjacent to a wall at the end of a jump (whether performing a High Jump, Long Jump, or Leap), you don’t fall as long as your next action is another jump. Furthermore, since your previous jump gives you momentum, you can use High Jump or Long Jump as a single action, but you don’t get to Stride as part of the activity." };
            yield return new FeatDetailsBlock { Id = Guid.Parse("2c4b8bac-89f1-45f3-a60a-c6dfbbb00ea1"), Text = "You can use Wall Jump only once in a turn, unless you’re legendary in Athletics, in which case you can use Wall Jump as many times as you can use consecutive jump actions in that turn." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("d0dafb67-0f82-4c67-866f-75ab3b88580f"), RequiredSkillId = seeder.GetSkill("Athletics"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
