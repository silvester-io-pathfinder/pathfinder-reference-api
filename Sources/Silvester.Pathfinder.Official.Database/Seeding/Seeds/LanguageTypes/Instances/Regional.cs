using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.LanguageTypes.Instances
{
    public class Regional : AbstractLanguageTypeTemplate
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
