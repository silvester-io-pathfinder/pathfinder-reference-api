using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class MagicalCraftingFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("a90aba98-98fe-4a4d-86a6-93025e5d558a"),
                Name = "Magical Crafting",
                Level = 2
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("8667db8e-760b-4b1d-a0b1-559e02a22b15"), Text = "You can Craft magic items, though some have other requirements, as listed in Chapter 11. When you select this feat, you gain formulas for four common magic items of 2nd level or lower." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("388aa336-39bb-4172-afcf-ace1e855ee81"), RequiredSkillId = seeder.GetSkill("Crafting"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
