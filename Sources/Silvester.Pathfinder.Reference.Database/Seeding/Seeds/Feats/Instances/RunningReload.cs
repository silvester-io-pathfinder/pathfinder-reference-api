using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RunningReload : Template
    {
        public static readonly Guid ID = Guid.Parse("419a048b-615b-4015-b3b9-d073bf92584e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Running Reload",
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
            yield return new TextBlock { Id = Guid.Parse("a8c119d9-b49f-49a5-bcfc-3abb04353e3d"), Type = TextBlockType.Text, Text = "You can reload your weapon on the move. You (action: Stride), (action: Step), or (action: Sneak), then (action: Interact) to reload." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f7e750b-00f3-4b89-b78b-1d6b2990840c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
