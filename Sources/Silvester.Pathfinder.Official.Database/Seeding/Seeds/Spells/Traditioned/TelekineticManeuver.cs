using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class TelekineticManeuver : Template
    {
        public static readonly Guid ID = Guid.Parse("e469dd5e-ca1a-4149-8c10-5fe8ea042da6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Telekinetic Maneuver",
                Level = 2,
                Range = "60 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5870d50-d831-4937-921e-8c299d84f5e8"), Type = TextBlockType.Text, Text = "With a rush of telekinetic power, you move a foe or something they carry. You can attempt to Disarm, Shove, or Trip the target using a spell attack roll instead of an Athletics check." };
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
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Force.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74750ad3-a4f0-4699-8847-d254655945dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
