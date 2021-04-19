using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class CoreRulebook : AbstractSourceTemplate
    {
        public static readonly Guid ID = Guid.Parse("4e85ec44-4a72-4bea-a3e5-5e6d88882d75");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Core Rulebook"
            };
        }
    }
}
