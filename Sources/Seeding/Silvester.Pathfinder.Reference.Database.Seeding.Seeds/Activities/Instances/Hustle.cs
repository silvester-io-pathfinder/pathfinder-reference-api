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
    public class Hustle : Template
    {
        public static readonly Guid ID = Guid.Parse("195830db-7462-4b8d-8210-21f1e29795d6");
        
        protected override Activity GetActivity()
        {
            return new Activity
            {
                Id = ID, 
                Name = "Hustle",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("76a33278-f39f-445d-bcf4-68ed8ede02a7"), Type = TextBlockType.Text, Text = "You strain yourself to move at double your travel speed. You can Hustle only for a number of minutes equal to your Constitution modifier x 10 (minimum 10 minutes). If you are in a group that is Hustling, use the lowest Constitution modifier among everyone to determine how fast the group can Hustle together." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Move.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac17cf9d-2e60-4088-8bed-08c920992b71"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 480
            };
        }
    }
}
