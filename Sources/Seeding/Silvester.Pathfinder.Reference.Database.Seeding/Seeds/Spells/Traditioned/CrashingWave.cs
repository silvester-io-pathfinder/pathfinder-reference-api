using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CrashingWave : Template
    {
        public static readonly Guid ID = Guid.Parse("7e59cb74-38b6-4a01-a669-ba04d1bcf4a7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Crashing Wave",
                Level = 3,
                Area = "30-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84747b55-88c8-4372-a278-634ba8c5b85d"), Type = TextBlockType.Text, Text = "You summon a crashing wave that sweeps away from you. You deal 6d6 bludgeoning damage to creatures in the area. The water also extinguishes non-magical fires in the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("19262338-9735-44b7-8a88-ee3f383f1e07"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9a2f10e6-5c65-44a4-8ddd-2432bf6aeabf"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63109f5c-100a-4212-ae25-cb7b08d08d58"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 217
            };
        }
    }
}
