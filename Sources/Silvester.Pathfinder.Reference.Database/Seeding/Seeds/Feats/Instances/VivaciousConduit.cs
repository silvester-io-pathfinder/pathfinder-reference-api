using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VivaciousConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("582cd609-afc6-41e8-985f-b16b0aa0cb4c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vivacious Conduit",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f8062a4-2ede-43eb-9160-9be9c7d17f4f"), Type = TextBlockType.Text, Text = "Your connection to the First World has grown, and its positive energy flows into you rapidly. If you rest for 10 minutes, you gain Hit Points equal to your Constitution modifier &#215; half your level. This is cumulative with any healing you receive from (action: Treat Wounds)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ebe2977b-f953-416a-ae4d-43c51e6e1da8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
