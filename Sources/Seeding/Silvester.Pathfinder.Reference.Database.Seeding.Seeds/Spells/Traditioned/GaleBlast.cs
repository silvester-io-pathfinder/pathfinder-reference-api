using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GaleBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("62290226-5aad-42c8-8adc-73f7830cf376");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gale Blast",
                Level = 108,
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("91301678-1de4-4875-9acf-4bcdcf5695b8"), Type = TextBlockType.Text, Text = "Wind flows from your outstretched hands and whirls around you in a 5-foot emanation. Each creature in the area takes bludgeoning damage equal to your spellcasting ability modifier, with a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("161a7bef-92fb-45b4-8b92-e0962526d894"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("626e5733-683b-4164-80fe-099a263c6908"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("17171cb8-f1ec-4c14-85d8-5cf8f0dc1440"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is pushed 5 feet away from you.",
                CriticalFailure = "The creature takes double damage and is pushed 10 feet away from you."
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
            builder.Add(Guid.Parse("c6248096-4cd6-43c5-bef4-7a8e1332954e"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("c06c6b49-9cb9-439b-a723-dcaf4c80add7"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("afb5832d-d1f4-43f3-9570-cc4fdf7ff3f1"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c0ead66-7843-4638-9ffa-8766268cda3e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 108
            };
        }
    }
}
