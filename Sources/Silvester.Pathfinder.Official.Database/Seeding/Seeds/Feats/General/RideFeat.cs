using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class RideFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("8ee83a83-4763-4423-87ff-c12ef752a494"),
                Name = "Ride",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a2ebba7-943f-4b48-87e7-23a5bd5891a4"), Type = Utilities.Text.TextBlockType.Text, Text = "When you Command an Animal you’re mounted on to take a move action (such as Stride), you automatically succeed instead of needing to attempt a check. Any animal you’re mounted on acts on your turn, like a minion. If you Mount an animal in the middle of an encounter, it skips its next turn and then acts on your next turn. Page 249 has more on Command an Animal." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
