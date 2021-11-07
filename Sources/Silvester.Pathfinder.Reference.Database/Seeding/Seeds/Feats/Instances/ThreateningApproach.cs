using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThreateningApproach : Template
    {
        public static readonly Guid ID = Guid.Parse("d727914c-62ba-4f72-8ae4-0d6ac23ee872");

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
            yield return new TextBlock { Id = Guid.Parse("0c6967cb-4c56-431a-9b68-a2af416b7b56"), Type = TextBlockType.Text, Text = "You (action: Stride) to be adjacent to a foe and (action: Demoralize) that foe. If you succeed, the foe is frightened 2 instead of frightened 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("266bc23a-880d-4f0d-8dc5-7b345c200f1d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
