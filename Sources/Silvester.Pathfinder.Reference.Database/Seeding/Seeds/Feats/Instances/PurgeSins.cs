using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PurgeSins : Template
    {
        public static readonly Guid ID = Guid.Parse("0ddfd51f-57b6-444b-aeaa-44e9201fa859");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Purge Sins",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62f7c3f1-6db0-4f58-ab85-427694041c1c"), Type = TextBlockType.Text, Text = "You call on your celestial forebears to rid your body of all toxins and impurities. For each disease or poison currently affecting you, attempt a Religion check to counteract that disease or poison. As normal, your counteract level is equal to half your level, rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62060949-2edd-4707-9deb-45bfb28c9963"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
