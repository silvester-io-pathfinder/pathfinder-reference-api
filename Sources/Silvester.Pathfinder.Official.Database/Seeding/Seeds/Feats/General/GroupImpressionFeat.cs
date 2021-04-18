using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class GroupImpressionFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("738f86de-6f73-4ffa-a790-abd8feeb43c5"),
                Name = "Group Impression",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7dd54aeb-9180-4509-ac60-9d9f31b4d9c9"), Type = Utilities.Text.TextBlockType.Text, Text = "When you Make an Impression, you can compare your Diplomacy check result to the Will DCs of two targets instead of one. It’s possible to get a different degree of success for each target. The number of targets increases to four if you’re an expert, 10 if you’re a master, and 25 if you’re legendary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("c591078d-1a92-40eb-a7b9-611748799608"), RequiredSkillId = seeder.GetSkill("Diplomacy"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
