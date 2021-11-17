using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModificationTypes.Instances
{
    public class Breakthrough : Template
    {
        public static readonly Guid ID = Guid.Parse("08b6d7b5-f986-48f9-ae66-27bf272ca58c");
        
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
