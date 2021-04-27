using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Shoanti : AbstractLanguageTemplate
    {
        public static readonly Guid ID = Guid.Parse("9074da30-a817-4a7d-a260-7fc10b02513a");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Shoanti" 
            };
        }
    }
}
