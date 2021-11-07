using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FalseFaith : Template
    {
        public static readonly Guid ID = Guid.Parse("700b73d7-d485-46f3-a8b6-7c97575dfd44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "False Faith",
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
            yield return new TextBlock { Id = Guid.Parse("38bd8cdb-9ef4-4491-91cd-37fc3034a747"), Type = TextBlockType.Text, Text = "Droskar knows you may need to disguise yourself in societies that oppose your faith. After spending 1 hour in prayer to Droskar, you can cast spells using the religious symbol of a different deity as your divine focus, and you can address verbal prayers to that deity. Droskar intercepts your prayers and answers them without the named god knowing." };
            yield return new TextBlock { Id = Guid.Parse("55c5f1dc-5242-4cd2-b289-1466a8a72a82"), Type = TextBlockType.Text, Text = "This ability applies to the religious symbol of only one god at a time – making a different religious symbol work in this fashion requires another hour of prayer and causes the old one to cease functioning. You can always use a religious symbol of Droskar without affecting this ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.WorshipSpecificDeity(Guid.Parse("cdea8bd1-3cba-45c3-8cd3-8ddcc195ec45"), Deities.Instances.Droskar.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("032ed5e5-0855-48a1-a46b-38ae589b27a2"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
