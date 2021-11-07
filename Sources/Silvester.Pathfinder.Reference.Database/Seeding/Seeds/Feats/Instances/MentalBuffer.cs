using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MentalBuffer : Template
    {
        public static readonly Guid ID = Guid.Parse("dc0efea9-ac23-4f6d-ae60-0735ee81880c");

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
            yield return new TextBlock { Id = Guid.Parse("0fcf7f93-a477-45ab-91f9-bb2693f36f04"), Type = TextBlockType.Text, Text = "Your mind deflects some amount of harm from attacks that induce pain or manipulate your mind directly. You gain resistance to mental damage equal to half your level. This resistance increases to equal your level while your psyche is Unleashed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7612e785-6d98-4967-af00-b7a9ef87ad2d"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
