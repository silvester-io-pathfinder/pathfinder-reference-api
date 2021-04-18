using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class FeatherStepFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("174c21f8-b29a-4141-9070-eca5ecfdee71"),
                Name = "Feather Step",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a59de26-a216-4f4f-b81f-094eb8998249"), Type = Utilities.Text.TextBlockType.Text, Text = "You step carefully and quickly. You can Step into difficult terrain." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new StatPrerequisite { Id = Guid.Parse("276c32c0-d4b4-468b-bd7d-3faa635a76b6"), RequiredStatValue = 14, RequiredStatId = seeder.GetStat("Dexterity") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
