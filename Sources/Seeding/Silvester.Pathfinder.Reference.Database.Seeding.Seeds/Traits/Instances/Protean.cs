using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Protean : Template
    {
        public static readonly Guid ID = Guid.Parse("fe370771-cafe-4521-ae95-6545a0d9b2b5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Protean",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("008410f2-b8e6-4825-96b6-84fd1115e74d"), Type = TextBlockType.Text, Text = "A family of monitors spawned within the Maelstrom, these creatures are guardians of disorder and are chaotic neutral. They typically have darkvision, an amorphous anatomy, and a weakness to lawful damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e155929-0a67-446d-98aa-c14a4c63a76c"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
