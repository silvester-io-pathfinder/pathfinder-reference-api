using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineCountermeasures : Template
    {
        public static readonly Guid ID = Guid.Parse("84d51ab3-5481-41f5-8a06-5d8e8c7c348f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Countermeasures",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb53ba68-f8ae-40fc-9b82-0ab54076b25d"), Type = TextBlockType.Text, Text = "You&#39;ve studied your celestial heritage with the intent of better defending yourself, and you&#39;ve found that your techniques are equally powerful against celestials, fiends, and other divine entities. You gain a +1 circumstance bonus to all saving throws against (trait: divine) effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4ccc197-e5fb-4b87-b881-2bda8d1fbcc2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
