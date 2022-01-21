using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.HarrowModes.Instances
{
    public class Misaligned : Template
    {
        public static readonly Guid ID = Guid.Parse("76cbb488-0f3e-4760-aaa4-fec1d1f1dca4");

        protected override HarrowMode GetHarrowMode()
        {
            return new HarrowMode
            {
                Id = ID,
                Name = "Misaligned"
            }; 
        }
    }
}
