using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances
{
    public class Indulgence : Template
    {
        public static readonly Guid ID = Guid.Parse("7463725f-9db1-45ce-8bde-57857ab6a2f9");

        protected override Domain GetDomain()
        {
            return new Domain 
            {
                Id = ID, 
                Name = "Indulgence", 
                Description = "You feast mightily and can shake off the effects of overindulging." 
            };
        }
    }
}
