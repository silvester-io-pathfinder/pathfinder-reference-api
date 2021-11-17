using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Mutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("bd80ab5f-b899-485d-b279-83805a2e9b35");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Mutagen",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("335c6212-9e00-4692-a589-210c5440a4a1"), Type = TextBlockType.Text, Text = "An elixir with the mutagen trait temporarily transmogrifies the subject’s body and alters its mind. A mutagen always conveys one or more beneficial effects paired with one or more detrimental effects. Mutagens are polymorph effects, meaning you can benefit from only one at a time." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcb11286-cebc-4a2a-997d-52c01ccfc820"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
