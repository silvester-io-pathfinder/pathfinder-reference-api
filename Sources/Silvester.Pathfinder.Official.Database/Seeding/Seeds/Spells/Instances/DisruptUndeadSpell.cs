using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DisruptUndeadSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("db143e7b-8212-4350-a09f-09205811470e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Disrupt Undead",
                Level = 1,
                Range = 30,
                Targets = "1 undead creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac325502-59d1-4250-91b4-917dab957ede"), Type = Utilities.Text.TextBlockType.Text, Text = "You lance the target with energy. You deal 1d6 positive damage plus your spellcasting ability modifier. The target must attempt a basic Fortitude save." };
        }


        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("7c7d9f59-2899-4af7-9596-cf6a7711da5a"),
                CriticalFailure = "The creature is also enfeebled 1 for 1 round."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("637c1c9a-e2f9-497d-85fc-9ca72fbba552"), 
                Level = 1, 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b80d3ed5-a258-46bf-aba7-9f4623cac77a"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }
    }
}
