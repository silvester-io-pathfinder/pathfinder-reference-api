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
    public class CowardsRoots : Template
    {
        public static readonly Guid ID = Guid.Parse("a2866bc7-990e-4735-8090-ec6351a5cad1");

		public override Models.Curse GetCurse()
        {
            return new Models.Curse
            {
                Id = ID,
                Level = 5,
                Name = "Coward's Roots",
                DifficultyCheck = 20,
                SavingThrowStatId = Will.ID,
                Effect = "At the start of your turn, if you are frightened, you become your choice of immobilized or fleeing until the end of that turn."
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7e417fa-a6a3-40d4-93d8-f4e9b149b85c"), Type = TextBlockType.Text, Text = "You find all courage stolen from your heart. When faced with something frightening, you flee in terror or stand frozen in place." };
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbf6b3c3-7465-4ba2-8a03-5877ac90399e"),
                SourceId = GamemasteryGuide.ID,
                Page = 116
            };
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Curse.ID;
            yield return Magical.ID;
            yield return Enchantment.ID;
            yield return Mental.ID;
            yield return Fear.ID;
        }
    }
}
