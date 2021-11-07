using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmergencyMedicalAssistance : Template
    {
        public static readonly Guid ID = Guid.Parse("0b1363f4-1c76-4110-8df9-bbe333f3b5ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emergency Medical Assistance",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e03a8c92-4060-4635-994c-7a5dcb1c834b"), Type = TextBlockType.Text, Text = "You&#39;ve learned a variety of methods for helping allies who are bleeding, burning, or otherwise suffering persistent damage, from brushing off acid to patting down fires. Your ally immediately attempts a flat check to remove all types of persistent damage, and your use of this feat automatically counts as especially effective aid, reducing the DC from 15 to 10 for all future flat checks to remove the persistent damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4a66d4d5-8727-44e9-bce1-0fe48ab454af"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("05d7c946-136b-479c-8b1d-903b2f4623b4"), Proficiencies.Instances.Master.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73800393-b5dd-467a-8c57-8bf696165c38"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
