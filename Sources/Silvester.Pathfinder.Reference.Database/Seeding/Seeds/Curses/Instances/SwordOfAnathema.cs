using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SavingThrowStats.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Curse = Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances.Curse;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Curses.Instances
{
    public class SwordOfAnathema : Template
    {
        public static readonly Guid ID = Guid.Parse("777ae2c9-85e4-444a-9bce-8ef9af37eee4");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 20,
                Name = "Sword of Anathema",
                DifficultyCheck = 40,
                SavingThrowStatId = Will.ID,
                Effect = "You are marked by the deity invoked as an enemy of the church. You gain weakness 10 to damage dealt by worshippers of that deity."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d41b7d7-e6cf-44cd-a315-9c166d15b06e"), Type = TextBlockType.Text, Text = "With divine intervention, followers of a deity can bestow this curse upon an enemy of the faith." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca84a884-d5ed-4108-975b-02b0f0dd622e"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Evocation.ID;
            yield return Divine.ID;
        }
    }
}
