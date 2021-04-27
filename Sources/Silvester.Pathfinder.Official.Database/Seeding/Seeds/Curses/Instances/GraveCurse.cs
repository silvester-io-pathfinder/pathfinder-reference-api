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
    public class GraveCurse : AbstractCurseTemplate
    {
        public static readonly Guid ID = Guid.Parse("c9d8ee02-8f76-42a8-a95a-fc0d05c073d5");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = null,
                Name = "Grave Curse",
                DifficultyCheck = null,
                SavingThrowStatId = Will.ID,
                Effect = "You are hounded by undead creatures of the same level as the curse. Every night, you must attempt a DC 15 flat check. On a failure, an incorporeal undead manifests to hassle and harry you throughout the night, retreating before it can take much damage and often preventing you from gaining a full night’s rest. Whenever you enter a graveyard or other area where bodies are buried, you must succeed at the same flat check or a body animates as a corporeal undead (typically a skeleton or zombie) to attack you. These undead are temporary and exist only to harry you; if you take control of the undead, move on, or otherwise avoid their attacks, incorporeal undead discorporate and corporeal undead collapse into ordinary corpses. The curse can be removed by returning the stolen items to their resting place."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b78f271b-262c-4e0a-9ad1-fce546c27091"), Type = TextBlockType.Text, Text = "A grave curse punishes you for stealing from a tomb or other resting place." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51a80a93-1afe-41d4-8714-2749e4ddfb96"),
                SourceId = GamemasteryGuide.ID,
                Page = 117
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Necromancy.ID;
            yield return Magical.ID;
        }
    }
}
