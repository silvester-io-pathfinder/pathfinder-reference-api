using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RopeTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("5be41a41-9a8b-42af-b0f9-3a50b33e6e79");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rope Trick",
                Level = 4,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Duration = "8 hours.",
                Targets = "1 touched piece of rope from 5 to 30 feet long.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a98cd4b-d44c-4601-bd0a-f37b9e163105"), Type = TextBlockType.Text, Text = "You cause the target rope to rise vertically into the air. Where it ends, an extradimensional space opens, connected to the top of the rope. This space can be reached only by climbing the rope." };
            yield return new TextBlock { Id = Guid.Parse("c05ba948-60e5-4d63-a58c-a2f8a4c5d396"), Type = TextBlockType.Text, Text = "The entrance to the space can’t be seen, and it can be pinpointed only by the presence of the rope. The rope can’t be removed or hidden, though it can be detached from the extradimensional space by pulling it with 16,000 pounds of weight, critically succeeding at an Athletics check against the spell’s DC, or destroying the rope. The space holds up to eight Medium creatures and their gear. A Large creature counts as two Medium creatures, a Huge creature counts as four Medium creatures, and a Gargantuan creature fills the space on its own." };
            yield return new TextBlock { Id = Guid.Parse("57903f39-d69b-4e84-a08b-f884b3c3bf2b"), Type = TextBlockType.Text, Text = "If the rope is detached or destroyed, or if a creature attempts to enter the space that would put it over its capacity, the space begins to unravel. It disappears in 1d4 rounds, depositing the creatures within safely on the ground below." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Extradimensional.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbbc12c3-6f0a-4954-a617-87030247c7ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 366
            };
        }
    }
}
