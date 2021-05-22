using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Sanctuary : Template
    {
        public static readonly Guid ID = Guid.Parse("86dabd01-ccd5-45e6-adac-c7677bb0000c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sanctuary",
                Level = 1,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c756c99c-e162-459f-9f7e-e1a66f407620"), Type = TextBlockType.Text, Text = "You ward a creature with protective energy that deters enemy attacks. Creatures attempting to attack the target must attempt a Will save each time. If the target uses a hostile action, the spell ends." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c607b915-9901-4fc2-8538-786b7f1a015b"),
                CriticalSuccess = "Sanctuary ends.",
                Success = "The creature can attempt its attack and any other attacks against the target this turn.",
                Failure = "The creature can’t attack the target and wastes the action. It can’t attempt further attacks against the target this turn.",
                CriticalFailure = "The creature wastes the action and can’t attempt to attack the target for the rest of sanctuary’s duration."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9bab50c-2f68-4221-bd84-42fb0a3ad321"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 366
            };
        }
    }
}
