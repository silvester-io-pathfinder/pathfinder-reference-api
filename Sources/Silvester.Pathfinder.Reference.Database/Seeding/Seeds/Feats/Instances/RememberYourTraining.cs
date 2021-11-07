using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RememberYourTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("c0f6bd0d-003b-4738-8358-99b61f596ed0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Remember Your Training",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4aa75054-0c58-4e76-95d0-29cec5fac918"), Type = TextBlockType.Text, Text = "During your training to become a Pathfinder Agent you were schooled on a wide variety of creatures you might encounter, and you can think back to that training to gain crucial insight in times of need. Attempt a check to (action: Recall Knowledge) about a creature you can see, adding your level as a proficiency bonus if you are untrained (rather than 0). If you roll a failure (but not a critical failure) on this check, you get a success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1f5a18e6-a0bc-4658-a49c-e6f040815992"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5aadd64e-b7c0-48cc-abaa-a27dc722f387"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
