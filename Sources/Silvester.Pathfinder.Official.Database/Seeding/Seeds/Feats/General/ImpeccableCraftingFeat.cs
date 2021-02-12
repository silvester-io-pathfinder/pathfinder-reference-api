using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ImpeccableCraftingFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("89921651-065e-48f8-98cb-c9b6cf6c71e9"),
                Name = "Impeccable Crafting",
                Level = 7
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("6b5087c0-7e76-445c-966e-7a50f572448f"), Text = "You craft flawless creations with great efficiency. Whenever you roll a success at a Crafting check to make an item of the type you chose with Specialty Crafting, you get a critical success instead." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("04f0104f-5c14-447e-95b4-cfaaba3f4cbc"), RequiredSkillId = seeder.GetSkill("Crafting"), RequiredProficiencyId = seeder.GetProficiency("Master") };
            yield return new FeatPrerequisite { Id = Guid.Parse("60c37f30-39dd-4fb1-9ecc-3ad80b2ab3ef"), RequiredFeatId = SpecialtyCraftingFeat.ID };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
