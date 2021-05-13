using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Languages.Instances
{
    public class Sign : Template
    {
        public static readonly Guid ID = Guid.Parse("2b9c61de-3dbc-47dd-9571-65b66591d5f7");

        protected override Language GetLanguage()
        {
            return new Language
            {
                Id = ID,
                TypeId = LanguageTypes.Instances.Sign.ID,
                Name = "Sign Language"
            };
        }
    }
}
