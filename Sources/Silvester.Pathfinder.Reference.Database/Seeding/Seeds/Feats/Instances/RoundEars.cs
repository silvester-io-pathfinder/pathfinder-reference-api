using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RoundEars : Template
    {
        public static readonly Guid ID = Guid.Parse("e00c0302-c4ee-4f59-a0a3-f566fd674f95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Round Ears",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain out of this feat or into this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b1b39cf-2ef3-4ebb-96cb-da6765de3d14"), Type = TextBlockType.Text, Text = "Your elven lineage is subtle enough that you look barely different from other humans, and you’ve learned to use that to your advantage. You gain the trained proficiency rank in Deception (or another skill of your choice, if you were already trained in Deception). You gain a +4 circumstance bonus to (action: Impersonate) checks to pretend you aren’t a half-elf. Observers are never granted circumstance bonuses to Perception checks due to you (action: Impersonating | Impersonate) a full-blooded human, and you never take circumstance penalties due to you (action: Impersonating | Impersonate) a full-blooded human." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("104d5fa4-8596-405b-b8b2-75fee360437e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
