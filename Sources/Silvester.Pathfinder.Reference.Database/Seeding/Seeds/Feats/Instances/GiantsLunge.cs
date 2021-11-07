using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GiantsLunge : Template
    {
        public static readonly Guid ID = Guid.Parse("20da2cd8-fe96-45b6-b5e8-166792d6c93c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Giant's Lunge",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c9ff358-c575-4993-99b2-aba178da1960"), Type = TextBlockType.Text, Text = "You extend your body and prepare to attack foes outside your normal reach. Until your rage ends, all your melee weapons and unarmed attacks gain (trait: reach 10). This doesn’t increase the reach of any weapon or unarmed attack that already has the (trait: reach) trait, but it does combine with abilities that increase your reach due to increased size, such as (feat: Giant&#39;s Stature)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("2a3de577-3b52-47be-8943-67e0c95eeddb"), Instincts.Instances.GiantInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87c7aab9-ea27-4417-b2e7-395fd5a7d337"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
