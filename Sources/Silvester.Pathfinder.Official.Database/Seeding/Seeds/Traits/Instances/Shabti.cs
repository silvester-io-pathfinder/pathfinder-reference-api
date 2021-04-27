using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Shabti : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("ab27faa6-b69a-4949-a9dc-34cf97f68459");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Shabti",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ff78756-9c89-4211-a9ca-2b08fb0f5536"), Type = TextBlockType.Text, Text = "A shabti is a constructed humanoid originally meant to face judgment for a living creature's sins after death." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60867daf-bf09-49c1-b493-d9187bc1813f"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
