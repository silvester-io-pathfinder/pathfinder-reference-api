using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Varisian : Template
    {
        public static readonly Guid ID = Guid.Parse("0f1df7b2-68f8-41db-8800-2a72f8b41cad");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Varisian" 
            };
        }
    }
}
