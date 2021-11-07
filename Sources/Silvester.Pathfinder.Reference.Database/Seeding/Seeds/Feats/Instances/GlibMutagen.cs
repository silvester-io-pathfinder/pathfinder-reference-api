using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GlibMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("da2cd2f1-ed5d-4023-a16e-02f24cbfed9d");

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
            yield return new TextBlock { Id = Guid.Parse("12abf8da-a223-46a7-88fc-31d185c6fbc6"), Type = TextBlockType.Text, Text = "Your silvertongue mutagen transcends languages and plausibility. When affected by a silvertongue mutagen you have created, you ignore circumstance penalties to Deception, Diplomacy, Intimidation, and Performance checks. In addition, your words transcend linguistic barriers; everyone listening to you speak hears your words as if you were speaking in their own language (though you do not actually speak that language, nor does this ability allow you to understand any additional languages)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("279fe476-e3dd-4e67-bcda-d69270475a95"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
