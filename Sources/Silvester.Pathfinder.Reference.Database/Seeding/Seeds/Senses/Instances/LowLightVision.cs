using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class LowLightVision : Template
    {
        public static readonly Guid ID = Guid.Parse("a95d29f6-35ac-419a-985b-8259daa080ac");

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
            yield return new TextBlock { Id = Guid.Parse("864b1139-523d-4b42-b4b6-6872901c1940"), Type = TextBlockType.Text, Text = "A creature with low-light vision can see in dim light as though it were bright light, so it ignores the concealed condition due to dim light." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cebc2d49-e483-45c6-934b-8e92c5b63f7e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 465
            };
        }
    }
}
