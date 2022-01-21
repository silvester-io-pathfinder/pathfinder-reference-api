using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Environmental : Template
    {
        public static readonly Guid ID = Guid.Parse("2f66206a-becd-4280-9a14-df7feebd834d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Environmental",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("436b528e-849e-4d26-b39e-684ec6fe5eeb"), Type = TextBlockType.Text, Text = "A hazard with this trait is something dangerous that's part of the natural world, such as quicksand or harmful mold." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c04aa04-c9b1-4b81-8b80-92b16c40f704"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
