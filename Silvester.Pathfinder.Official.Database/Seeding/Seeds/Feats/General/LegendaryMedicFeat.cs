using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryMedicFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("c041f814-94c4-43a1-be45-3bcd2621f2bb"),
                Name = "Legendary Medic",
                Level = 15
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("af297ffe-fd7d-42b4-93b4-05f79cc46251"), Text = "You’ve discovered medical breakthroughs or techniques that achieve miraculous results. Once per day for each target, you can spend 1 hour treating that target and attempt a Medicine check to remove a disease or the blinded, deafened, doomed, or drained condition. Use the DC of the disease or of the spell or effect that created the condition. If the effect’s source is an artifact, above 20th level, or similarly powerful, increase the DC by 10." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("bd212e0a-63fd-42fc-a012-3d56ceb4d822"), RequiredSkillId = seeder.GetSkill("Medicine"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
