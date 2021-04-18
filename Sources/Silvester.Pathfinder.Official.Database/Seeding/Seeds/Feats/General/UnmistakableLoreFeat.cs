using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class UnmistakableLoreFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("eb5ca078-b3f2-4e84-8df4-526ced138637"),
                Name = "Unmistabable Lore",
                Level = 2
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95e082e4-1262-4fa5-8937-a0bf794053eb"), Type = Utilities.Text.TextBlockType.Text, Text = "You never get information about your areas of expertise wrong. When you Recall Knowledge using any Lore subcategory in which you’re trained, if you roll a critical failure, you get a failure instead. If you’re a master in a Lore subcategory, on a critical success, you gain even more information or context than usual." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new LorePrerequisite { Id = Guid.Parse("121e5838-bd62-46a7-a282-3e096dd7d271"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
