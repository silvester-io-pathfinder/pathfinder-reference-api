using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class OddityIdentificationFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("f552a716-9e47-457c-a9ec-51fa8cd3a85d"),
                Name = "Oddity Identification",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("947e2872-b7c3-4255-839d-6bde545f65e7"), Text = "You have a sense for spells that twist minds or reveal secrets. You gain a +2 circumstance bonus to Occultism checks to Identify Magic with the mental, possession, prediction, or scrying traits." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("61cadcf1-7ecf-43fc-b421-523f0afa57f8"), RequiredSkillId = seeder.GetSkill("Occultism"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
