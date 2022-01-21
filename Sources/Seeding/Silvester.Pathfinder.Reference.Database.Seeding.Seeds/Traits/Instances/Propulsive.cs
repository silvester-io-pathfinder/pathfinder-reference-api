using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Propulsive : Template
    {
        public static readonly Guid ID = Guid.Parse("9861aaf3-7681-4ed7-9fca-733c0a8b9ad1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Propulsive",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("171c0549-30b0-480a-8e03-4b43539a01f5"), Type = TextBlockType.Text, Text = "You add half your Strength modifier (if positive) to damage rolls with a propulsive ranged weapon. If you have a negative Strength modifier, you add your full Strength modifier instead." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0c2a69a-6055-4fa0-82e5-9ceef80855b6"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
