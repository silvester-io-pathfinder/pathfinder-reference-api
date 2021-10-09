using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class Scent : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Sense GetSense ()
        {
            return new Sense
            {
                Id = ID,
                Name = "Scent"
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Scent involves sensing creatures or objects by smell, and is usually a vague sense. The range is listed in the ability, and it functions only if the creature or object being detected emits an aroma (for instance, incorporeal creatures usually do not exude an aroma)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If a creature emits a heavy aroma or is upwind, the GM can double or even triple the range of scent abilities used to detect that creature, and the GM can reduce the range if a creature is downwind." };
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
