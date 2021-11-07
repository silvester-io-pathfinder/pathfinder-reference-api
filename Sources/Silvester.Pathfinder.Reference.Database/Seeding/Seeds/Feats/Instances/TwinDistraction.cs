using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinDistraction : Template
    {
        public static readonly Guid ID = Guid.Parse("f6bbb345-51c2-46a8-8c02-51e654543c8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Distraction",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8392ef3-416f-440a-b1b3-e28e48dc2ac8"), Type = TextBlockType.Text, Text = "Your movements with two weapons are so swift and disorienting that they befuddle your opponent. When using (feat: Twin Feint), if both your (action: Strikes | Strike) deal damage to a targeted creature, the target must succeed at a Will saving throw against your class DC or become stupefied 1 until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cd727190-c9b6-41b2-9953-7430a9582b2f"), Feats.Instances.TwinFeint.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb7e0835-1fdc-4a18-90d9-d9590abe9d6e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
