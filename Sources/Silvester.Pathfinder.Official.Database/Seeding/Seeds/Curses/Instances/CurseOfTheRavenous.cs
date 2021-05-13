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
    public class CurseOfTheRavenous : Template
    {
        public static readonly Guid ID = Guid.Parse("8f8119cf-ecf8-412d-ad29-04df287396bc");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 5,
                Name = "Curse of the Ravenous",
                DifficultyCheck = 20,
                SavingThrowStatId = Fortitude.ID,
                Effect = "No matter how much you eat, you aren’t satiated. After 1 day, you begin starving. Each week, you receive a new saving throw against the curse."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("265d0468-003e-439f-ae86-71d69ff57357"), Type = TextBlockType.Text, Text = "This hideous curse kills through constant hunger. You become gaunt and repeatedly gnash your teeth." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ea20f35-9802-4639-931b-19a7edbb017b"),
                SourceId = GamemasteryGuide.ID,
                Page = 116
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
