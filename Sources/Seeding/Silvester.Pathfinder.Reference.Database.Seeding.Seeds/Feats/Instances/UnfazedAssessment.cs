using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnfazedAssessment : Template
    {
        public static readonly Guid ID = Guid.Parse("1fb5a89c-80c6-4c00-9be8-5d456063a402");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unfazed Assessment",
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
            yield return new TextBlock { Id = Guid.Parse("ad20e7de-1898-4bb3-a095-7ff80228667f"), Type = TextBlockType.Text, Text = $"You have witnessed hundreds of fighting styles and quickly adapt to defend against complicated maneuvers. Choose a creature within 30 feet who you're aware of, and attempt a Perception check against that target's Will DC. If you succeed, you size up their fighting style, gaining a +1 circumstance bonus to AC and saving throws against that creature's attacks (or a +2 circumstance bonus for a critical success). These benefits last until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8e736080-ecc8-483a-8249-40cd22d1c5e1"), Feats.Instances.ZephyrGuardDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a1cfeecf-0850-41e0-ab17-67185e62d9bc"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06984bbe-f02b-416c-bb6e-cd7a7c01d368"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
