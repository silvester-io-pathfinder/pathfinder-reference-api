using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Blister : Template
    {
        public static readonly Guid ID = Guid.Parse("94850785-73d1-4280-a54b-a9db22a2f46b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blister",
                Level = 5,
                Range = "60 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab8c55b6-3253-4e40-90a6-f313b4db8766"), Type = TextBlockType.Text, Text = "You point at a target in range, and its skin grows searing blisters filled with caustic fluid. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f220334f-0ee7-4194-8925-eca56bbaad73"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b35a9e13-c6ce-4f6f-ab2b-c9ee86f602bf"), Type = TextBlockType.Text, Text = "The damage of a popped blister increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("54cb3487-b80d-41af-b5e0-12d932bd7f54"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target grows one blister. You can spend a single action, which has the concentrate trait, to pop a blister. The target and each creature in a 15-foot cone originating from the target takes 7d6 acid damage (basic Fortitude save). You choose the direction of the cone, which can't include the target. When no blisters are left, the spell ends.",
                Failure = "As success, but the target grows two blisters.",
                CriticalFailure = "As success, but the target grows four blisters."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d6c6e26e-d9d6-4620-8c71-6bf3208650ad"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9d7e182-28cb-41cf-834d-733ebb396daf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 216
            };
        }
    }
}
