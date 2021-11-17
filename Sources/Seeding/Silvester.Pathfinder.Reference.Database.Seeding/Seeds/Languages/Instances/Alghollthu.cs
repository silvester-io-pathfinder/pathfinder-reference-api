using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Alghollthu : Template
    {
        public static readonly Guid ID = Guid.Parse("25eb413d-e8fc-47d6-9126-3a42efdc9656");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Alghollthu"
            };
        }
    }
}
