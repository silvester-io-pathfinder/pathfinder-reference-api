using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Osiriani : AbstractLanguageTemplate
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
