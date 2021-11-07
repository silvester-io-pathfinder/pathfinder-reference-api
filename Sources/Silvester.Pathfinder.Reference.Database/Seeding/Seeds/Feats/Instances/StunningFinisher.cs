using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StunningFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("77c79e4f-e25d-46b0-b029-a23f3345ed2c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stunning Finisher",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e89f243-0391-4741-935d-3ccaa784122f"), Type = TextBlockType.Text, Text = "You attempt a dizzying blow. Make a melee (action: Strike). If you hit, your foe must attempt a Fortitude save against your class DC with the following results; the save has the (trait: incapacitation) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("eff48f3a-d049-4100-ad0c-4eb495ffeb20"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target can’t use reactions until its next turn.",
                Failure = "The target is stunned 1.",
                CriticalFailure = "The target is stunned 3.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b128ed2-b1dc-4460-926b-8905f5c8d172"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
