using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class NaturalMedicineFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("c7443dbf-2f52-48df-a53c-8dd6ad6732c0"),
                Name = "Natural Medicine",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("068516d5-9c17-490a-8f75-cf975420ca79"), Text = "You can apply natural cures to heal your allies. You can use Nature instead of Medicine to Treat Wounds. If you’re in the wilderness, you might have easier access to fresh ingredients, allowing you to gain a +2 circumstance bonus to your check to Treat Wounds using Nature, subject to the GM’s determination." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("56bb7cdd-e5b9-4468-b29c-62dc359e7ee3"), RequiredSkillId = seeder.GetSkill("Nature"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
