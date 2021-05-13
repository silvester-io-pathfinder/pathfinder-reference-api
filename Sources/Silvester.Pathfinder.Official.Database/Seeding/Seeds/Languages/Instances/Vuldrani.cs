using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Vuldrani : Template
    {
        public static readonly Guid ID = Guid.Parse("70fb4b94-4ba8-4f1f-82ed-e160ce7eb99d");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Vuldrani" 
            };
        }
    }
}
