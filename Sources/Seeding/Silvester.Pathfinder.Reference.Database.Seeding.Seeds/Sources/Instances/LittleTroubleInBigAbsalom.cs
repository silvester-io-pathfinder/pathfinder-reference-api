using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class LittleTroubleInBigAbsalom : Template
    {
        public static readonly Guid ID = Guid.Parse("101add5d-ead2-453b-b38f-95c69a0541b6");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Little Trouble in Big Absalom"
            };
        }
    }
}
