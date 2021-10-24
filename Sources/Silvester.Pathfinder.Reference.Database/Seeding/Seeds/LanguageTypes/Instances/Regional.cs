using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.LanguageTypes.Instances
{
    public class Regional : Template
    {
        public static readonly Guid ID = Guid.Parse("b7d499bb-e200-474a-8446-52f8c2bcd51b");

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
