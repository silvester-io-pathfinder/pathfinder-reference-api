using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class UnderwaterMarauderFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("dfb5e49e-df3e-443e-bfbf-d41e042306ed"),
                Name = "Underwater Marauder",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("55213e09-5320-4baa-9324-35e22eb06496"), Text = "You’ve learned to fight underwater. You are not flat-footed while in water, and you don’t take the usual penalties for using a bludgeoning or slashing melee weapon in water." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("52574087-b011-4c5b-9fcb-6e22f11c6091"), RequiredSkillId = seeder.GetSkill("Athletics"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
