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
    public class Defend : Template
    {
        public static readonly Guid ID = Guid.Parse("aa1cb744-bbd9-4840-8451-007fb47fcae6");
        
        protected override Activity GetActivity()
        {
            return new Activity
            {
                Id = ID, 
                Name = "Defend",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c8a8547b-f77d-4919-91fd-e9720f5e44c5"), Type = TextBlockType.Text, Text = "You move at half your travel speed with your shield raised. If combat breaks out, you gain the benefits of Raising a Shield before your first turn begins." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c9f5b39-9115-46a2-98d2-fb9111878c81"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 479
            };
        }
    }
}
