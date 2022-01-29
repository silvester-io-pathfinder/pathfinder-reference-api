using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneMillimeterPunch : Template
    {
        public static readonly Guid ID = Guid.Parse("4624f10b-4ce6-43db-970e-0712705e931f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One-Millimeter Punch",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7bf64de2-ea39-4610-b4f2-961052c69d73"), Type = TextBlockType.Text, Text = $"Your punches have incredible force and control. When you damage a target using {ToMarkdownLink<Models.Entities.Feat>("One-Inch Punch", Feats.Instances.OneInchPunch.ID)}, you can focus your ki to send the foe flying. If you do, the target must attempt a Fortitude save against your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3b506df7-19a0-42cc-9ecf-82c9ca081058"), Feats.Instances.OneInchPunch.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("89fa7305-6f23-4158-b1cf-491d596734a5"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is pushed back 5 feet.",
                Failure = "The target is pushed back 10 feet.",
                CriticalFailure = "The target is pushed back 10 feet for each action you spent on (feat: One-Inch Punch).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c407d48-f214-4271-9526-a6506a2b27de"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
