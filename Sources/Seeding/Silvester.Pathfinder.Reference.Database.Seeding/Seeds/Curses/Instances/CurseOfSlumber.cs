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
    public class CurseOfSlumber : Template
    {
        public static readonly Guid ID = Guid.Parse("aac52ac8-ae3d-4386-a81d-05f38ae1372f");

		public override Models.Entities.Curse GetCurse()
        {
            return new Models.Entities.Curse
            {
                Id = ID,
                Level = 11,
                Name = "Curse of Slumber",
                DifficultyCheck = 28,
                SavingThrowStatId = Fortitude.ID,
                Effect = "You fall asleep for 1 round (or permanently on a critical failure) and seem to be dead; a creature must succeed at a DC 30 Medicine check to realize you are alive. Noise doesn’t awaken you, but taking damage gives you a new saving throw against the curse."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2bc8486-9d73-401e-8048-60736949186d"), Type = TextBlockType.Text, Text = "This legendary curse sends you into a sleep indistinguishable from death." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9dc8a3e-c79b-4267-9703-14a7d7dd877b"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Incapacitation.ID;
            yield return Necromancy.ID;
            yield return Sleep.ID;
        }
    }
}
