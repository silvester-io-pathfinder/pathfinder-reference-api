using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlazingAura : Template
    {
        public static readonly Guid ID = Guid.Parse("079346be-a815-4c4e-a8ef-73a066226046");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blazing Aura",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ded4520-4156-4f2b-832c-0967f7af603a"), Type = TextBlockType.Text, Text = "You explode in flame. Enemies in a 20-foot emanation take 7d6 fire damage (basic Reflex save using your class DC or spell DC, whichever is higher). Allies in the area are quickened for 1 round and can use the additional action to (action: Strike) or (action: Stride)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("150d1152-5b0e-410d-a58d-2758d24b214c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
