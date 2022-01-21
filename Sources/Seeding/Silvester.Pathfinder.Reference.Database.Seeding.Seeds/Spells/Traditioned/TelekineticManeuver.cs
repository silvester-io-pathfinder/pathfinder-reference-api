using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ccadd10c-ec4e-4a3a-aab1-ade92df376bc"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("96431375-8dcd-4b33-b501-208797f2ff7a"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("6e1f35e9-c065-47d4-a621-f3b8f3535ca3"), Traits.Instances.Force.ID);
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
