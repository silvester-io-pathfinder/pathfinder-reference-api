using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class GaseousForm : Template
    {
        public static readonly Guid ID = Guid.Parse("ec8d1e61-aa9d-4cdb-9e12-4c3cc8fa29c0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gaseous Form",
                Level = 4,
                Range = "Touch.",
                IsDismissable = true,
                Duration = "5 minutes.",
                Targets = "1 willing creautre.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39e7fe07-6959-418e-9847-46ec55c3a3ba"), Type = TextBlockType.Text, Text = "The target transforms into a vaporous state. In this state, the target is amorphous. It loses any item bonus to AC and all other effects and bonuses from armor, and it uses its proficiency modifier for unarmored defense. It gains resistance 8 to physical damage and is immune to precision damage. It can’t cast spells, activate items, or use actions that have the attack or manipulate trait. It gains a fly Speed of 10 feet and can slip through tiny cracks. The target can Dismiss the spell." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c21926a-9783-4883-bd96-bf062eb52ef3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 340
            };
        }
    }
}
