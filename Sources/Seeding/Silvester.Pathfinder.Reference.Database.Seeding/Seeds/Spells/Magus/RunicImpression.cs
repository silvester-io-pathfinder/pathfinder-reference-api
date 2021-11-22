using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RunicImpression : Template
    {
        public static readonly Guid ID = Guid.Parse("949d051c-c882-4b6b-8e6c-d2e70e6082e4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Runic Impression",
                Level = 4,
                Range = "Touch.",
                Targets = "You or one weapon you're wielding.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
                ClassId = Classes.Instances.Magus.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4935848-9496-4f45-b52a-f96caa15da39"), Type = TextBlockType.Text, Text = "Your unarmed attacks or weapon gain the benefits of a weapon rune you choose when you cast this spell: corrosive, flaming, frost, ghost touch, returning, shock, or thundering. If you cast runic impression on a weapon, this spell ends if you cease holding the weapon." };
            yield return new TextBlock { Id = Guid.Parse("ed1d5fd6-6f77-49b3-9766-5f21195efe8b"), Type = TextBlockType.Text, Text = "If this spell would give a weapon more property runes than its normal maximum, one of the existing property runes (you choose) is suppressed until the spell ends. For unarmed attacks, if this spell would give you more property runes than you could have from handwraps of mighty blows, one of the existing property runes is similarly suppressed" };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7ebf64f8-41ea-46c3-a46b-53c559323bc0"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("04950a96-2cb7-49f6-8b12-b85f02933077"), Type = TextBlockType.Text, Text = "Add keen to the list of runes you can choose as well as the greater types of corrosive, flaming, frost, shock, and thundering." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magus.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e3149ac-58e9-480b-83a2-e76cb7f9d279"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 143
            };
        }
    }
}
