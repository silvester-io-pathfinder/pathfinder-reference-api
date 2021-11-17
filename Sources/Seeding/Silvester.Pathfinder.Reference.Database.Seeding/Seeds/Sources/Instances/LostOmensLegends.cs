using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class LostOmensLegends : Template
    {
        public static readonly Guid ID = Guid.Parse("dfde56c0-8936-4f25-8c26-53887048efd0");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Lost Omens - Legends"
            };
        }
    }
}
