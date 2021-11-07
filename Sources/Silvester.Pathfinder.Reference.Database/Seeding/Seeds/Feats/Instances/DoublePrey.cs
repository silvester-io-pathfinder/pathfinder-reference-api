using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DoublePrey : Template
    {
        public static readonly Guid ID = Guid.Parse("fd651e33-1d89-4483-91d9-6e46d660cfde");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Double Prey",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b20a0b31-9af7-4d93-a6e1-e21692d71529"), Type = TextBlockType.Text, Text = "You can focus on two foes at once, hunting both of them down. When you use the (feat: Hunt Prey) action, you can pick two creatures as your prey." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("573d5605-33d7-4fb1-b186-b2d1e193fb52"), Feats.Instances.BountyHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a3458c7-a698-4f24-b018-a27ab95f89f8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
