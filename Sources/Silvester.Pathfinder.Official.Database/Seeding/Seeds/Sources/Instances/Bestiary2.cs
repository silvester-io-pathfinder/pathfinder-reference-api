using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Bestiary2 : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("51f273bd-9c56-4a21-82ca-df90e1e13955");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Bestiary 2"
            };
        }
    }
}
