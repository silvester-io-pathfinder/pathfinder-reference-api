using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneMillimeterPunch : Template
    {
        public static readonly Guid ID = Guid.Parse("75e393f8-9ea3-40ed-81ea-00e990ba51f0");

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
            yield return new TextBlock { Id = Guid.Parse("c966b985-c1e8-4725-81c6-d1ec92f67b45"), Type = TextBlockType.Text, Text = "Your punches have incredible force and control. When you damage a target using (feat: One-Inch Punch), you can focus your ki to send the foe flying. If you do, the target must attempt a Fortitude save against your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("98e5ea65-cc84-445b-a69b-3d4c95d0154b"), Feats.Instances.OneInchPunch.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("fe6f72d7-5447-4451-890e-3a6210abc467"),
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
                Id = Guid.Parse("be2da39a-0878-4b0c-9f40-f45da009e82e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
