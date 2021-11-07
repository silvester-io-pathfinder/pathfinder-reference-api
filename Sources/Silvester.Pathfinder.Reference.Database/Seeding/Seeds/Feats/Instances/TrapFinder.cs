using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrapFinder : Template
    {
        public static readonly Guid ID = Guid.Parse("5c5aa375-eb5d-48dd-bfbb-2326f7cc31ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trap Finder",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("67ebd076-1aec-49bb-918c-aff4da23fde8"), Type = TextBlockType.Text, Text = "You have an intuitive sense that alerts you to the dangers and presence of traps. You gain a +1 circumstance bonus to Perception checks to find traps, to AC against attacks made by traps, and to saves against traps. Even if you aren’t (action: Searching | Search), you get a check to find traps that normally require you to be (action: Searching | Search). You still need to meet any other requirements to find the trap." };
            yield return new TextBlock { Id = Guid.Parse("00dc8df5-065e-4807-a87e-b82cda1b8bef"), Type = TextBlockType.Text, Text = "You can disable traps that require a proficiency rank of master in Thievery. If you have master proficiency in Thievery, you can disable traps that require a proficiency rank of legendary instead, and your circumstance bonuses against traps increase to +2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d938274-e634-440b-9c94-1b4d717f594f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
