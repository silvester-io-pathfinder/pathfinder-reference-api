using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Skald : AbstractLanguageTemplate
    {
        public static readonly Guid ID = Guid.Parse("47f3cc11-d37c-4d58-908e-7d7f71d190ca");

        protected override Language GetLanguage()
        {
            return new Language 
            {
                Id = ID, 
                TypeId = LanguageTypes.Instances.Regional.ID, 
                Name = "Skald" 
            };
        }
    }
}
