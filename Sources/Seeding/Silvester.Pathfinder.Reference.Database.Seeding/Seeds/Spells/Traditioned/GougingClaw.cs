using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GougingClaw : Template
    {
        public static readonly Guid ID = Guid.Parse("f8959d79-0d54-456d-800d-f5cfb3fd00d0");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gouging Claw",
                Level = 1,
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a2ab8b8-743a-4abc-aa19-5588a12144c2"), Type = TextBlockType.Text, Text = "You temporarily morph your limb into a clawed appendage. Make a melee spell attack roll against your target�s AC. If you hit, you deal your choice of slashing or piercing damage equal to 1d6 plus your spellcasting ability modifier. On a critical success, you deal double damage plus 1d4 persistent bleed damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1f85932c-0fe1-4374-bc91-cabbba469ae5"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("4f692732-1de4-4660-923e-d293949b8e56"), Type = TextBlockType.Text, Text = "The damage increases by 1d6 and the persistent bleed damage on a critical increases by 1d4." }
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
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64ada45c-2c2d-4a6e-8fe6-b26ecc5cc037"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 109
            };
        }
    }
}
