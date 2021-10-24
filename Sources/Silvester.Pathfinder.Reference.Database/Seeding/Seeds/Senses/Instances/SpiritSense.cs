using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class SpiritSense : Template
    {
        public static readonly Guid ID = Guid.Parse("f3d2b5ff-422f-46da-9d6b-dc26ce51250c");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Spirit Sense"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c92fe03-04e1-4f70-8d1e-d0f3996735ee"), Type = TextBlockType.Text, Text = "You open your mind to the metaphysical, enabling you to sense nearby spirits. Even if you aren't Searching, you get a check to find haunts and spirits in the area. You gain a +1 status bonus to the following checks regarding haunts or spirits: Perception checks to Seek, attempts to Recall Knowledge, skill checks to determine the reason for their existence, and skill checks to disable a haunt. You also gain a +1 status bonus to AC and saving throws against haunts and spirits." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("135730fd-a81d-4776-a7d3-780668e83f02"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 225
            };
        }
    }
}
