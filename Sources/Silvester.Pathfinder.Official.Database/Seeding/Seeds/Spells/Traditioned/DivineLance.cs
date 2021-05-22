using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DivineLance : Template
    {
        public static readonly Guid ID = Guid.Parse("eb816f67-17d1-439b-badb-2657b57f64e2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Divine Lance",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf9b3fa4-e400-4e53-8e3b-61fa8da555f4"), Type = Utilities.Text.TextBlockType.Text, Text = "You unleash a beam of divine energy. Choose an alignment your deity has (chaotic, evil, good, or lawful). You can’t cast this spell if you don’t have a deity or if your deity is true neutral. Make a ranged spell attack roll against the target’s AC. On a hit, the target takes damage of the chosen alignment type equal to 1d4 + your spellcasting ability modifier (double damage on a critical hit). The spell gains the trait of the alignment you chose." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("94452491-58bd-487f-b187-8525fe6a0160"),
                Level = "+1", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("44d1af8e-b3a2-4726-863e-8669acd62fe3"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increased by 1d4." }
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb3f6124-d489-4961-b7be-2d4208fc05dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 331
            };
        }
    }
}
