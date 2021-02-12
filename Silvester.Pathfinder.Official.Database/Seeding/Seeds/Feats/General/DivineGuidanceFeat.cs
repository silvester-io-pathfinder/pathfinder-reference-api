using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class DivineGuidanceFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("17f35e0f-3778-4143-b516-d08faf79bc68"),
                Name = "Divine Guidance",
                Level = 15
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("538628da-6b39-455a-919a-7b2d8de5ff61"), Text = "You’re so immersed in divine scripture that you find meaning and guidance in your texts in any situation. Spend 10 minutes Deciphering Writing on religious scriptures of your deity or philosophy while thinking about a particular problem or conundrum you face, and then attempt a Religion check (DC determined by the GM). If you succeed, you unearth a relevant passage, parable, or aphorism that can help you move forward or change your thinking to help solve your conundrum. For example, the GM might provide you with a cryptic poem or hint that can guide you to the next step of solving your problem." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("bfeb1d14-08a6-4121-b836-2f4f76339d3e"), RequiredSkillId = seeder.GetSkill("Religion"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
