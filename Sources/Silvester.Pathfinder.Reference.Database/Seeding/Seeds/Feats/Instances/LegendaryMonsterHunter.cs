using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryMonsterHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("845d6957-b1bb-4476-aad4-ed4f45451113");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Monster Hunter",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6084793-fc18-4f30-af73-0367ee237e80"), Type = TextBlockType.Text, Text = "Your knowledge of monsters is so incredible that it reveals glaring flaws in your prey. Your bonus from (feat: Monster Hunter) (and the bonus from (feat: Monster Warden) if you have it) increases from +1 to +2 for you and any allies who benefit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d391b317-6a2c-423d-a67a-2387a92f09bf"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
            builder.HaveSpecificFeat(Guid.Parse("b1eebecd-c863-4068-883a-db38d39e3524"), Feats.Instances.MasterMonsterHunter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db5ab6a6-2081-4f5a-840f-0b2ae8ca734a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
