using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class Leather : Template
    {
        public static readonly Guid ID = Guid.Parse("a26e650d-f853-4bc6-829d-b65fae361b40");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup
            {
                Id = ID,
                Name = "Leather",
                ArmorSpecializationEffect = "The thick second skin of the armor disperses blunt force to reduce bludgeoning damage. You gain resistance to bludgeoning damage equal to 1 + the value of the armor’s potency rune for medium armor, or 2 + the value of the armor’s potency rune for heavy armor."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22a8f7c5-d630-4e21-8065-e7688bec76aa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
