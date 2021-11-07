using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnapOutOfIt : Template
    {
        public static readonly Guid ID = Guid.Parse("4cbd0cef-a5e8-414f-b685-73c71d130502");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snap Out of It!",
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
            yield return new TextBlock { Id = Guid.Parse("79be941f-a2ba-4ddc-a820-5da4c5f3272d"), Type = TextBlockType.Text, Text = "Pathfinders are trained to help each other be safe and successful, and you know how to jolt your allies back to their senses. Attempt a Medicine check on an adjacent ally who is fascinated, frightened, stunned, or stupefied and choose one of those conditions. The DC is the DC for the effect that caused the condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f22dd20a-1737-496e-be50-97a6ef8f179f"), Proficiencies.Instances.Master.ID, Skills.Instances.Medicine.ID);
            builder.HaveSpecificFeat(Guid.Parse("5d4d6166-c83b-4f0a-805e-597ba6b274d0"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("5066120d-7bf5-45fa-a0e5-411fba19cdb1"),
                CriticalSuccess = "Reduce the value of the chosen condition by 2. If you chose fascinated, that condition ends.",
                Success = "Reduce the value of the chosen condition by 1. If you chose fascinated, that condition ends.",
                Failure = "The target is unaffected.",
                CriticalFailure = "You increase the value of the chosen condition by 1. If you chose fascinated, increase the duration by 1 round instead.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a34dad9-16db-466c-9453-d55d7253aff1"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
