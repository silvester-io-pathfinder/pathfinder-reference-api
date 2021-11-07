using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GlibMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("d5f986ee-2f99-436b-ae3b-a5b033564254");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glib Mutagen",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd1f2995-92d2-41f5-b20b-e75052563d92"), Type = TextBlockType.Text, Text = "Your silvertongue mutagen transcends languages and plausibility. When affected by a silvertongue mutagen you have created, you ignore circumstance penalties to Deception, Diplomacy, Intimidation, and Performance checks. In addition, your words transcend linguistic barriers; everyone listening to you speak hears your words as if you were speaking in their own language (though you do not actually speak that language, nor does this ability allow you to understand any additional languages)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02d6624b-1919-483f-b313-59fb82cec687"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
