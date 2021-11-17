using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Rasu : Template
    {
        public static readonly Guid ID = Guid.Parse("aa84b414-f7b1-4c12-9125-11b413840240");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Rasu"
            };
        }
    }
}
