using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Osiriani : Template
    {
        public static readonly Guid ID = Guid.Parse("00ff0a21-2e5d-4b6b-b6ba-ddeaf331c464");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Osiriani" 
            };
        }
    }
}
