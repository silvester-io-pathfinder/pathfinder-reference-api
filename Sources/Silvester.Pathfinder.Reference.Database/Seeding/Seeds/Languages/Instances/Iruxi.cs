using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Iruxi : Template
    {
        public static readonly Guid ID = Guid.Parse("fe8f7dca-685b-4595-8d0c-ee72e0239d58");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Iruxi"
            };
        }
    }
}
