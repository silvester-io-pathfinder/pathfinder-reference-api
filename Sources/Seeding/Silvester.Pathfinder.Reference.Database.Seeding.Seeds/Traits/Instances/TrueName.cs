using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class TrueName : Template
    {
        public static readonly Guid ID = Guid.Parse("64849c04-623d-4c8b-bc8d-de6a2a0e743e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "True Name",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f394be0-1d7a-4adf-87f0-8b15ee07907f"), Type = TextBlockType.Text, Text = "Certain spells, feats, and items have the true name trait. This trait means they require you to know a creature's true name to use them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc9a2c83-2746-42e8-b2aa-b4eec4fb8c30"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 245
            };
        }
    }
}
