using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdoptedAncestry : Template
    {
        public static readonly Guid ID = Guid.Parse("a2e0835b-f3a1-4846-8974-7eb93faf262d");

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
            yield return new TextBlock { Id = Guid.Parse("1c09ae17-8aa6-425b-a9d8-58dd803c2457"), Type = TextBlockType.Text, Text = "You’re fully immersed in another ancestry’s culture and traditions, whether born into them, earned through rite of passage, or bonded through a deep friendship or romance. Choose a common ancestry. You can select ancestry feats from the ancestry you chose, in addition to your character’s own ancestry, as long as the ancestry feats don’t require any physiological feature that you lack, as determined by the GM." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f89289e-89ef-4fae-82f2-ac9ad5130efd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
