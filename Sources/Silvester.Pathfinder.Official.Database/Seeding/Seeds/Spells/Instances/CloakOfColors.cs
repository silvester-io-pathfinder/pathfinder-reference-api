using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CloakOfColors : Template
    {
        public static readonly Guid ID = Guid.Parse("2c2d2218-3a46-4075-899c-c4e9353aaec3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cloak of Colors",
                Level = 5,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9a5617f3-f18c-407c-98f5-f0092737c1cf"), Type = Utilities.Text.TextBlockType.Text, Text = "A cloak of swirling colors shrouds the target. Creatures are dazzled while adjacent to it, and attacking the target causes a brilliant flash of light. A creature that hits the target with a melee attack must attempt a Will save." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect 
            {
                Id = Guid.Parse("1396db52-7879-4bee-afcb-71cc424a3726"),
                Success = "The attacker is unaffected.",
                Failure = "The attacker is blinded for 1 round.",
                CriticalFailure = "The attacker is stunned for 1 round. The creature is temporarily immune until the end of its turn; this effect has the incapacitation trait."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 324
            };
        }
    }
}
