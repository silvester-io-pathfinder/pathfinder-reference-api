using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeathRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("ce3dd677-d0ca-4d60-bb45-9b55761d3633");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Death Roll",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("acbaa8c8-61d3-47bf-ae83-cf62e08df921"), Type = TextBlockType.Text, Text = "The crocodile tucks its legs and rolls rapidly, twisting its victim. It makes a jaws (action: Strike) with a +2 circumstance bonus to the attack roll against the grabbed creature. If it hits, it also knocks the creature prone. If it misses, it releases the creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4daa3bd6-f372-4402-a826-d2b69fb42ff3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
