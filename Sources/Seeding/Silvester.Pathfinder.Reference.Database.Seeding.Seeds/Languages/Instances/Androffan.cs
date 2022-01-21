using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Androffan : Template
    {
        public static readonly Guid ID = Guid.Parse("0b6e4729-7eec-4360-a278-b8152f81dc53");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Androffan"
            };
        }
    }
}
