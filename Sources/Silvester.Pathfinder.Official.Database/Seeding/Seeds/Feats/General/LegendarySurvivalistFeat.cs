using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LegendarySurvivalistFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("d264d400-645f-4e7e-8100-ae5b2caf9e0e"),
                Name = "Legendary Survivalist",
                Level = 15
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("308d6b71-ee1c-4e7b-b3b5-1ef198b64205"), Type = Utilities.Text.TextBlockType.Text, Text = "You can survive indefinitely without food or water and can endure severe, extreme, and incredible cold and heat without taking damage from doing so." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("8d68493f-4f66-4ebb-aa54-c5fed2ae86b6"), RequiredSkillId = seeder.GetSkill("Survival"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
