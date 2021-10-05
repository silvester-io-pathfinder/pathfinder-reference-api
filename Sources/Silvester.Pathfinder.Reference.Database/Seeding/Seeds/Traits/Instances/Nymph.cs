using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Nymph : Template
    {
        public static readonly Guid ID = Guid.Parse("35a2d85c-e513-4016-83fd-4dee6d3756de");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Nymph",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f80b441-bd72-4246-9d12-3a1e2f7d9c83"), Type = TextBlockType.Text, Text = "This family of beautiful fey creatures has strong ties to natural locations." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("464f33b4-3306-4ded-b7ac-33c285f1bd9e"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
