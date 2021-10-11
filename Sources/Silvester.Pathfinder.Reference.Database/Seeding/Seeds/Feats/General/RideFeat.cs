using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class RideFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("8ee83a83-4763-4423-87ff-c12ef752a494");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ride",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a2ebba7-943f-4b48-87e7-23a5bd5891a4"), Type = Utilities.Text.TextBlockType.Text, Text = "When you Command an Animal you’re mounted on to take a move action (such as Stride), you automatically succeed instead of needing to attempt a check. Any animal you’re mounted on acts on your turn, like a minion. If you Mount an animal in the middle of an encounter, it skips its next turn and then acts on your next turn. Page 249 has more on Command an Animal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd5651ec-8c06-48dc-8a44-9396f4c38de6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 266
            };
        }
    }
}
