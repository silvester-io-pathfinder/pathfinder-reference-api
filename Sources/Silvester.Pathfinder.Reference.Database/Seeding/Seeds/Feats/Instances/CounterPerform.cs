using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CounterPerform : Template
    {
        public static readonly Guid ID = Guid.Parse("aa2a6f8f-c650-4abb-a353-2ed725b08679");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Counter Perform",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eceeab05-1370-4115-90c3-e626d2177c61"), Type = TextBlockType.Text, Text = "You gain the (spell: counter performance) composition spell. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) by engaging your muse. (For more on composition spells, see page 97.)" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("34d74852-b82a-4d0a-a6de-222fc96dabba"), Feats.Instances.BardDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("010f65db-0759-46df-8c2e-26a50dbd49a0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
