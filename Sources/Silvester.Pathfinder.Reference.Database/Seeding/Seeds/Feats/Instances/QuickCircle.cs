using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickCircle : Template
    {
        public static readonly Guid ID = Guid.Parse("a5b982e6-b4a1-4e86-8847-1409757bcc31");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Circle",
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
            yield return new TextBlock { Id = Guid.Parse("1c87cff9-0225-4219-a091-80cbb63de456"), Type = TextBlockType.Text, Text = "Long hours of practice and an instinctive understanding of boundaries lets you create protective circles impossibly quickly. As you fling your esoterica during a quick spin, you find that everything falls in a perfect circle each time. You can (feat: Draw a Warding Circle|Draw Warding Circle) as a three-action activity, instead of taking 1 minute to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7faa7c0a-d050-4701-a05a-de0b1f1f0bdf"), Feats.Instances.DrawWardingCircle.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b1cd45b-33ac-4734-8b4c-bcc6f4d7eafc"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
