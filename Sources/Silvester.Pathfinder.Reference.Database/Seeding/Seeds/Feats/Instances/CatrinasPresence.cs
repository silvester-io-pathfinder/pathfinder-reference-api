using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatrinasPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("6692ff0a-8fce-42b6-8b35-2bb28e39a80a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catrina's Presence",
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
            yield return new TextBlock { Id = Guid.Parse("7ba20f18-106d-4b9b-a810-d68447ad90c1"), Type = TextBlockType.Text, Text = "You’ve adopted the calming presence of catrinas, the festive dead; you might have even danced with a catrina yourself! So long as you are visibly carrying fresh flowers or colorful ribbons somewhere on your person, you can cast (spell: calm emotions) twice per day as a 2nd-level divine innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ef42f82-ed81-4a5f-8c01-5a1a72896bb5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
