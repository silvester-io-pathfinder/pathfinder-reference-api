using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExplosiveLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("f57f8016-e598-4677-8f53-ca425ca6ddca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explosive Leap",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this action rather than you.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("471d2208-fa94-4f97-9985-744b18f2c921"), Type = TextBlockType.Text, Text = "You aim an explosion from your innovation downward to launch yourself into the air. You jump up to 30 feet in any direction without touching the ground. You must land on a space of solid ground, or else you fall after using your next action. As normal for effects where you fall after using your next action, you still fall at the end of your turn, even if you don’t use any further actions that turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40ca74b0-d6e7-48e0-bc7e-43830ba086f7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
