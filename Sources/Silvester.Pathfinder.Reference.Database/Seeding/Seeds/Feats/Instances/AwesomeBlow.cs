using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AwesomeBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("bc33644f-0ad5-4c30-b6a9-00b6c9c7d0ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Awesome Blow",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c6ef85fb-5b02-4938-98ea-1744051cd369"), Type = TextBlockType.Text, Text = "Your attacks are so powerful, they can flatten your opponents. When you use (feat: Knockback), you can attempt an Athletics check against your target’s Fortitude DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b1b18a73-a445-4fa4-a9f4-6d7d98efb8b0"), Feats.Instances.Knockback.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f9fa6707-02ea-4da5-8015-dc15d1d35f23"),
                CriticalSuccess = "You gain the critical success effect of a (action: Shove), then the critical success effect of a (action: Trip) against the target.",
                Success = "You gain the success effect of a (action: Shove), then the success effect of a (action: Trip) against the target.",
                Failure = "You gain the normal effect of (feat: Knockback).",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("420d79c3-8f51-4ddf-b605-c9e4d0942f94"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
