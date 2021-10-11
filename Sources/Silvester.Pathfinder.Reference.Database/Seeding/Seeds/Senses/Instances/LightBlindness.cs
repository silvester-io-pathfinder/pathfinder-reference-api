using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class LightBlindness : Template
    {
        public static readonly Guid ID = Guid.Parse("da065f08-5ccf-48d7-9cc6-e0708cc11e5c");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Light Blindness"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8edd4b24-a44f-4fd1-bd31-725965eb5670"), Type = TextBlockType.Text, Text = "When first exposed to bright light, the monster is blinded until the end of its next turn. After this exposure, light doesn�t blind the monster again until after it spends 1 hour in darkness. However, as long as the monster is in an area of bright light, it�s dazzled." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef365ae5-8965-4e49-8804-549bb8bd349d"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
