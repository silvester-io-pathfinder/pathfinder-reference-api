using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnapOutOfIt : Template
    {
        public static readonly Guid ID = Guid.Parse("e820f6f5-f80a-45ba-b164-836a9de2ddcc");

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
            yield return new TextBlock { Id = Guid.Parse("d96a451a-47d2-434e-ad63-d931853ef726"), Type = TextBlockType.Text, Text = $"Pathfinders are trained to help each other be safe and successful, and you know how to jolt your allies back to their senses. Attempt a Medicine check on an adjacent ally who is fascinated, frightened, stunned, or stupefied and choose one of those conditions. The DC is the DC for the effect that caused the condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("571a19e8-fa5b-4752-acc8-9d4ee55eb5e1"), Proficiencies.Instances.Master.ID, Skills.Instances.Medicine.ID);
            builder.HaveSpecificFeat(Guid.Parse("9ec696b8-44c4-4949-a245-18fa74f0f1e2"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("78a08bb8-72d7-4ec6-8ecf-ff150e858296"),
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
                Id = Guid.Parse("4695c0d7-7d2c-4757-ac12-a2768e1f946e"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
