using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HyenaFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("164e424c-fbd9-4b50-bca1-2845bbbc8ac2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hyena Familiar",
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
            yield return new TextBlock { Id = Guid.Parse("31d70411-f8a5-4567-bcf2-2d1e6cb5457c"), Type = TextBlockType.Text, Text = "Hyenas serve gnolls as pets, trackers, and in your case, vessels for spirits. You gain a Tiny hyena as a familiar." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ac8892c-3221-4ce1-9d6c-efd065d10dcd"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
