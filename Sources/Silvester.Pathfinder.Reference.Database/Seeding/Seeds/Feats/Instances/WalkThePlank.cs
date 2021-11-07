using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WalkThePlank : Template
    {
        public static readonly Guid ID = Guid.Parse("43932232-8a92-44bf-b67c-05ac232902de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Walk the Plank",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e98c003b-7c60-4b3a-a989-50d0a52427a4"), Type = TextBlockType.Text, Text = "You frighten a foe into moving where you want them, traditionally demanding they walk the plank. Attempt to (action: Demoralize) an opponent; this check gains the (trait: incapacitation) trait. On a success, in addition to the normal effects, you can also force the target to (action: Stride) up to its Speed. You choose the path the target takes, and it does so as part of your Walk the Plank action. You can’t force the target to move into a harmful space (one where it will take damage, fall, provoke reactions, or similar) unless the result of your check to (action: Demoralize) was a critical success. The target then becomes temporarily immune to Walk the Plank for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("67e050a4-1618-40dc-ae2d-d2cf3f4b1ec3"), Feats.Instances.PirateDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f340aa85-b7bf-4e64-b919-6e6c0e219667"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
