using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GanziGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("c8ad6d8b-e835-4b3d-a719-8d93fcf50afb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ganzi Gaze",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat a second time to gain darkvision in addition to low-light vision.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a5dc33f-322b-4612-a869-4de79e927cf1"), Type = TextBlockType.Text, Text = "You have unusual sensory abilities passed down from your chaotic forebears. You gain low-light vision. If you already have low-light vision, you gain darkvision instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e25797c-09a0-4c50-9183-f76daee91edb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
