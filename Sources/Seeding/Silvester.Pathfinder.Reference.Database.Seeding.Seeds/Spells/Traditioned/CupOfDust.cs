using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{

    public class CupOfDust : Template
    {
        public static readonly Guid ID = Guid.Parse("461416ab-ddfd-4756-96bc-5b8a074e6113");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cup of Dust",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 living creature.",
                Duration = "1 day.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be358343-6ef7-441d-b0dd-e1dbfd3a1543"), Type = TextBlockType.Text, Text = "You curse the target with a thirst no drink can quench. You can Dismiss the spell. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2a44a5c1-a0fd-437d-89d4-6389fb59cadf"),
                Level = "+3",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("aec8aa27-2720-4baa-abc6-0b864b3e0711"), Type = TextBlockType.Text, Text = "The thirst becomes more unbearable, increasing the damage each hour by 1d4, or by 2d4 on a critical failure." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a65ded50-1884-4a76-9e7f-5a42c12ebc63"),
                CriticalSuccess = "The creature is unaffected and is temporarily immune for 1 hour.",
                Success = "The creature is fatigued for 1 round.",
                Failure = "The creature is immediately afflicted by thirst as if it hadn�t had a drink in days. It becomes fatigued and takes 1d4 damage each hour that can�t be healed until it quenches its thirst. No amount of drinking can quench the creature�s thirst during the spell�s duration.",
                CriticalFailure = "As failure but the creature takes 2d4 damage each hour, twice as much as usual for thirst."
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
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("92fcdf31-8694-4fa4-98f4-da73a12015a7"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("1cae04ca-3192-471c-8dd5-9903316c4d64"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29bde881-fb5c-43d6-80c8-78ffbb4aeec4"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 107
            };
        }
    }
}
