using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Requian : Template
    {
        public static readonly Guid ID = Guid.Parse("1a1ef296-745c-4fa3-b480-15f76e8d7c1f");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Requian"
            };
        }
    }
}
