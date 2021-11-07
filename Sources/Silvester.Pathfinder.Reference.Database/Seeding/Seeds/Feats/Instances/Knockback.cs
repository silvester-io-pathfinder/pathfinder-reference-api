using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Knockback : Template
    {
        public static readonly Guid ID = Guid.Parse("3fbd6f4e-dd18-47e1-b6f3-d7adc1b0fb25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knockback",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92091174-33b0-460a-8f35-4e8017b7c756"), Type = TextBlockType.Text, Text = "The weight of your swing drives your enemy back. You push the foe back 5 feet, with the effects of a successful (action: Shove). You can follow the foe as normal for a successful (action: Shove)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77765bc2-2fe2-4e7c-952c-8273f3df6cc4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
