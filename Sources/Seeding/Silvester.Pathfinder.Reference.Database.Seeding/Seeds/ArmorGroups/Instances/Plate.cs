using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class Plate : Template
    {
        public static readonly Guid ID = Guid.Parse("e0daa940-678f-4ce5-8ee0-19bc7859799b");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup
            {
                Id = ID,
                Name = "Plate",
                ArmorSpecializationEffect = "The sturdy plate provides no purchase for a cutting edge. You gain resistance to slashing damage equal to 1 + the value of the armor's potency rune for medium armor, or 2 + the value of the armor's potency rune for heavy armor."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49778592-4637-4573-ae09-f433586c87d3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
