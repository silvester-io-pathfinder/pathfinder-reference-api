using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterSorcererSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("ee308085-fad9-4271-adb9-a4fd2a17dfb8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Sorcerer Spellcasting",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ede7a02d-a641-4771-9d07-961210faf027"), Type = TextBlockType.Text, Text = "Your proficiency ranks for your bloodline&#39;s spell attack rolls and spell DCs increase to master, and you gain a 7th-level spell slot. You can select a third spell from your repertoire as a signature spell. At 20th level, you gain an 8th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dcd2fd4a-6e02-4aaa-8dec-3e78b988bb14"), Feats.Instances.ExpertSorcererSpellcasting.ID);
            builder.AddOr(Guid.Parse("6382ff4c-05cb-4351-b9ee-45871b14cdd1"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("af297e60-9901-4c49-8006-450fced5939d"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("2e03f7f5-9e90-4b72-8b36-ee1eaf541311"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("2e75a8fa-60a6-4b51-8ec5-219be26cbae6"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("483e7de3-211f-4e7a-a41d-e8f355f975d9"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Religion.ID);
                //TODO: Add prerequisites.
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89220e05-a03d-4322-9b2b-442391d03a9f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
