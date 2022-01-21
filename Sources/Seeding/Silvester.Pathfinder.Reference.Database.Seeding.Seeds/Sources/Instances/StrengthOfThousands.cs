using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class StrengthOfThousands : Template
    {
        public static readonly Guid ID = Guid.Parse("109a1fa1-0dec-4359-8c6a-9ae007f159c7");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Strength of Thousands"
            };
        }
    }
}
