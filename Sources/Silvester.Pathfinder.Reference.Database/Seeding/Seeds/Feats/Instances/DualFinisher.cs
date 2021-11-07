using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("5fbdc47d-20df-42fc-8fe2-6e436f098d86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual Finisher",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("64cbfbf8-c62b-455a-90f6-ac64fd2e0f24"), Type = TextBlockType.Text, Text = "You split your attacks. Make two melee (action: Strikes | Strike), one with each required weapon, each against a different foe. If the second (action: Strike) is made with a non-(trait: agile) weapon, it takes a -2 penalty. Increase your multiple attack penalty only after attempting both (action: Strikes | Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e25ea41a-a993-47b0-a3ef-126813bdeec2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
