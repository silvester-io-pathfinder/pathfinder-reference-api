using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Paralyzed : Template
    {
        public static readonly Guid ID = Guid.Parse("5007c3b2-b184-43b1-85d7-ad159d14ccb5");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Paralyzed",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ecf6343-5513-4313-817c-2fee4c074167"), Type = Utilities.Text.TextBlockType.Text, Text = "You are frozen in place. You have the flat-footed condition and can’t act except to Recall Knowledge and use actions that require only your mind (as determined by the GM). Your senses still function, but only in the areas you can perceive without moving, so you can’t Seek while paralyzed." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17810441-9218-4e9d-a962-1e7697516b2d"),
                SourceId = CoreRulebook.ID,
                Page = 621
            };
        }
    }
}
