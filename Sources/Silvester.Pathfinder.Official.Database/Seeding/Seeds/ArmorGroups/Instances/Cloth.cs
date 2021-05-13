using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class Cloth : Template
    {
        public static readonly Guid ID = Guid.Parse("80a75f79-058a-4d69-a75a-1591d7e53a2e");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup
            {
                Id = ID,
                Name = "Cloth",
                ArmorSpecializationEffect = "There is no medium or heavy cloth armor, so there is no armor specialization effect for the cloth armor group."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("3df55bb0-de89-4344-8b24-c33bea54416d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
