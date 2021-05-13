using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Aeon : Template
    {
        public static readonly Guid ID = Guid.Parse("ce6136ac-735f-4c8f-84be-5093f57b2ff0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Aeon",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5252ffd-8b73-4372-b634-c1a611e11ec9"), Type = TextBlockType.Text, Text = "These monitors are the self-styled defenders of reality. Traditional aeons have dualistic natures and forms, and they hold a dichotomy of interests, though axiomites and inevitables do not. Aeons other than axiomites and inevitables communicate via a strange telepathic hodgepodge of sensory sending called envisioning." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2788e896-15f6-4670-bb2c-979cfe94e760"),
                SourceId = Bestiary.ID,
                Page = 345
            };
        }
    }
}
