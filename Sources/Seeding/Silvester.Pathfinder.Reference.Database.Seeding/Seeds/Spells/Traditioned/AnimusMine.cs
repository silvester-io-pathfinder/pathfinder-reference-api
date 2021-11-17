using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimusMine : Template
    {
        public static readonly Guid ID = Guid.Parse("ee123274-5b43-4578-ab6e-3c60f2addbc5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Animus Mine",
                Level = 2,
                IsDismissable = true,
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0991af7a-0070-403a-b805-0888a88c718c"), Type = TextBlockType.Text, Text = "You implant a mental mine within your psyche that detonates against anyone attempting to manipulate your thoughts. You can use a single action, which has the concentrate trait, to suppress the effects of the mine for 1 round to allow someone to safely use a mental effect on you. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("4323860d-c2e7-4c52-bcde-cc0d48866169"), Type = TextBlockType.Text, Text = "The first creature that uses a magical mental effect against you triggers the animus mine, causing the spell to end. The animus mine deals 4d8 mental damage to the triggering creature, which must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("22ed6429-5a7b-495b-a632-f00ffbdf9d88"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("15debff7-a586-44e0-9c9c-cde90fe33f56"), Type = TextBlockType.Text, Text = "The damage increases by 2d8." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("085dcda1-dd88-4583-a754-466b4f4e1c1a"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is stunned 1.",
                CriticalFailure = "The creature takes double damage and is stunned 1. You are unaffected by the triggering mental effect."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19a53286-2fe0-49db-98a2-1c85d68276b0"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 106
            };
        }
    }
}
