using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertSorcererSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("32da44b2-1d90-4460-9e71-6ff26585cbd4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Sorcerer Spellcasting",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f7833a5-3f4b-4397-ab80-9c0b903c365d"), Type = TextBlockType.Text, Text = "Your proficiency ranks for your bloodline&#39;s spell attack rolls and spell DCs increase to expert, and you gain a 4th-level spell slot. You can select a second spell from your repertoire as a signature spell. At 14th level, you gain a 5th-level spell slot, and at 16th level, you gain a 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8840ff09-1ae6-4a5a-be9d-5cc31112b09a"), Feats.Instances.BasicSorcererSpellcasting.ID);
            builder.AddOr(Guid.Parse("d371cb0b-4437-44f5-a4de-ddd0ae793511"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("8fa22be4-15d1-48de-af3a-dabaa7f15b23"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("680955fe-ba77-480b-948d-931e2a5e44df"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("061f08ad-7c92-4968-b4bb-2e7a93a06ea6"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("694ea29a-926a-4957-80dd-6cb4a5e5ce2b"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            });
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("805baa48-9678-422c-919c-38d68e0d893e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
