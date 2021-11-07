using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CityScavenger : Template
    {
        public static readonly Guid ID = Guid.Parse("20ac5cfa-698d-4eac-97e8-595ac5b7c03c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "City Scavenger",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the irongut goblin heritage, increase the bonuses to +2.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba043da5-04b5-41d7-b776-dd1cb85ce4ff"), Type = TextBlockType.Text, Text = "You know that the greatest treasures often look like refuse, and you scoff at those who throw away perfectly good scraps. You gain a +1 circumstance bonus to checks to (action: Subsist), and you can use Society or Survival when you (action: Subsist) in a settlement." };
            yield return new TextBlock { Id = Guid.Parse("25005289-7c05-4ecf-b09f-03c251351e83"), Type = TextBlockType.Text, Text = "When you (action: Subsist) in a city, you also gather valuable junk that silly longshanks threw away. You can (action: Earn Income) using Society or Survival in the same time as you (action: Subsist), without spending any additional days of downtime. You also gain a +1 circumstance bonus to this check." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49699244-26b5-4565-8bdc-79058c78b79e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
