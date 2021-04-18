using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class BattleMedicineFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "One Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("6db67ca1-3fef-4705-9ad3-4d0e121e943b"),
                Name = "Battle Medicine",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60f7edf8-b1cd-4a3b-b412-af7a4b880942"), Type = Utilities.Text.TextBlockType.Text, Text = "You can patch up wounds, even in combat. Attempt a Medicine check with the same DC as for Treat Wounds and restore the corresponding amount of HP; this doesn’t remove the wounded condition. As with Treat Wounds, you can attempt checks against higher DCs if you have the minimum proficiency rank. The target is then temporarily immune to your Battle Medicine for 1 day." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("83a915d1-a69b-4a0e-b48f-ce0167b389f9"), RequiredSkillId = seeder.GetSkill("Medicine"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<FeatRequirement> GetRequirements()
        {
            yield return new FeatRequirement { Id = Guid.Parse("1713b28d-8d45-4cfd-a71c-56e903c7eb68"), Text = "You’re holding or wearing healer’s tools (page 209)." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Healing";
            yield return "Manipulate";
            yield return "Skill";
        }
    }
}
