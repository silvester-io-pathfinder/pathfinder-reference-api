using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class CharacterGuide : AbstractSourceTemplate
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
