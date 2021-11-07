using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdoptedAncestry : Template
    {
        public static readonly Guid ID = Guid.Parse("4adbffac-5906-4067-a93e-4c643270356d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adopted Ancestry",
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
            yield return new TextBlock { Id = Guid.Parse("81683ad7-7f96-4a56-9f19-cf4d730225e4"), Type = TextBlockType.Text, Text = "You’re fully immersed in another ancestry’s culture and traditions, whether born into them, earned through rite of passage, or bonded through a deep friendship or romance. Choose a common ancestry. You can select ancestry feats from the ancestry you chose, in addition to your character’s own ancestry, as long as the ancestry feats don’t require any physiological feature that you lack, as determined by the GM." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3086262-e4ab-4cab-b115-611e09d9ba98"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
