using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HexMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("a52e17f1-487f-482c-b693-d8f3226f9fee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hex Master",
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
            yield return new TextBlock { Id = Guid.Parse("fdbb3989-dccc-42c9-a522-4ba1a78b06c2"), Type = TextBlockType.Text, Text = "You embody the link to your patron so completely that you can cast your hexes in rapid succession. You are no longer limited to casting only a single hex each turn. In addition, when you cast (spell: cackle) to sustain a hex, you gain the effects of (action: Sustain a Spell) for all your active hexes that have a duration of sustained." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c56b136-5968-4d2c-85ba-e8d85a0e43e9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
