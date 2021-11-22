using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThatsOdd : Template
    {
        public static readonly Guid ID = Guid.Parse("fb53ea26-574f-4452-9b07-f8836924fc53");

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
            yield return new TextBlock { Id = Guid.Parse("efd0fa94-46ac-440d-9644-17fe3b505825"), Type = TextBlockType.Text, Text = "When you enter a new location, such as a room or corridor, you immediately notice one thing out of the ordinary. The GM determines what it is, or whether there's nothing reasonable to pick up, skipping obvious clues that can be easily noticed without a check or specifically looking for them. You learn only that an area or object is suspicious, but not why it's suspicious. For example, if you entered a study with a large bloodstain on the ground, the bloodstain is so obviously suspicious it's evident to you already, so the GM might note that there's something suspicious about the desk drawer instead. You would then need to investigate the drawer further to find out what specifically is out of the ordinary. That's Odd doesn't reveal whether creatures are suspicious." };
            yield return new TextBlock { Id = Guid.Parse("c456ec61-3014-4e9b-80f2-03ea7a3fa5ee"), Type = TextBlockType.Text, Text = "You don't typically get any benefit when you leave and come back to a place, though if a major change has happened there and time has passed, the GM might determine that you do." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14b89891-0b37-4048-91b6-7e8ec0087740"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
