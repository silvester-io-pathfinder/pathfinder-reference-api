using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrideHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("07b419f7-e3b1-43e3-b5a2-bfba21cb2f5a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pride Hunter",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c550518-1e95-492b-b990-2749cb5633b2"), Type = TextBlockType.Text, Text = "You avoid the attention of creatures focused on your allies. You can use lesser cover from your allies to (action: Hide)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6b4587d-5801-4ba5-a752-46c35f1921b9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
