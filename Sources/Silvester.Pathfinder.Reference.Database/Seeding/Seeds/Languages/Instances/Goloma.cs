using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Goloma : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Goloma"
            };
        }
    }
}
