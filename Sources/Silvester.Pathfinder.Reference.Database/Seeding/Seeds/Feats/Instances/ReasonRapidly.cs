using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReasonRapidly : Template
    {
        public static readonly Guid ID = Guid.Parse("3b622e92-5122-4700-b1c9-a52f7b2d26e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reason Rapidly",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a34074d7-2b48-427b-aa26-a79fccf4da22"), Type = TextBlockType.Text, Text = "Your mind works through clues at an unbelievable speed. You instantly use up to five (action: Recall Knowledge) actions. If you have any special abilities or free actions that would normally be triggered when you (action: Recall Knowledge), you can&#39;t use them for these actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40a95a4c-7a16-4a19-a217-3f962f1219b3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
