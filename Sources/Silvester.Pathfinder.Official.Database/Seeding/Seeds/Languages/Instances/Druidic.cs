using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Druidic : Template
    {
        public static readonly Guid ID = Guid.Parse("7064cfb4-d8a2-41f4-8c6b-b7ffb1a7f0c4");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Secret.ID,
                Name = "Druidic"
            };
        }
    }
}
