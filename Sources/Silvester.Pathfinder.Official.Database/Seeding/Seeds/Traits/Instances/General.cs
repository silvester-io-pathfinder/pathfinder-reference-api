using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class General : Template
    {
        public static readonly Guid ID = Guid.Parse("a5bb022d-6274-4469-bae7-cb2ebc126b90");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "General",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b624faca-546b-4a05-a053-6cf20e591a4a"), Type = TextBlockType.Text, Text = "A type of feat that any character can select, regardless of ancestry and class, as long as they meet the prerequisites. You can select a feat with this trait when your class grants a general feat." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bdb301a-9870-4e3d-87e0-6d87d0b8ae5d"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
