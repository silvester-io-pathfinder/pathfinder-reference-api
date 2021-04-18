using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ToughnessFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("5fec7506-9390-4455-83ed-fc3666ca4fa2"),
                Name = "Toughness",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76c25d32-da2f-4db2-af66-56b8b3542db9"), Type = Utilities.Text.TextBlockType.Text, Text = "You can withstand more punishment than most before succumbing. Increase your maximum Hit Points by your level. You reduce the DC of recovery checks by 1 (page 459)." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
