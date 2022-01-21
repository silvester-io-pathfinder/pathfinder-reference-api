using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PrismaticArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("b2244311-fe38-4323-9738-7add410559a5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Prismatic Armor",
                Level = 7,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5525197c-8da9-49d4-865d-1fb204042eab"), Type = TextBlockType.Text, Text = "You wrap the target in armor made of multicolored light. It functions as chromatic armor (page 95) that is all colors (granting resistance 5 to acid, electricity, fire, force, mental, poison, and sonic). An attacker that critically fails on its saving throw against the spell is blinded rather than dazzled." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2a31161e-4f3c-4fd6-978c-73ea66451e92"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("7ade1e77-115d-4fad-922d-f4fce924967a"), Type = TextBlockType.Text, Text = "The resistances increase to 10 each." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1333990e-59c5-49d0-a1bc-7fc91094f31b"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3234a893-f00a-4dee-85d9-d498a3075583"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 122
            };
        }
    }
}
