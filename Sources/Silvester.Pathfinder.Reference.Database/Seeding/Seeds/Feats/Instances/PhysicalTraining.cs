using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhysicalTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("5054aaf0-4e69-40e1-9b34-6c45d30bda9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Physical Training",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fae28a89-2dfc-4497-b82d-a2108fb8fcfb"), Type = TextBlockType.Text, Text = "You spend a lot of time focusing on your physical fitness. You increase your proficiency rank in Acrobatics and Athletics from expert to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c8c6d768-2b47-4ae8-9247-1f41fdd74a70"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("fa17bd0c-a559-43e4-878f-b908fc3f5b94"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9644418c-225c-47f5-b78e-d40913885b23"), Proficiencies.Instances.Expert.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d10aa9f6-a51d-4a66-b4ba-c63457e127c1"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
