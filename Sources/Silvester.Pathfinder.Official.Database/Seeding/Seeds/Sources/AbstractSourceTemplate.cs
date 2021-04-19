using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources
{
    public abstract class AbstractSourceTemplate
    {
        public void Seed(SourceSeeder seeder)
        {
            Source source = GetSource();
            seeder.Builder.AddData(source);
        }

        protected abstract Source GetSource();
    }
}
