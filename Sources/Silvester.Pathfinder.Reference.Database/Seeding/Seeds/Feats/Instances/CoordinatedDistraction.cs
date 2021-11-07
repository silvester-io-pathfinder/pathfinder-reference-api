using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoordinatedDistraction : Template
    {
        public static readonly Guid ID = Guid.Parse("849394aa-af64-4325-a9c0-b8bb9143a4da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Coordinated Distraction",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("02dbbc98-a9d0-4328-b3ac-2aaec45c557e"), Type = TextBlockType.Text, Text = "~ Access: Help either the Washboard Dogs or the Diobel Sweepers destroy their rival." };
            yield return new TextBlock { Id = Guid.Parse("9034f339-33cd-4127-b62f-c372c21355d0"), Type = TextBlockType.Text, Text = "With a sharp whistle or wave of your hands, you distract an opponent from the fact that one of your allies is about to attack them. Choose a target and an ally, both of whom must be within 30 feet. The target is flat-footed against the first (action: Strike) the ally makes on their next turn; if your ally doesn&#39;t (action: Strike) that target, the effect is lost. Depending on how you describe your distraction, this action gains either the (trait: auditory) or (trait: visual) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87b61f0f-fc84-4cc8-a207-71d3b8331079"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
