using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class FriendsInHighPlaces : Template
    {
        public static readonly Guid ID = Guid.Parse("b5faf7f3-cbbd-472c-be63-4066efa601d9");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Friends in High Places"
            };
        }
    }
}
