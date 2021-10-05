using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LanguageTypes.Instances
{
    public class Uncommon : Template
    {
        public static readonly Guid ID = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0");

        protected override LanguageType GetLanguageType()
        {
            return new LanguageType 
            {
                Id = ID, 
                Name = "Uncommon" 
            };
        }
    }
}
