using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MindOverMatter : Template
    {
        public static readonly Guid ID = Guid.Parse("5f3a871f-2789-42cb-aae6-dce8f9918ad8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mind over Matter",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93f005e2-37f2-44d6-b72d-e43ce808d57e"), Type = TextBlockType.Text, Text = "Your mind’s limits are only what you imagine them to be. You gain an additional 10th-level spell slot." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe97dea7-5b9d-473a-9064-92b10791066a"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
