using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Firesight : Template
    {
        public static readonly Guid ID = Guid.Parse("955291ee-f5a7-45d1-b3ae-5cc3e074e928");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Firesight",
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
            yield return new TextBlock { Id = Guid.Parse("df3f360f-7a47-4dad-b619-508aee26e775"), Type = TextBlockType.Text, Text = "You can see through the haze of flame. You automatically succeed at the flat check to target a concealed creature if that creature is concealed only by smoke and fire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bf000e5-c694-4c11-82e9-7e3648db00c5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
