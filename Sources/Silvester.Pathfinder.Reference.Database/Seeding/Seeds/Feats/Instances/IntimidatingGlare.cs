using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntimidatingGlare : Template
    {
        public static readonly Guid ID = Guid.Parse("c42acf4e-6d77-4d54-96cb-680125394a75");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intimidating Glare",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bfead698-bc3c-4791-9269-7d5a7e72a382"), Type = TextBlockType.Text, Text = "You can (action: Demoralize) with a mere glare. When you do, (action: Demoralize) loses the (trait: auditory) trait and gains the (trait: visual) trait, and you don’t take a penalty if the creature doesn’t understand your language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("148599e8-7810-49a1-99c2-059e4915b340"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9187baf6-bb45-4f37-a369-b6aab1521fd4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
