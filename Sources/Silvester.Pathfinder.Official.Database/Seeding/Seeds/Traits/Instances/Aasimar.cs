using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Aasimar : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("3e9bd9b1-aa6f-4319-92c4-0b4c4ad6dea6");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Aasimar",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6dddf71-83f5-489b-80ff-f85a8caa5463"), Type = TextBlockType.Text, Text = "A creature with this trait has the aasimar versatile heritage. Aasimars are planar scions descended from celestial beings. An ability with this trait can be used or selected only by aasimars." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23af3b6d-5a83-45fc-8971-6b94ec0fa4df"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 266
            };
        }
    }
}
