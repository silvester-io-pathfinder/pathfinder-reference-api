using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Shoony : Template
    {
        public static readonly Guid ID = Guid.Parse("bc10dcd0-029b-4453-b9d7-beb25f7eb0f6");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Shoony"
            };
        }
    }
}
