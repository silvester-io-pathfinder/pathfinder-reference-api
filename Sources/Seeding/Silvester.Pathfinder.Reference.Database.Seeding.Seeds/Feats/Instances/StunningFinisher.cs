using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StunningFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("7bce70cd-d0b3-418a-af0d-5987e299af76");

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
            yield return new TextBlock { Id = Guid.Parse("c13d9520-4fac-40a7-bdb4-f3ff2f59feed"), Type = TextBlockType.Text, Text = "You attempt a dizzying blow. Make a melee (action: Strike). If you hit, your foe must attempt a Fortitude save against your class DC with the following results; the save has the (trait: incapacitation) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c6282236-0e72-4910-a5e5-8ba78c5f17bd"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target can't use reactions until its next turn.",
                Failure = "The target is stunned 1.",
                CriticalFailure = "The target is stunned 3.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3d58819-d94b-4af0-9b7f-92d65ee66753"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
