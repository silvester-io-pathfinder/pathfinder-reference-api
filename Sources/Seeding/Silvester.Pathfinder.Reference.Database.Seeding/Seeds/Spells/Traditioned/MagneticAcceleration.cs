using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagneticAcceleration : Template
    {
        public static readonly Guid ID = Guid.Parse("ba0459fc-1d43-4921-adf3-6e085be834b5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magnetic Acceleration",
                Level = 3,
                Range = "120 geet.",
                Targets = "1 creature or object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23bff787-2f0f-474c-b33b-339c02672a74"), Type = TextBlockType.Text, Text = "You magnetize a small metal object, such as a nail or coin, and launch it away from you at massive speed. Make a ranged spell attack roll; if the target is wearing metal armor or is made of metal, you gain a +1 circumstance bonus to your attack roll with magnetic acceleration. On a hit, the target takes 3d6 bludgeoning damage and 3d6 piercing damage, or double damage on a critical hit." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("51f48a2f-0931-40bd-bd42-b8e4ecf4a78b"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("f267da4d-14c4-4b06-867b-f4c4e854a361"), Type = TextBlockType.Text, Text = "The bludgeoning and piercing damage each increase by 1d6." }
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
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d75d3194-9507-4b24-8391-e522a97ece46"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 114
            };
        }
    }
}
