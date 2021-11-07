using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GloryAndValor : Template
    {
        public static readonly Guid ID = Guid.Parse("d77aebfe-d602-4393-aa3b-9d2d48a12c56");

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
            yield return new TextBlock { Id = Guid.Parse("7674978d-9567-4b40-8e0a-ba92b3670de7"), Type = TextBlockType.Text, Text = "You are descended from the einherji, the worthy warriors of chaos. You call upon your ascendant blood with a mighty cry that fills you with a revitalizing energy for 1 minute or until you critically fail a (action: Strike), whichever comes first. For the duration, the first time each round you successfully (action: Strike) a creature of your level or higher, you regain Hit Points equal to half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c784c178-3bbb-48eb-b6fc-5466db0521b8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
