using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class ExtinctionCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("96bd5b2f-0168-4192-9a5c-05c24b52c659");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Extinction Curse"
            };
        }
    }
}
