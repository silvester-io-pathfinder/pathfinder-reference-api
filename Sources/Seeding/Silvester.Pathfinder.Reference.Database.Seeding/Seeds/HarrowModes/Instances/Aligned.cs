using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowModes.Instances
{
    public class Aligned : Template
    {
        public static readonly Guid ID = Guid.Parse("44362d6c-d148-4d67-a102-0ab1ba11d3fb");

        protected override HarrowMode GetHarrowMode()
        {
            return new HarrowMode
            {
                Id = ID,
                Name = "Aligned"
            }; 
        }
    }
}
