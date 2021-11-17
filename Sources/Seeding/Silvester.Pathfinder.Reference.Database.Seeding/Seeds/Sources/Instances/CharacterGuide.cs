using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class CharacterGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("8026612e-b2dc-42d2-8844-bb0bc63c0249");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Character Guide"
            };
        }
    }
}
