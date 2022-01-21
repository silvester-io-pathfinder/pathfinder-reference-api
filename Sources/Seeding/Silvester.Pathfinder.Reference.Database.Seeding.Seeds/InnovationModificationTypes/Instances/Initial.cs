using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModificationTypes.Instances
{
    public class Initial : Template
    {
        public static readonly Guid ID = Guid.Parse("beb10e57-1037-446d-9e2a-0f65b36b64aa");
        
        protected override InnovationModificationType GetInnovationModificationType()
        {
            return new InnovationModificationType
            {
                Id = ID, 
                Name = "Initial",
            };
        }
    }
}
