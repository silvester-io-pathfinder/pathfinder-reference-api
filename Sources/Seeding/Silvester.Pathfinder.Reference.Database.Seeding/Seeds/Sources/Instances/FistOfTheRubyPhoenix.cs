using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class FistOfTheRubyPhoenix : Template
    {
        public static readonly Guid ID = Guid.Parse("6578c457-f0d9-4771-938e-b8c51a9de6a8");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Fist of the Ruby Phoenix"
            };
        }
    }
}
