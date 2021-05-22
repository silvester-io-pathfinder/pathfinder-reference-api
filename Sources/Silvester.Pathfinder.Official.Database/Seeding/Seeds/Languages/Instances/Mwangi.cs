using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Mwangi : Template
    {
        public static readonly Guid ID = Guid.Parse("981794a7-f756-4894-b903-2ed948b580be");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Mwangi" 
            };
        }
    }
}
