using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class LostOmensAncestryGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("7ed10ef3-6225-4347-a079-8031795c624d");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Lost Omens - Ancestry Guide"
            };
        }
    }
}
