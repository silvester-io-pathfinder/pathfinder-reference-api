using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CombatAssessment : Template
    {
        public static readonly Guid ID = Guid.Parse("86184829-502a-407a-81c3-29508d4027f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combat Assessment",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b54c38e2-927d-4892-a029-19d846fca23e"), Type = TextBlockType.Text, Text = "You make a telegraphed attack to learn about your foe. Make a melee (action: Strike). On a hit, you can immediately attempt a check to (action: Recall Knowledge) about the target. On a critical hit, you gain a +2 circumstance bonus to the check to (action: Recall Knowledge). The target is temporarily immune to Combat Assessment for 1 day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("727d4454-a901-441b-929e-10859e002eab"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
