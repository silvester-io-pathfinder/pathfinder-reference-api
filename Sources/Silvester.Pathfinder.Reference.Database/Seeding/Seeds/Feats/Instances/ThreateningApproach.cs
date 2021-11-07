using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThreateningApproach : Template
    {
        public static readonly Guid ID = Guid.Parse("a7d059b1-6aca-48f6-8db2-a4bd26009b5a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Threatening Approach",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47d6231b-d812-4e40-971b-23f825347eac"), Type = TextBlockType.Text, Text = "You (action: Stride) to be adjacent to a foe and (action: Demoralize) that foe. If you succeed, the foe is frightened 2 instead of frightened 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7965371c-4743-4d1c-85f1-9b890b311105"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
