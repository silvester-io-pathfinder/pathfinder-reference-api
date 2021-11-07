using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Mug : Template
    {
        public static readonly Guid ID = Guid.Parse("75dfb478-ae2b-45e9-9d2f-92b0e5478ba6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mug",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d1dbb63-1ae3-4e7b-8c64-d17c9414df1c"), Type = TextBlockType.Text, Text = "You make a quick attack and rob your foe in the process. Make a melee (action: Strike) against an adjacent foe. If you hit and deal sneak attack damage, you can also attempt to (action: Steal) from the target, even if the target is in combat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7ee7876-8370-414d-8013-14ca698883ab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
