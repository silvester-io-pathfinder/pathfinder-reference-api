using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChromaLeach : Template
    {
        public static readonly Guid ID = Guid.Parse("b0e36984-8d28-4b95-a9af-fd163fb1b05c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chroma Leach",
                Level = 4,
                Range = "Touch.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a20c4e5-aad6-4aa4-a3e6-fe3a716621c9"), Type = TextBlockType.Text, Text = "Your hand glows with impossible colors from beyond the stars, and your touch saps both color and vitality from the living. The target must attempt a Fortitude save; creatures with the gnome trait take a –2 circumstance penalty to this save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("1b55e18e-951e-4911-9a9e-a6c1a65f7c7d"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is enfeebled 2 for 1 round.",
                Failure = "The target is enfeebled 2 for 1 minute and drained 1. The target is also filled with listlessness and ennui. For 1 round, if the target tries to use a move action, it must succeed at a Will save against your spell DC or the action is lost; this effect has the mental and emotion traits.",
                CriticalFailure = "As failure, but the creature is permanently enfeebled 2 and drained 2 (although magic such as restoration can reduce or remove these conditions)."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("583f0093-d21e-474c-b168-409f5183c55f"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3017aaac-20ed-4672-a435-6419c44fe750"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 217
            };
        }
    }
}
