using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BetweenTheScales : Template
    {
        public static readonly Guid ID = Guid.Parse("bf8b32ed-3687-4e5c-969e-e74af95a1f76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Between the Scales",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5634bfaa-cf2e-4c9f-9301-405d75496e7a"), Type = TextBlockType.Text, Text = "Underestimating you is a grave mistake, but it&#39;s one others keep making. You&#39;ve learned to take advantage of slips in your foes&#39; defenses. When you (action: Strike) a flat-footed creature using a melee weapon or unarmed attack that has the (trait: agile) and (trait: finesse) traits, it gains the (trait: backstabber) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f0ac89b-d107-4f0f-9afa-0792cc42b993"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
