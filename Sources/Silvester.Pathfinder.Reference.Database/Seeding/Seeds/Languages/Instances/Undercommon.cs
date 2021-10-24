using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Undercommon : Template
    {
        public static readonly Guid ID = Guid.Parse("8700ff4d-89af-4d17-add5-381f3d595682");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Undercommon"
            };
        }
    }
}
