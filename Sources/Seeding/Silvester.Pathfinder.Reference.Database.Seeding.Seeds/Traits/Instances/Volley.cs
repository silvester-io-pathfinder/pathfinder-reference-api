using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Volley : Template
    {
        public static readonly Guid ID = Guid.Parse("89c21324-64de-4cd1-9b31-c8e3382b9c91");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Volley",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa95f947-dc06-490a-a9f4-e08723546274"), Type = TextBlockType.Text, Text = "This ranged weapon is less effective at close distances. Your attacks against targets that are at a distance within the range listed take a –2 penalty." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2655ed35-7997-4242-9fb3-8bb6c65a93e8"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
