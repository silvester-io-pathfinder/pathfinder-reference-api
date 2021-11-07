using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinishTheJob : Template
    {
        public static readonly Guid ID = Guid.Parse("3e60271e-a5fa-40f0-bb50-5f6259dc6c53");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finish the Job",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7f7ead81-5441-483b-a14a-0d1d03faa022"), Type = TextBlockType.Text, Text = "Your last attack failed, but it set you up for another. Make a (action: Strike) with your other hand, using a one-handed melee weapon or unarmed attack. This (action: Strike) uses the same multiple attack penalty as the (action: Strike) that failed on the last action. Afterward, increase your multiple attack penalty normally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2a46a4f-8fe0-4088-9c83-1dd1f93626b3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
