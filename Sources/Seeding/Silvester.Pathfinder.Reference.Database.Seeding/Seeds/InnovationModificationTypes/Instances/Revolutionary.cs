using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModificationTypes.Instances
{
    public class Revolutionary : Template
    {
        public static readonly Guid ID = Guid.Parse("628936ad-5080-4cda-aeb9-fff466e7b7a0");
        
        protected override InnovationModificationType GetInnovationModificationType()
        {
            return new InnovationModificationType
            {
                Id = ID, 
                Name = "Revolutionary",
            };
        }
    }
}
