using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class Pantheons : AbstractDeityCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("95ffee72-4042-47a8-8e82-3ff82c51d55c");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            {
                Id = ID, 
                Name = "Pantheons", 
                Description = "A pantheon is a group of related gods worshipped either individually or together. Most pantheons are associated with a specific ancestry or geopolitical region, but rarely, a pantheon consists of deities with overlapping areas of concern. Followers work to advance the shared interests of their pantheon, directing prayers to whichever god presides over their current activity or circumstance. At the GM's discretion, champions and clerics can dedicate themselves to a pantheon. In such cases, the characters still worship a specific patron deity among those in the pantheon, but also follow the edicts and anathema of the pantheon as a whole. A character who worships a pantheon this way can gain the domains, alternate domains, and spells from the pantheon instead of those from their patron deity. They must uphold the ideals of both their patron deity and the pantheon, though the patron deity's edicts and anathema take precedence. For example, a worshipper of Iomedae could worship the Godclaw, but they wouldn't take the tyranny domain, as it would be in conflict with Iomedae's edicts. In rare cases, a character can worship a pantheon without following a patron deity. Such cases are unique and subject to GM approval." 
            };
        }
    }
}
