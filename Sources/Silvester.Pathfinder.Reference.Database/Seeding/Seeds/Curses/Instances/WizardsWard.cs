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
    public class WizardsWard : Template
    {
        public static readonly Guid ID = Guid.Parse("cc8c8901-28c6-49d0-b157-5e360182bd46");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 6,
                Name = "Wizard's Ward",
                DifficultyCheck = 22,
                SavingThrowStatId = Will.ID,
                Effect = "You take 5d6 damage of the same damage type as the damage you dealt to the book, and the damage can’t be healed as long as the curse lasts. Repairing the book, including replacing any missing text, ends this curse."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f951938-a7f4-4070-bd17-24a449a8675a"), Type = TextBlockType.Text, Text = "A wizard’s ward is placed upon a single book, usually a spellbook. If you damage the book, you must attempt a save against the curse’s effect." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5be86e35-cc73-4079-b175-3dac119cca33"),
                SourceId = GamemasteryGuide.ID,
                Page = 116
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Abjuration.ID;
        }
    }
}
