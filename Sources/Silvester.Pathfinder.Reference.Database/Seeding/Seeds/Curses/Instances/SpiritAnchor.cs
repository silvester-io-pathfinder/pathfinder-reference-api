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
    public class SpiritAnchor : Template
    {
        public static readonly Guid ID = Guid.Parse("377a9414-6b18-4634-a5e2-35ac9225a2da");

		public override Models.Entities.Curse GetCurse()
        {
            return new Models.Entities.Curse
            {
                Id = ID,
                Level = 13,
                Name = "Spirit Anchor",
                DifficultyCheck = 31,
                SavingThrowStatId = Fortitude.ID,
                Effect = " If you die while affected, your spirit is anchored to the Material Plane, and you become a ghost or other incorporeal undead."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f26e7863-eee9-455c-aed8-c5dbb95e46f7"), Type = TextBlockType.Text, Text = "This curse prevents your soul from moving on after death." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2bf2941-f13f-4ef7-9157-a8dd32fbd4d0"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Necromancy.ID;
            yield return Negative.ID;
        }
    }
}
