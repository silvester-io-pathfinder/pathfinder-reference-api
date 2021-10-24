using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Comfort : Template
    {
        public static readonly Guid ID = Guid.Parse("42f8d547-7951-47ed-ad66-7ba48e750e78");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Comfort",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39a56dd6-0d2c-4e75-a5c0-1cc69805a338"), Type = TextBlockType.Text, Text = "The armor is so comfortable that you can rest normally while wearing it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c949ea8-66d2-42b4-b431-7922d984b1fc"),
                SourceId = CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
