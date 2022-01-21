using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChillingSpray : Template
    {
        public static readonly Guid ID = Guid.Parse("99025d40-d031-4e17-8f6e-4c1f95732557");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chilling Spray",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59825ba9-8c1e-4a46-ab99-8f8eddb25c75"), Type = TextBlockType.Text, Text = "A cone of icy shards bursts from your spread hands and coats the targets in a layer of frost. You deal 2d4 cold damage to creatures in the area; they must each attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f707eb02-267f-4b61-9e65-81d4ff250bed"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c5a2e54b-47a6-4204-9c54-19c0155cb8bb"), Type = TextBlockType.Text, Text = "The damage increases by 2d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d2565fe3-8343-45fe-bd54-acdd4449f4ad"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and takes a –5-foot status penalty to its Speeds for 2 rounds.",
                CriticalFailure = "The creature takes double damage and takes a –10-foot status penalty to its Speeds for 2 rounds."
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
            builder.Add(Guid.Parse("6888ce1c-0250-4f09-af10-9f794b0784d1"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("bfe615ac-2a4c-4176-83b7-8964cb5cc383"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec753b6b-49ce-414c-bf0c-a8bc767a7225"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 217
            };
        }
    }
}
