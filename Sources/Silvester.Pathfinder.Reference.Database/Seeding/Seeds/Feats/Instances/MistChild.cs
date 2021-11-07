using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MistChild : Template
    {
        public static readonly Guid ID = Guid.Parse("dc3f9b9c-fb84-4aae-bfdf-da6215909400");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mist Child",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d382635-d7b3-4953-a1ea-d135793f8539"), Type = TextBlockType.Text, Text = "You blend in with unnatural subtlety. When you are concealed or hidden, increase the DC of the flat check to target you to 6 if you&#39;re concealed or 12 if you&#39;re hidden." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54839a1b-1743-4b6e-b679-5b5cadd2d16f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
