using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.SavingThrowStats.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Curse = Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances.Curse;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Curses.Instances
{
    public class UnendingThirst : Template
    {
        public static readonly Guid ID = Guid.Parse("65c44561-e8b0-4f7a-b65c-3a42d458721e");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 15,
                Name = "Unending Thirst",
                DifficultyCheck = 32,
                SavingThrowStatId = Fortitude.ID,
                Effect = "You gain no benefit from drinking water or other liquids and begin suffering from thirst. Each day, you receive a new saving throw against the curse."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d002e496-9977-4e9d-9570-e213a6f0db43"), Type = TextBlockType.Text, Text = "This curse kills through dehydration in the same vein as the curse of the ravenous, but with deadly speed." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd7e14bd-0ace-4258-9507-88513902c057"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Transmutation.ID;
        }
    }
}
