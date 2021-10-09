using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class LowLightVision : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Low-Light Vision"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A creature with low-light vision can see in dim light as though it were bright light, so it ignores the concealed condition due to dim light." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 465
            };
        }
    }
}
