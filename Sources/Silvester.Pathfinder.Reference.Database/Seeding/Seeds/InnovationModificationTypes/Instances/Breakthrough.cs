using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModificationTypes.Instances
{
    public class Breakthrough : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override InnovationModificationType GetInnovationModificationType()
        {
            return new InnovationModificationType
            {
                Id = ID, 
                Name = "Breakthrough",
            };
        }
    }
}
