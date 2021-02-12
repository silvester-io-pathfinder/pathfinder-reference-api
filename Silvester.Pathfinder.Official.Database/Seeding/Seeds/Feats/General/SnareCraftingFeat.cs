using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class SnareCraftingFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("2b952cb7-5972-4866-a8d3-92410b2ed759"),
                Name = "Snare Crafting",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("ab3c5f8b-1cea-4981-b30d-fc1d811fc593"), Text = "You can use the Craft activity to create snares, using the rules from page 244. When you select this feat, you add the formulas for four common snares to your formula book." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("331e4a38-698f-4066-bd28-e42f80b1368d"), RequiredSkillId = seeder.GetSkill("Crafting"), RequiredProficiencyId = seeder.GetProficiency("Trained")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
