using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class LostOmensSocietyGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("1dea2280-df22-49d3-b62b-985853818555");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Lost Omens - Society Guide"
            };
        }
    }
}
