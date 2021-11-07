using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinnedDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("27fb8c2c-0dc7-42e6-a842-431ded25d3e1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twinned Defense",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("851ea5be-2d1b-4822-ad11-5c6bff2d9c63"), Type = TextBlockType.Text, Text = "You’re always ready to use your off-hand weapon to interfere with attacks against you. While you are in this stance, you constantly gain the benefits of the (feat: Twin Parry) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("93a64d6d-a9c7-4346-8ba6-39299fd4f18d"), Feats.Instances.TwinParry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11fa8164-2cb7-418c-9f66-53df16946d25"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
