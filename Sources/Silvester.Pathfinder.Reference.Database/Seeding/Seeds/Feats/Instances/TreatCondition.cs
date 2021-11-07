using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TreatCondition : Template
    {
        public static readonly Guid ID = Guid.Parse("e206192f-897e-486d-8422-0fb971349b48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Treat Condition",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8355c10c-9db2-47a5-bc2a-5f51d2860da7"), Type = TextBlockType.Text, Text = "You treat an adjacent creature in an attempt to reduce the clumsy, enfeebled, or sickened condition. If a creature has multiple conditions from this list, choose one. Attempt a counteract check against the condition, using your Medicine modifier as your counteract modifier and the condition’s source to determine the DC. You can’t treat a condition that came from an artifact or effect above 20th level unless you have (feat: Legendary Medic); even if you do, the counteract DC increases by 10. Treating a Condition that is continually applied under certain circumstances (for instance, the enfeebled condition a good character gains from carrying an (item: unholy | Unholy Runestone) weapon) has no effect as long as the circumstances continue." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("053d0d94-95a0-4b66-9247-b913cb801657"), Feats.Instances.MedicDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2622b76e-e5f3-4dc6-a185-08bbe840a9e5"),
                CriticalSuccess = "Reduce the condition value by 2.",
                Success = "Reduce the condition value by 1.",
                
                CriticalFailure = "Increase the condition value by 1.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71bb8311-9702-4cc2-9c73-13f361fd0a74"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
