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
    public class OathOfTheFlesh : Template
    {
        public static readonly Guid ID = Guid.Parse("2638d791-3e60-457d-8450-bf0a09099568");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 7,
                Name = "Oath of the Fresh",
                DifficultyCheck = 23,
                SavingThrowStatId = Fortitude.ID,
                Effect = "Each time you make a promise to someone, an ornate symbol representing that promise is magically carved into your flesh. Breaking any of these promises causes the symbol tattoo to grow into a gaping wound, dealing 3d6 slashing damage to you; damage from the curse can’t be healed as long as the curse is still in effect."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("121b00ad-33e7-443c-94eb-ed4c3a3d6032"), Type = TextBlockType.Text, Text = "When you swear an oath, you must obey that oath or suffer terrible consequences." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f6d7f3e-25ac-4ace-9991-eb5e5faad0ba"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
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
