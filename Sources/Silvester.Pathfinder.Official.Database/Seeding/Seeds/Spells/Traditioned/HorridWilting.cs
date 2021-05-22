using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class HorridWilting : Template
    {
        public static readonly Guid ID = Guid.Parse("969b3331-855c-4d0e-94dc-ed9f9bc9219c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Horrid Wilting",
                Level = 8,
                Range = "500 feet.",
                IsDismissable = true,
                Targets = "Any number of living creatures.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("28c84572-505d-475d-9a38-4c74c8fe0ebd"), Type = TextBlockType.Text, Text = "You pull the moisture from the targets’ bodies, dealing 10d10 negative damage. Creatures made of water (such as water elementals) and plant creatures use the outcome for one degree of success worse than the result of their saving throw. Creatures whose bodies contain no significant moisture (such as earth elementals) are immune to horrid wilting." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3bf91ab1-bd8b-4637-95be-6acf226a0e9f"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("abc7d61f-203a-4ccb-8869-48f0472ffb5b"), Type = TextBlockType.Text, Text = "The damage increases by 1d10." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9f6fd9a-51f7-4df9-b2b0-03b948c7fdea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 344
            };
        }
    }
}
