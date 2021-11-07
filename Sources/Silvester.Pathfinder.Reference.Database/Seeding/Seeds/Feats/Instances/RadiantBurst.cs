using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RadiantBurst : Template
    {
        public static readonly Guid ID = Guid.Parse("340f8685-c3fa-41ac-83a3-7673b781043d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiant Burst",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dfdfc442-5e71-4d39-9614-90c42aaf02da"), Type = TextBlockType.Text, Text = "Your skin glows with intensity. Creatures within 10 feet who can see you must succeed at a Fortitude save against your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2623c214-e952-4735-913f-c514ea031a8c"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled for 1 round.",
                Failure = "The creature is blinded for 1 round and dazzled for 4 rounds.",
                CriticalFailure = "The creature is blinded for 4 rounds and dazzled for 10 minutes.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8a6b914-b827-490e-b96d-3559a53b1427"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
