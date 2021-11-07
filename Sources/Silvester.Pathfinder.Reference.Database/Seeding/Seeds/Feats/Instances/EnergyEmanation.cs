using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyEmanation : Template
    {
        public static readonly Guid ID = Guid.Parse("d5e61ba5-cac4-4cbe-bbf9-bf252d3e1d62");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Emanation",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e14e6883-8c89-4d42-85f7-54a2b20d1a6a"), Type = TextBlockType.Text, Text = "Energy bursts forth from your body. You deal 1d6 damage of your chosen type to all adjacent creatures (basic Reflex save using your class DC or spell DC, whichever is higher). At 3rd level, and every 2 levels thereafter, this damage increases by 1d6." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3e43211-d937-4733-ac69-12424daae602"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
