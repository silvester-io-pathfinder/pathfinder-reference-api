using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GloryAndValor : Template
    {
        public static readonly Guid ID = Guid.Parse("ed3867bc-3395-4da6-9ce2-a08160abdb30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glory and Valor!",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e7fb920-1971-4c3f-a569-b86dda68e157"), Type = TextBlockType.Text, Text = "You are descended from the einherji, the worthy warriors of chaos. You call upon your ascendant blood with a mighty cry that fills you with a revitalizing energy for 1 minute or until you critically fail a (action: Strike), whichever comes first. For the duration, the first time each round you successfully (action: Strike) a creature of your level or higher, you regain Hit Points equal to half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fb3323a-b0e8-4b6f-a6ab-1e14a7a3c12c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
