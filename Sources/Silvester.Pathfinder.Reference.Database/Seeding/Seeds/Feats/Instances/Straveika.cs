using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Straveika : Template
    {
        public static readonly Guid ID = Guid.Parse("bbc5b5ae-0c0c-4b7b-9ef8-e36722bc0415");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Straveika",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9496d0a4-7e48-450a-8dbe-d6e9fcdb5d42"), Type = TextBlockType.Text, Text = "You descend from one of the truly ancient vampires, a nosferatu cursed to eternal life but not eternal youth. People call you straveika, or ancient-born. The vestiges of your forebear&#39;s powers of domination have left you with an understanding of how a creature&#39;s intentions change its behaviors. You gain a +1 circumstance bonus to Perception checks to (action: Sense Motive) and Perception DCs against attempts to (action: Lie) to you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91ce97d0-81c3-4506-8568-6912ccfbc51f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
