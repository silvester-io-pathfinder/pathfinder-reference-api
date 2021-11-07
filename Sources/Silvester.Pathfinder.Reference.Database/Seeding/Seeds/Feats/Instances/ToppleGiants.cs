using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToppleGiants : Template
    {
        public static readonly Guid ID = Guid.Parse("c02c4763-7cd7-49b8-a4ed-aceb21f10acf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Topple Giants",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("02f7e7e1-aac5-4ed0-9656-4f47cf04f394"), Type = TextBlockType.Text, Text = "When you observe an ally try and fail to execute a strategic maneuver against your enemies, you coordinate with your other allies to finish the job, using the opening from the first attempt to keep your foe off-balance and ensure your eventual success." };
            yield return new TextBlock { Id = Guid.Parse("2010fd22-e505-4cb6-8abe-c042f4eb9c75"), Type = TextBlockType.Text, Text = "When an ally within your overwatch field attempts to (action: Disarm), (action: Shove), or (action: Trip) an opponent within your overwatch field and fails, you coordinate efforts to provide a +2 circumstance bonus to the next Athletics check rolled by a different ally to attempt the same action on the same target before that target’s next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("26673074-ea04-43fd-a3b9-088e1ad13cf6"), Feats.Instances.OverwatchDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4518343-c764-4121-a416-fbbdfb6fd69f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
