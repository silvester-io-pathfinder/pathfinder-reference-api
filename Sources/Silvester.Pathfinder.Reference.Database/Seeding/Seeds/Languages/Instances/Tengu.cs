using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Tengu : Template
    {
        public static readonly Guid ID = Guid.Parse("7c3e1ffc-a478-4009-986c-bf45770f5f10");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Uncommon.ID,
                Name = "Tengu"
            };
        }
    }
}
