using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class AncestralParagonFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("1d6f005c-1b19-4072-8609-62af32b427e2"),
                Name = "Ancestral Paragon",
                Level = 3
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db6f1680-f693-4b5c-9dae-16516d0bd65a"), Type = Utilities.Text.TextBlockType.Text, Text = "Whether through instinct, study, or magic, you feel a deeper connection to your ancestry.You gain a 1st - level ancestry feat." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
