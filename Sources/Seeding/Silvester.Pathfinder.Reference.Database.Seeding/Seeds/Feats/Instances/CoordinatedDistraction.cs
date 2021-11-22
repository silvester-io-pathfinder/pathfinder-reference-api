using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoordinatedDistraction : Template
    {
        public static readonly Guid ID = Guid.Parse("bef868e5-00ca-4869-b660-2fe1f55f4386");

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
            yield return new TextBlock { Id = Guid.Parse("b0470b6d-1154-4d6f-8057-6c3294cd58f1"), Type = TextBlockType.Text, Text = "~ Access: Help either the Washboard Dogs or the Diobel Sweepers destroy their rival." };
            yield return new TextBlock { Id = Guid.Parse("1c331d67-8ad0-486f-931e-b72118bc27a9"), Type = TextBlockType.Text, Text = "With a sharp whistle or wave of your hands, you distract an opponent from the fact that one of your allies is about to attack them. Choose a target and an ally, both of whom must be within 30 feet. The target is flat-footed against the first (action: Strike) the ally makes on their next turn; if your ally doesn't (action: Strike) that target, the effect is lost. Depending on how you describe your distraction, this action gains either the (trait: auditory) or (trait: visual) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9bf4b95-9ba0-4161-be84-2e0ac08e6337"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
