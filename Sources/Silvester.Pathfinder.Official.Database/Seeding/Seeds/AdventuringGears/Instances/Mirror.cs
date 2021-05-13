using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Mirror : Template
    {
        public static readonly Guid ID = Guid.Parse("25290e17-81bd-4b8d-89b4-fb9228d33d7b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Mirror",
                Hands = "1",
                ItemLevel = "0",
                Price = 100,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fc4cf241-1aba-44df-b8d7-a25edc47257f"), Type = TextBlockType.Text, Text = "A mirror is an object that reflects an image. Light that bounces off a mirror will show an image of whatever is in front of it, when focused through the lens of the eye or a camera. Mirrors reverse the direction of the image in an equal yet opposite angle from which the light shines upon it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1f9d05d-10cc-44f2-a393-2366418530c1"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
