using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagneticRepulsion : Template
    {
        public static readonly Guid ID = Guid.Parse("c9e5c57f-552c-4d2f-bab8-e49f68ae5171");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magnetic Repulsion",
                Level = 2,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c1319bf-022a-454d-856e-6660cee5a906"), Type = TextBlockType.Text, Text = "You adjust your magnetic polarity, causing metal objects to jump and shudder away from you. Attacks made with metal objects against you take a -1 status penalty, and the squares adjacent to you are difficult terrain for creatures wearing metal armor. For creatures made entirely of metal, the penalty to their attack rolls is -2 and the squares adjacent to you are greater difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("5c42d3ee-9e22-4025-ab26-b42b4acfc67b"), Type = TextBlockType.Text, Text = "While this spell is active, you require an additional Interact action before using a metal object (including to Strike with a metal weapon), and if you're wearing metal armor, you're slowed 1." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e6574361-1327-4586-bf7d-a16029274d3f"),
                Level = "+3",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("4e41fca2-f602-4842-af61-4299a0ccda6c"), Type = TextBlockType.Text, Text = "The status penalty to attack rolls increases by 1." }
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
            builder.Add(Guid.Parse("b1aadfd7-3bbe-47fb-befd-13d1e7308630"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d8324ce-214e-4b48-9f59-2ef80385fb62"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 115
            };
        }
    }
}
