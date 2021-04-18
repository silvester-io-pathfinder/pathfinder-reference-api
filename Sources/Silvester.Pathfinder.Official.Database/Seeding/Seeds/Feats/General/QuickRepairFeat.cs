using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickRepairFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("48c371fb-6e9c-4d4f-965d-d56694b52100"),
                Name = "Quick Repair",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79f8ff8b-a14d-4621-ab56-df66be388a38"), Type = Utilities.Text.TextBlockType.Text, Text = "You take 1 minute to Repair an item. If you’re a master in Crafting, it takes 3 actions. If you’re legendary, it takes 1 action." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("850cf013-7103-4c37-8bb9-b1a66c3fb583"), RequiredSkillId = seeder.GetSkill("Crafting"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
