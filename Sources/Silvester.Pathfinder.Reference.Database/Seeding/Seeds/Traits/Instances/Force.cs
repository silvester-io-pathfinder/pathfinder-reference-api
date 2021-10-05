using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Force : Template
    {
        public static readonly Guid ID = Guid.Parse("d7be685f-711c-4cf3-8414-670d8dd64144");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Force",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b63edc6-9758-4e43-83cd-37d407688bb0"), Type = TextBlockType.Text, Text = "Effects with this trait deal force damage or create objects made of pure magical force." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b0375f3-7640-463d-bd57-dd3fe6a903a9"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
