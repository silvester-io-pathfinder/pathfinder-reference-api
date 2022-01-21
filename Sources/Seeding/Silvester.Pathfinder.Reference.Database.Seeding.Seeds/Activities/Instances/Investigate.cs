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
    public class Investigate : Template
    {
        public static readonly Guid ID = Guid.Parse("d8259461-78d6-4a40-820b-7c963657cbc9");
        
        protected override Activity GetActivity()
        {
            return new Activity
            {
                Id = ID, 
                Name = "Investigate",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8c3b5550-3ce2-4d7e-9419-d2da6723f8b0"), Type = TextBlockType.Text, Text = "You seek out information about your surroundings while traveling at half speed. You use Recall Knowledge as a secret check to discover clues among the various things you can see and engage with as you journey along. You can use any skill that has a Recall Knowledge action while Investigating, but the GM determines whether the skill is relevant to the clues you could find." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cae0c0db-7da3-475b-9539-436acd11ded7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 480
            };
        }
    }
}
