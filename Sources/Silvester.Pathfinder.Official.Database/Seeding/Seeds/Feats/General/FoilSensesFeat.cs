using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class FoilSensesFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("fccdaf8a-46b0-4a18-9a90-dbb228317b58"),
                Name = "Foil Senses",
                Level = 7
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("a36d8e49-5dd2-44c2-acb0-89d69ed09e80"), Text = "You are adept at foiling creatures’ special senses and cautious enough to safeguard against them at all times. Whenever you use the Avoid Notice, Hide, or Sneak actions, you are always considered to be taking precautions against special senses (see the Detecting with Other Senses sidebar on page 465)." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("c8867d56-91ed-416e-9bc3-d2ef213bb3aa"), RequiredSkillId = seeder.GetSkill("Stealth"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
