using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Hex : Template
    {
        public static readonly Guid ID = Guid.Parse("312359d8-0b0b-4692-a504-df210dd80f43");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Hex",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31d53d0c-d1ff-4915-8197-120bcd222009"), Type = TextBlockType.Text, Text = "A hex is a short-term effect generated on the fly from your patron's magic, requiring your familiar to draw from your patron. As such, you can cast only one spell with the hex trait each turn; attempts to cast a second hex spell on the same turn fail, and the spellcasting actions are lost." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47552831-3c6c-4bf8-a5c6-430c6774d9fc"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 268
            };
        }
    }
}
