using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlexibleStudies : Template
    {
        public static readonly Guid ID = Guid.Parse("a7bfc7cf-771d-4757-9871-95cfe85a2261");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flexible Studies",
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
            yield return new TextBlock { Id = Guid.Parse("e2199753-6c2d-4cc7-88cd-44592c1a6c24"), Type = TextBlockType.Text, Text = "You&#39;ve collected a cross-section of information on various disciplines you can refer to when preparing for various tasks. During your daily preparations, you can cram on a certain subject to become temporarily trained in one skill of your choice. This proficiency lasts until you prepare again. As this proficiency is temporary, you can&#39;t use it as a prerequisite for a skill increase or a permanent character option like a feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9ee782e-ace6-42d5-ae63-42992dc0fbce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
