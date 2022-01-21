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
    public class EmptyDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("30627014-f702-4684-8300-620e2adcc36d");

		public override Models.Entities.Curse GetCurse()
        {
            return new Models.Entities.Curse
            {
                Id = ID,
                Level = 10,
                Name = "Empty Death",
                DifficultyCheck = 27,
                SavingThrowStatId = Will.ID,
                Effect = "If you activate The Whispering Reeds and are not a worshipper of Nhimbaloth, you become stupefied 2 for 24 hours as your thoughts fill with paranoia that something is watching you from the other side of death. If you die while affected by the Empty Death, you immediately become a chaotic evil ghost. Every 7 days that pass after you become a ghost, you must succeed at a DC 2 flat check� failure indicates that you are consumed by Nhimbaloth. A creature whose ghost is consumed in this way does not travel to the River of Souls and is utterly annihilated; this creature can only be restored to life via a 10th-level spell effect or ritual like wish."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield break;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Necromancy.ID;
            yield return Occult.ID;
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("982366c1-3f26-41d6-adb8-56848b8af813"),
                SourceId = Pathfinder163.ID,
                Page = 78
            };
        }
    }
}
