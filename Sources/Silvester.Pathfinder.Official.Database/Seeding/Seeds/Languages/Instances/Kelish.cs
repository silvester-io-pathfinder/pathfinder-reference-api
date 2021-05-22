using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Kelish : Template
    {
        public static readonly Guid ID = Guid.Parse("5bc03f6e-2b88-40f0-abde-fb539995f28b");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Kelish" 
            };
        }
    }
}
