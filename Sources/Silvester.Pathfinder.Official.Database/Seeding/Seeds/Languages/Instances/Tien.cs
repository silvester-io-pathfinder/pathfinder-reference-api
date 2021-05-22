using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Tien : Template
    {
        public static readonly Guid ID = Guid.Parse("a025c8bf-03d7-44cf-8571-444a80799ab6");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Tien" 
            };
        }
    }
}
