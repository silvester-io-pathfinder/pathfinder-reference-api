using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BreathOfLifeSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("27b176c3-a4ac-425b-b7f1-9e6b7c25063f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Breath of Life",
                Level = 5,
                Range = 60,
                Targets = "The triggering creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dad7233b-d058-464a-a3b2-94820cc93d6d"), Type = Utilities.Text.TextBlockType.Text, Text = "Your blessing revives a creature at the moment of its death. You prevent the target from dying and restore Hit Points to the target equal to 4d8 plus your spellcasting ability modifier. You can’t use breath of life if the triggering effect was disintegrate or a death effect." };
        }

        public override IEnumerable<SpellTrigger> GetTriggers()
        {
            yield return new SpellTrigger { Id = Guid.Parse("3992996d-8346-4d1b-9e96-13a13a9139bd"), Text = "A living creature within range would die." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }
    }
}
