using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class AssuranceFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("e4c0f632-f086-40f7-81c4-2d54f1bcb5b9"),
                Name = "Assurance",
                Level = 1,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time, choose a different skill and gain the benefits for that skill."
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("1ed675fc-6c30-4ded-a479-961f8bdd3227"), Text = "Even in the worst circumstances, you can perform basic tasks. Choose a skill you’re trained in. You can forgo rolling a skill check for that skill to instead receive a result of 10 + your proficiency bonus (do not apply any other bonuses, penalties, or modifiers)." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("79c0f62e-189b-4c8f-b18c-349f2f4237eb"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
            yield return "Fortune";
        }
    }
}
