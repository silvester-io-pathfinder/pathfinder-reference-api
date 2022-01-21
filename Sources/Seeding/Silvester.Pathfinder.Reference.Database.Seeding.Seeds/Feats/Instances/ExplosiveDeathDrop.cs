using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExplosiveDeathDrop : Template
    {
        public static readonly Guid ID = Guid.Parse("08be1499-f847-441c-af41-68af90778a6c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explosive Death Drop",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e1fd3e3-8cbf-4101-9394-7968aaae61b4"), Type = TextBlockType.Text, Text = "You lift your enemy into the air before bringing them crashing down with a fiery detonation. Roll an Athletics check against your target's Fortitude DC. You take a -1 circumstance penalty to your check if the target is one size larger than you and a -3 circumstance penalty if it's larger than that. You gain a +1 circumstance bonus to your check if the target is one size smaller than you and a +3 circumstance bonus if it's smaller than that." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("58810e8d-1636-4aa4-8ac9-5d0c0d2be3b0"), Feats.Instances.BlazingTalonSurge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("fa22064c-4522-4ddf-a384-3211131ed0bb"),
                CriticalSuccess = "The target takes 12d6 fire damage and falls prone in an unoccupied adjacent square of your choice. The target is no longer grabbed. The target and any creature adjacent to it also each take 1d6 persistent fire damage.",
                Success = "As critical success, but the target takes 6d6 fire damage instead of 12d6, and creatures don't take persistent fire damage.",
                Failure = "The target is no longer grabbed.",
                CriticalFailure = "As failure, but you fall prone.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eda25442-6883-43de-93b8-a273284dbdb3"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
