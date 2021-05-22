using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class NoxiousVapors : Template
    {
        public static readonly Guid ID = Guid.Parse("a97c8c23-59ca-4523-909d-15f56c873eb5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Noxious Vapors",
                Level = 1,
                Area = "10-foot emanation.",
                Duration = "1 round.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a0f38d9-4c01-438b-828b-ae0086fad7b7"), Type = TextBlockType.Text, Text = "You emit a cloud of toxic smoke that temporarily obscures you from sight. Each creature except you in the area when you Cast the Spell takes 1d6 poison damage (basic Fortitude save). A creature that critically fails the saving throw also becomes sickened 1. All creatures in the area become concealed, and all creatures outside the smoke become concealed to creatures within it. This smoke can be dispersed by a strong wind." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("686d13d8-a663-4024-a8b7-daad9ca84029"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("18b09b81-cd6d-4f1f-bf9b-e8e7677c011a"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
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
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cee56649-9375-4124-b719-efe0cb8d06af"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 222
            };
        }
    }
}
