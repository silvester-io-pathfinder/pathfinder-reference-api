using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Overdrive : Template
    {
        public static readonly Guid ID = Guid.Parse("5e7474c9-61f7-4ae5-ba1f-8b1bb6478161");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overdrive",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "When under the effects of Overdrive, you can still use the Overdrive action. You can't extend your Overdrive's duration this way, but you can turn an overdrive into a critical overdrive if you critically succeed. A failure has no effect on your current Overdrive, and you end your Overdrive on a critical failure.",
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("003a7cb7-4c9b-4c7f-957e-ab6c1160f646"), Type = TextBlockType.Text, Text = "Temporarily cranking the gizmos on your body into overdrive, you try to add greater power to your attacks. Attempt a Crafting check that has a standard DC for your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("56eb33cc-0b31-45d8-a916-83f4d4130dbd"),
                CriticalSuccess = "Your gizmos go into a state of incredible efficiency called critical overdrive, adding great power to your attacks. Your (action: Strikes | Strike) deal additional damage equal to your Intelligence modifier for 1 minute. After the Overdrive ends, your gizmos become unusable as they cool down or reset, and you can’t use Overdrive for 1 minute.",
                Success = "Your gizmos go into overdrive, adding power to your attacks. As critical success, except the additional damage is equal to half your Intelligence modifier.",
                Failure = "You make a miscalculation and nothing happens.",
                CriticalFailure = "Whoops! Something explodes. You take fire damage equal to your level, and you can’t use Overdrive again for 1 minute as your gizmos cool down and reset.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1179d477-0a3a-4d6c-8a38-420ba0b84888"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
