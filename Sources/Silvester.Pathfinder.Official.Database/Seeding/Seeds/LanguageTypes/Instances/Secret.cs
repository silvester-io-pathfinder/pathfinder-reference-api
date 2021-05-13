using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.LanguageTypes.Instances
{
    public class Secret : Template
    {
        public static readonly Guid ID = Guid.Parse("9e4b5cea-7c60-4396-aa80-307379d155ab");

        protected override LanguageType GetLanguageType()
        {
            return new LanguageType 
            {
                Id = ID, 
                Name = "Secret" 
            };
        }
    }
}
