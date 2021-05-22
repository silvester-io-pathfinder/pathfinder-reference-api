using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.LanguageTypes.Instances
{
    public class Common : Template
    {
        public static readonly Guid ID = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac");

        protected override LanguageType GetLanguageType()
        {
            return new LanguageType 
            {
                Id = ID, 
                Name = "Common" 
            };
        }
    }
}
