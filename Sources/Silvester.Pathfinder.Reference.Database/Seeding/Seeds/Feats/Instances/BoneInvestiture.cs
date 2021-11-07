using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoneInvestiture : Template
    {
        public static readonly Guid ID = Guid.Parse("25303a9e-5850-43c6-929c-2d39935e84d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bone Investiture",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55f33eed-9605-4883-b0d7-2d7f52d9210e"), Type = TextBlockType.Text, Text = "You encase yourself in spiritual dinosaur bones to become a Huge dinosaur. You can cast (spell: dinosaur form) on yourself as a 5th-level primal innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6da468bd-c0ac-4a75-883b-e93be75f7bee"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
