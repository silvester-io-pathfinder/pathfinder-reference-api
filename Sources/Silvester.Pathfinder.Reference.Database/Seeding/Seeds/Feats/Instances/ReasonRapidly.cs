using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReasonRapidly : Template
    {
        public static readonly Guid ID = Guid.Parse("9edd0a11-8714-46a1-b601-0420cee7b860");

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
            yield return new TextBlock { Id = Guid.Parse("9e2258ee-633f-4ef2-965a-17ba7ab8ebe0"), Type = TextBlockType.Text, Text = "Your mind works through clues at an unbelievable speed. You instantly use up to five (action: Recall Knowledge) actions. If you have any special abilities or free actions that would normally be triggered when you (action: Recall Knowledge), you can&#39;t use them for these actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee25982f-9d0f-437e-8361-c2cd0aa96d64"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
