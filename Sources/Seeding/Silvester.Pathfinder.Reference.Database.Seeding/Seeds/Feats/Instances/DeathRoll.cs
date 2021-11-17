using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeathRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("e6a6742f-6dfe-4edb-a3e6-42e44470b480");

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
            yield return new TextBlock { Id = Guid.Parse("90bf47a2-f21d-44e2-b22c-a1722c913c06"), Type = TextBlockType.Text, Text = "The crocodile tucks its legs and rolls rapidly, twisting its victim. It makes a jaws (action: Strike) with a +2 circumstance bonus to the attack roll against the grabbed creature. If it hits, it also knocks the creature prone. If it misses, it releases the creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2dafe26-5428-4283-ac8a-c2ff3d75d328"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
