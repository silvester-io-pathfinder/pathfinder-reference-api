using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Irrepressible : Template
    {
        public static readonly Guid ID = Guid.Parse("bacf919f-5fba-4562-b657-27260b296696");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Irrepressible",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e0f009b-ef40-4b06-af5a-ecb72c0315f3"), Type = TextBlockType.Text, Text = $"Your contrary nature means you bounce back with prejudice. When you roll a success on a save against an {ToMarkdownLink<Models.Entities.Trait>("emotion", Traits.Instances.Emotion.ID)} or {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04bd05fa-b0c7-42c9-bef7-69946f89ff73"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
