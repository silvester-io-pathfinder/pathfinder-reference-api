using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CorrosiveBody : Template
    {
        public static readonly Guid ID = Guid.Parse("a12361ed-d181-434c-8b57-0c14e1b08256");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Corrosive Body",
                Level = 7,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ccb3c543-cec4-43cd-be76-89b7d3267f28"), Type = TextBlockType.Text, Text = "You exhale corrosive gas, and acidic secretions coat your skin as you transform into a being of living acid. You gain acid immunity. Any creature that touches you or damages you with an unarmed melee attack or non-reach melee weapon takes 3d6 acid damage, and your unarmed attacks deal 1d4 additional acid damage. The first time each round that you deal acid damage to a creature in this way, you gain 3d6 temporary HP as your body digests the eroded material and transforms it into a protective acid. When the spell ends, any remaining temporary HP expires as well. Your acid spells deal one additional die of acid damage (of the same damage die the spell uses). You can cast acid splash as an innate spell; the splash damage affects all creatures within 15 feet instead of the normal 5 feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("efbbed95-ef73-4834-8f5c-9ceb594239bf"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("d052c6c2-b4c9-4bec-a0c3-91026945dc78"), Type = TextBlockType.Text, Text = "Creatures touching you take 4d6 acid damage instead of 3d6, your unarmed attacks deal 2d4 additional acid damage, and you gain 5d6 temporary HP." }
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
            builder.Add(Guid.Parse("7536cf4f-4892-4fbb-8568-af579c9af44a"), Traits.Instances.Acid.ID);
            builder.Add(Guid.Parse("687a4a24-ecf6-437a-8886-c7f219037c69"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("4bf866d5-0a48-4683-ac50-401cd3ebeb54"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4fa8912-1170-4857-b7f7-d1a4546ffe09"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 96
            };
        }
    }
}
