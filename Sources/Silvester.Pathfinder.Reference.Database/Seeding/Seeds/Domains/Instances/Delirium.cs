using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Delirium : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Domain GetDomain()
        {
            return new Domain 
            { 
                Id = ID, 
                Name = "Delirium", 
                Description = "You can bring about hallucinations and restlessness."
            };
        }
    }
}
