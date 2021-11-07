using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedHuntersTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("7bde21b8-433f-4905-a307-1c2891faea5b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Hunter's Trick",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time you select it, you gain another ranger feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a243637f-ac62-4c18-9749-145db1b5092c"), Type = TextBlockType.Text, Text = "You gain one ranger feat. For the purpose of meeting its prerequisites, your ranger level is equal to half your character level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8fb350c7-eed4-4709-9cc1-83ba995136e4"), Feats.Instances.BasicHuntersTrick.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb36359c-70a7-46a8-822f-3b9bc77c65a4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
