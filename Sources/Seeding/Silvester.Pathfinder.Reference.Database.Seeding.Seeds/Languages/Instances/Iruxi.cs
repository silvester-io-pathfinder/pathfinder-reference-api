using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Iruxi : Template
    {
        public static readonly Guid ID = Guid.Parse("adfd101d-4944-4cbd-bd66-40e4d9af7d28");

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
