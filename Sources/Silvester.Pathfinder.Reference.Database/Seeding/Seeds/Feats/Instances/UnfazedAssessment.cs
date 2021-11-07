using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnfazedAssessment : Template
    {
        public static readonly Guid ID = Guid.Parse("c5f59f04-5ab7-4412-ac71-c0650a7a2953");

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
            yield return new TextBlock { Id = Guid.Parse("7ad31e07-1d34-4caa-8532-2bef389e0bdf"), Type = TextBlockType.Text, Text = "You have witnessed hundreds of fighting styles and quickly adapt to defend against complicated maneuvers. Choose a creature within 30 feet who you’re aware of, and attempt a Perception check against that target’s Will DC. If you succeed, you size up their fighting style, gaining a +1 circumstance bonus to AC and saving throws against that creature’s attacks (or a +2 circumstance bonus for a critical success). These benefits last until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("959f92a5-e1c6-47eb-ac23-7a72c43a3913"), Feats.Instances.ZephyrGuardDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("02cb948f-8e18-4134-89f9-671b7f18c0a4"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d765c24b-f72d-4ef9-8a3a-f94de231707d"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
