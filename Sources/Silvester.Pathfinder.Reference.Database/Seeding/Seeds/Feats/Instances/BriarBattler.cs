using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BriarBattler : Template
    {
        public static readonly Guid ID = Guid.Parse("9dbb7809-5877-414f-909c-68da77365bc2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Briar Battler",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51cd0baf-4c9d-4579-b829-305aa53a8770"), Type = TextBlockType.Text, Text = "You’ve learned to use roots, crevices, uneven ground, and dense underbrush to your advantage. When you’re in difficult terrain from an environmental feature, you can (action: Take Cover), even if the feature wouldn’t ordinarily be large enough for you to (action: Take Cover)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0faee456-d8a2-4d98-9e14-888733ae4bd0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
