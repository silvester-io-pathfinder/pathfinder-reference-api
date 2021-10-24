using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Gnomish : Template
    {
        public static readonly Guid ID = Guid.Parse("6582bcfc-19d6-4b4d-9c35-a25047433bb7");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Gnomish"
            };
        }
    }
}
