using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Languages.Instances
{
    public class Grippli : Template
    {
        public static readonly Guid ID = Guid.Parse("62c7f2f7-4494-4f3a-aea1-691cfdf1efa1");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Common.ID,
                Name = "Grippli"
            };
        }
    }
}
