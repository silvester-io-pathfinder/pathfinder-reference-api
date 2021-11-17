using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrineMay : Template
    {
        public static readonly Guid ID = Guid.Parse("81c33116-a900-470e-bda5-c9705cce8892");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brine May",
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
            yield return new TextBlock { Id = Guid.Parse("43da22c8-0ecb-47cb-9cf9-3487352f25be"), Type = TextBlockType.Text, Text = "Your mother was a sea hag, granting you one sea-green or blue eye. You find comfort both in the sea and on the shore. Whenever you roll a success on an Athletics check to (action: Swim), you get a critical success instead. If you end your turn in water without having succeeded at a (action: Swim) action that round, you don&#39;t sink (but you might still be moved by the current)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef6c8821-f1f8-4f0c-a31f-46ba54b9d291"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
