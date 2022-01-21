using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MentalBuffer : Template
    {
        public static readonly Guid ID = Guid.Parse("09207189-0c90-470f-9e74-204530857ecd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mental Buffer",
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
            yield return new TextBlock { Id = Guid.Parse("b0fbf9d7-5513-42d4-86b7-9e2544ad2b85"), Type = TextBlockType.Text, Text = "Your mind deflects some amount of harm from attacks that induce pain or manipulate your mind directly. You gain resistance to mental damage equal to half your level. This resistance increases to equal your level while your psyche is Unleashed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ea8f2ec-fd3f-4029-a494-0e6e8d23bab2"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
