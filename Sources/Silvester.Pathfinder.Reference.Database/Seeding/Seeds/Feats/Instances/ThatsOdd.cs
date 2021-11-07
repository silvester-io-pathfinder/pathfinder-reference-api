using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThatsOdd : Template
    {
        public static readonly Guid ID = Guid.Parse("cabde378-e469-4e63-a5fc-61167a8319f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "That's Odd",
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
            yield return new TextBlock { Id = Guid.Parse("2a0a5809-4c48-4b73-967e-20507d17ffd2"), Type = TextBlockType.Text, Text = "When you enter a new location, such as a room or corridor, you immediately notice one thing out of the ordinary. The GM determines what it is, or whether there&#39;s nothing reasonable to pick up, skipping obvious clues that can be easily noticed without a check or specifically looking for them. You learn only that an area or object is suspicious, but not why it&#39;s suspicious. For example, if you entered a study with a large bloodstain on the ground, the bloodstain is so obviously suspicious it&#39;s evident to you already, so the GM might note that there&#39;s something suspicious about the desk drawer instead. You would then need to investigate the drawer further to find out what specifically is out of the ordinary. That&#39;s Odd doesn&#39;t reveal whether creatures are suspicious." };
            yield return new TextBlock { Id = Guid.Parse("6b28d8cc-059d-44f0-a52b-c0256c467baf"), Type = TextBlockType.Text, Text = "You don&#39;t typically get any benefit when you leave and come back to a place, though if a major change has happened there and time has passed, the GM might determine that you do." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31317aee-ffd7-468e-9fba-ed95c9d84fb7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
