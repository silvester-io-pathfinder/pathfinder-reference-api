using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExplosiveDeathDrop : Template
    {
        public static readonly Guid ID = Guid.Parse("4e82f647-ea0a-4704-b34a-8a4cd55af49f");

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
            yield return new TextBlock { Id = Guid.Parse("d2625466-0cd5-45e5-870d-59fc72e84f0f"), Type = TextBlockType.Text, Text = "You lift your enemy into the air before bringing them crashing down with a fiery detonation. Roll an Athletics check against your target&#39;s Fortitude DC. You take a -1 circumstance penalty to your check if the target is one size larger than you and a -3 circumstance penalty if it&#39;s larger than that. You gain a +1 circumstance bonus to your check if the target is one size smaller than you and a +3 circumstance bonus if it&#39;s smaller than that." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6bba518e-daec-4880-bb00-adc84bed475c"), Feats.Instances.BlazingTalonSurge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("510dced4-cc6b-4ecb-9bcf-194f4c84b1a9"),
                CriticalSuccess = "The target takes 12d6 fire damage and falls prone in an unoccupied adjacent square of your choice. The target is no longer grabbed. The target and any creature adjacent to it also each take 1d6 persistent fire damage.",
                Success = "As critical success, but the target takes 6d6 fire damage instead of 12d6, and creatures don&#39;t take persistent fire damage.",
                Failure = "The target is no longer grabbed.",
                CriticalFailure = "As failure, but you fall prone.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1518179d-fc60-4602-95c6-ce5171bb0703"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
