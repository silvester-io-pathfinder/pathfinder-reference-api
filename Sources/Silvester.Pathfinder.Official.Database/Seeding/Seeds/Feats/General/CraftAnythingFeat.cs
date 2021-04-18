using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class CraftAnythingFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("2fbc54de-6f02-49d5-a01c-6adfd732a81e"),
                Name = "Craft Anything",
                Level = 15
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c729dd0c-a2bf-44f0-9d2a-7ff744c09b26"), Type = Utilities.Text.TextBlockType.Text, Text = "You can find ways to craft just about anything, despite restrictions. As long as you have the appropriate Crafting skill feat (such as Magical Crafting for magic items) and meet the item’s level and proficiency requirement, you ignore just about any other requirement, such as being of a specific ancestry or providing spells. The only exceptions are requirements that add to the item’s cost, including castings of spells that themselves have a cost, and requirements of special items such as the philosopher’s stone that have exclusive means of access and Crafting. The GM decides whether you can ignore a requirement." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("701fc8e3-f113-4fcb-b2bb-1e98a70060bc"), RequiredSkillId = seeder.GetSkill("Crafting"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
