using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DreamMay : Template
    {
        public static readonly Guid ID = Guid.Parse("d25d3229-4947-4ab7-959b-095c41822b9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dream May",
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
            yield return new TextBlock { Id = Guid.Parse("2c373229-50e1-48f7-832c-544ffddb5f5b"), Type = TextBlockType.Text, Text = "You are the child of a night hag, making one of your eyes violet or even black. Your mother&#39;s powers over sleep and dreams have given you a degree of resistance to those effects, granting you a +2 circumstance bonus to all saving throws against (trait: sleep) effects and effects that cause or alter dreams." };
            yield return new TextBlock { Id = Guid.Parse("69f7f217-1ed2-4950-8f0c-e3c258199ade"), Type = TextBlockType.Text, Text = "In addition, sleep is more restorative for you. You regain HP equal to your Constitution modifier times double your level instead of just times your level, and you reduce any drained and doomed conditions you have by 2 instead of by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b2a8c0a-f7eb-4629-8148-e191d755ec88"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
