using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SavingThrowStats.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Curse = Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances.Curse;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Curses.Instances
{
    public class ThiefsRetribution : Template
    {
        public static readonly Guid ID = Guid.Parse("9a5c5a35-e734-4557-ba0c-0b1d8cbea242");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 19,
                Name = "Thief's Retribution",
                DifficultyCheck = 39,
                SavingThrowStatId = Fortitude.ID,
                Effect = "Each time you steal something, you lose something more valuable—this item is whisked away and can’t be found again. Typically this item is one of greater monetary value, but it might be one of greater value in another sense, such as one of greater emotional value, or something you need to complete a task. If you aren’t carrying anything of greater value at the time of the theft, you lose one of your limbs instead, taking 10d6 slashing damage and losing use of that limb. The damage can’t be healed, nor the limb restored, until the stolen item is returned, even through use of spells like regenerate."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60ad7f53-018d-4c7d-bc83-a74d72cb9608"), Type = TextBlockType.Text, Text = "This punishment causes you to lose something dear to you whenever you rob or steal. If you have nothing to lose, the curse exacts its punishment upon your body instead." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f51503d3-4df0-440d-958d-9a5eb36f4a9a"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Conjuration.ID;
        }
    }
}
