using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class TitanWrestlerFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("fee17526-90f5-401c-bdec-d084f40852a7"),
                Name = "Titan Wrestler",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("0a652425-e8de-4a6d-83e8-523505d4f747"), Text = "You can attempt to Disarm, Grapple, Shove, or Trip creatures up to two sizes larger than you, or up to three sizes larger than you if you’re legendary in Athletics." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("063735a0-a7f9-4165-aa97-74c04557ae1f"), RequiredSkillId = seeder.GetSkill("Athletics"), RequiredProficiencyId = seeder.GetProficiency("Trained")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
