using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedKnockback : Template
    {
        public static readonly Guid ID = Guid.Parse("dfea29a0-d3af-46c6-8e01-27adff7f7d0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Knockback",
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
            yield return new TextBlock { Id = Guid.Parse("1bc7f605-f258-4220-bcfb-7b327c1632ba"), Type = TextBlockType.Text, Text = "When you successfully (action: Shove) a creature, increase both the distance you can push the creature and the distance you can move to follow along with the target by 5 feet on a success or 10 feet on a critical success. If you push the target into an obstacle, it takes bludgeoning damage equal to 6 plus your Strength modifier, or 8 plus your Strength modifier if you&#39;re legendary in Athletics." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ad417e8b-0461-4916-a392-2a8840f46b45"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23f6b4a4-db0c-40af-82a0-593e52bae5ce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
