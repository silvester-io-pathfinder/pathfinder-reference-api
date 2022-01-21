using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FlameWisp : Template
    {
        public static readonly Guid ID = Guid.Parse("b4e0e2f6-17ea-4259-b164-ca9fbb9126b5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flame Wisp",
                Level = 2,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cbad36a2-ec33-4f3a-a6e3-ec121354719b"), Type = TextBlockType.Text, Text = "Three faintly glowing wisps of fire float around your head. Each time you hit a creature with a Strike, one of the wisps goes hurtling towards that creature, dealing 1d4 fire damage. If you Cast a Spell with the fire trait while you have fewer than three wisps, a new wisp appears." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2e2c4472-1e33-46a0-a256-784c2d8be53b"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("79ab2e1b-c90b-4090-b59a-7090399eac73"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("75461d43-9dc3-430d-bdcb-ec2ae8890c2d"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("8517f106-d1f9-4949-82e7-5f1ce692398d"), Traits.Instances.Fire.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71e52f6c-f4e7-4503-8a2b-7c8490900897"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 106
            };
        }
    }
}
