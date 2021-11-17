using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AcidStorm : Template
    {
        public static readonly Guid ID = Guid.Parse("54b132b2-7d89-4419-b3f1-53fce8fdc5b5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Acid Storm",
                Level = 5,
                Range = "120 feet.",
                Area = "20-foot-radius burst.",
                Duration = "1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6de419b9-f378-45e2-b574-d81d01fd4258"), Type = TextBlockType.Text, Text = "You evoke a storm of acid rain that pelts the area for the spell�s duration. A creature that begins its turn in the area takes 3d8 acid damage (basic Reflex save)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f8b25f8c-14dd-4165-ad68-d5513599ca22"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("6a3eea81-e459-4391-ad1d-6d1b706f54ad"), Type = TextBlockType.Text, Text = "The damage increases by 1d8." }
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
            yield return Traits.Instances.Acid.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("045ac91b-dbca-4f4d-a24d-510ad2bb0b28"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 106
            };
        }
    }
}
