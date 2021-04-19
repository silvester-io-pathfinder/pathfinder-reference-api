using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Custom : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("f81a5e37-0ec8-443d-924b-75769a2d321b");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Custom"
            };
        }
    }
}
