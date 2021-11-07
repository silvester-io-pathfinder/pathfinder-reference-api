using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SliceAndSwipe : Template
    {
        public static readonly Guid ID = Guid.Parse("b8572dd2-ec5e-4488-a081-fcc88cf025a1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slice and Swipe",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07d198d9-686d-4dc0-bc3e-e93f71997f09"), Type = TextBlockType.Text, Text = "~ Access: Help either the Washboard Dogs or the Diobel Sweepers destroy their rival." };
            yield return new TextBlock { Id = Guid.Parse("58dc429f-340e-4fa5-938e-303eb3dab465"), Type = TextBlockType.Text, Text = "You attempt a melee (action: Strike) with the required weapon. If you hit and deal damage and the result of your attack roll exceeds the target&#39;s Perception DC, you (action: Steal) a small object from the target (as if you had succeeded at that task using the Thievery skill). Depending on the object, the target might realize that it has been stolen, and onlookers might realize you have stolen the object if the attack roll doesn&#39;t exceed their Perception DCs." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8445332f-d0c4-4e8d-b0fd-3149d198a2ed"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
