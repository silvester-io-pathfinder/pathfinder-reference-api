using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestralParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("8707a28f-a33e-41c5-bf5b-c86a0b566a18");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestral Paragon",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f8c3c2c-e80c-4847-bcb1-883cf6b9f7a1"), Type = TextBlockType.Text, Text = "Whether through instinct, study, or magic, you feel a deeper connection to your ancestry. You gain a 1st-level ancestry feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5ec35b2-daf4-4f5f-adf9-090202f4b942"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
