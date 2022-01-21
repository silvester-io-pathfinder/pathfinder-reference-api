using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FlameVortex : Template
    {
        public static readonly Guid ID = Guid.Parse("ddc4b642-8a04-45df-9436-5385d22713f8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flame Vortex",
                Level = 6,
                Range = "120 feet.",
                Duration = "Sustained up to 1 minute.",
                Area = "5-foot radius, 40-foot tall cylinder.",
                CastTime = "",
                IsDismissable = true,
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58a3abe2-d00d-49c6-a71a-3c5cd55810c4"), Type = TextBlockType.Text, Text = "You combine a blazing inferno and air currents into a fiery vortex. You can Cast this Spell only if you are outside or the ceiling is 40 feet or higher. All squares in the vortex are difficult terrain for flying creatures." };
            yield return new TextBlock { Id = Guid.Parse("a213f5e2-8d59-4b1e-a123-8b772bf37660"), Type = TextBlockType.Text, Text = "All creatures in the area take 3d4 bludgeoning damage and 3d6 fire damage as gusts of fiery wind buffet them, with a basic Reflex save. Each time you Sustain the Spell, you can move the whirlwind up to 20 feet in a straight line. Each creature the whirlwind moves through takes the damage with a basic Reflex save. A creature can take damage from a flame vortex only once per round." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("690277bb-4955-4a33-821d-eba3b12f8c17"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5227c037-0331-4b4b-a385-e3d173e5b663"), Type = TextBlockType.Text, Text = "The vortex deals an additional 1d4 bludgeoning damage and 1d6 fire damage." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            builder.Add(Guid.Parse("93b1a29d-50a9-41ce-9ec3-59446f9e12a2"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("1847c101-94ea-4b75-a800-4ec65ca1b621"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("ed15badb-d3c2-4ab8-8e9e-fd188f9edbc6"), Traits.Instances.Fire.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0f987b6-8bd5-475e-ae66-679dd7415e90"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 106
            };
        }
    }
}
