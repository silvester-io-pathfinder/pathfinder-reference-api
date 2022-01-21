using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses.Instances
{
    public class Scent : Template
    {
        public static readonly Guid ID = Guid.Parse("a24cca87-5b3e-42d1-ac69-9955acba15d5");

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
            yield return new TextBlock { Id = Guid.Parse("e8735fd5-8501-4621-9fca-eac395898e04"), Type = TextBlockType.Text, Text = "Scent involves sensing creatures or objects by smell, and is usually a vague sense. The range is listed in the ability, and it functions only if the creature or object being detected emits an aroma (for instance, incorporeal creatures usually do not exude an aroma)." };
            yield return new TextBlock { Id = Guid.Parse("c8e66b1e-605b-4fd4-a80a-b7797b5df179"), Type = TextBlockType.Text, Text = "If a creature emits a heavy aroma or is upwind, the GM can double or even triple the range of scent abilities used to detect that creature, and the GM can reduce the range if a creature is downwind." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8f5b741-ec23-4b73-8bdd-fd8ab6d24d73"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 465
            };
        }
    }
}
