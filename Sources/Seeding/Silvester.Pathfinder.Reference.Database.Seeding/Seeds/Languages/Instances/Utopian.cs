using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Utopian : Template
    {
        public static readonly Guid ID = Guid.Parse("c173f9c7-9fb8-40b7-842f-978bce14a646");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Utopian"
            };
        }
    }
}
