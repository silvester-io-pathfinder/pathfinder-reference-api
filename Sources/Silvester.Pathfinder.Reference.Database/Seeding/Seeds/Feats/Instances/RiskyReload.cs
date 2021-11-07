using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RiskyReload : Template
    {
        public static readonly Guid ID = Guid.Parse("fa6f647a-5906-433e-9992-9d27c59dcc6f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Risky Reload",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ce45d0a-691a-4890-bd34-a94e6ce2e86b"), Type = TextBlockType.Text, Text = "You’ve practiced a technique for rapidly reloading your firearm, but attempting to use this technique is a dangerous gamble with your firearm’s functionality. (action: Interact) to reload a firearm, then make a (action: Strike) with that firearm. If the (action: Strike) fails, the firearm (trait: misfires|misfire)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41e29fe0-b4cb-4966-a849-864cbb77108f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
