using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Skald : Template
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
