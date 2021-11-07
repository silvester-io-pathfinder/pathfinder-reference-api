using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LemmaOfVision : Template
    {
        public static readonly Guid ID = Guid.Parse("cffd9335-1c61-4ea6-a053-b0197e3d9066");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lemma of Vision",
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
            yield return new TextBlock { Id = Guid.Parse("9d866b53-93d2-4cfc-bc5a-52aaa826a154"), Type = TextBlockType.Text, Text = "You’ve solved a tiny stepping stone in your self-discovery, awakening new depths in your sight. You gain darkvision." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08a5fd24-18e6-465a-9ea6-24c61f5e40aa"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
