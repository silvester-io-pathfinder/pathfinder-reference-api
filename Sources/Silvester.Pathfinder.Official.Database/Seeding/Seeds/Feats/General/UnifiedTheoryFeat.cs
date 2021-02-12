using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class UnifiedTheoryFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("ce1dc7c1-c529-42a2-a2f5-f6ca99df1804"),
                Name = "Unified Theory",
                Level = 15
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("c53778be-16f6-4284-9f86-328a4191a823"), Text = "You’ve started to make a meaningful connection about the common underpinnings of the four traditions of magic and magical essences, allowing you to understand them all through an arcane lens. Whenever you use a skill action or a skill feat that requires a Nature, Occultism, or Religion check, depending on the magic tradition, you can use Arcana instead. If you would normally take a penalty or have a higher DC for using Arcana on other magic (such as when using Identify Magic), you no longer do so." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("3bf369c3-0238-4948-9eee-6c951a87ae80"), RequiredSkillId = seeder.GetSkill("Arcana"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
