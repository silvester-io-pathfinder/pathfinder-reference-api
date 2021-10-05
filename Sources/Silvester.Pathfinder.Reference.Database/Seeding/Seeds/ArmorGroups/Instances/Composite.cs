using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorGroups.Instances
{
    public class Composite : Template
    {
        public static readonly Guid ID = Guid.Parse("6417c12e-62cb-4e61-97d9-c08b8229da30");

        protected override ArmorGroup GetArmorGroup()
        {
            return new ArmorGroup
            {
                Id = ID,
                Name = "Composite",
                ArmorSpecializationEffect = "The numerous overlapping pieces of this armor protect you from piercing attacks. You gain resistance to piercing damage equal to 1 + the value of the armor’s potency rune for medium armor, or 2 + the value of the armor’s potency rune for heavy armor."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0bf2f951-74c8-4f9f-90fb-068ab619242d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
