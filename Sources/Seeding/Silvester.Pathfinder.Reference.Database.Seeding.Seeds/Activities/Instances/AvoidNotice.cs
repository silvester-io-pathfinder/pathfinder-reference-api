using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Activities.Instances
{
    public class AvoidNotice : Template
    {
        public static readonly Guid ID = Guid.Parse("bebbb301-f323-4941-b049-92f1909b2b7b");
        
        protected override Activity GetActivity()
        {
            return new Activity
            {
                Id = ID, 
                Name = "Avoid Notice",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("55ff8f2c-0d16-443f-8ebe-9b420475c056"), Type = TextBlockType.Text, Text = "You attempt a Stealth check to avoid notice while traveling at half speed. If you have the Swift Sneak feat, you can move at full Speed rather than half, but you still can't use another exploration activity while you do so. If you have the Legendary Sneak feat, you can move at full Speed and use a second exploration activity. If you're Avoiding Notice at the start of an encounter, you usually roll a Stealth check instead of a Perception check both to determine your initiative and to see if the enemies notice you (based on their Perception DCs, as normal for Sneak, regardless of their initiative check results)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9217de07-9c7c-4155-ac5b-3ed73aab848d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 479
            };
        }
    }
}
