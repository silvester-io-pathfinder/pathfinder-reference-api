using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ConsumingDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("7012c0eb-05c1-453e-8b87-411bcde2ec1a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Consuming Darkness",
                Level = 5,
                Area = "10-foot emanation.",
                Targets = "Enemies in the area.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f16f25e0-bf73-4cab-b018-7af2daba561c"), Type = TextBlockType.Text, Text = "Your shadow wriggles before spreading out from you, forming a gateway of clinging, consuming shadow through which the horrors of another plane can barely be seen. The first time each turn you Sustain the Spell, the radius increases by 5 feet. Each enemy that enters the area or begins its turn in the area takes 2d6 negative damage and must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("eca2494c-cf01-472a-b520-a1470b81d379"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f7f0d439-c692-4eb7-b7b7-14937c0c44c2"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d8588315-b375-4717-b515-40bbf1ef0132"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature sinks partially into the shadow, taking half damage and a –5-foot circumstance penalty to its Speeds for as long it remains in the area.",
                Failure = "As success, but the creature takes full damage and a –10-foot circumstance penalty.",
                CriticalFailure = "The creature is absorbed into the shadows, where it can be seen below the surface; it takes double damage and is immobilized for 1 round or until it Escapes."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7f44faaa-b2b4-4540-a8fe-c6554de409c5"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9210c94c-eb96-4c67-a22c-cebb23bca44c"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("1f01a9ff-7370-412a-9ca7-e2064075807f"), Traits.Instances.Shadow.ID);
            builder.Add(Guid.Parse("79aab5ac-5f36-4a5b-b2da-2d86e6210d3b"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40444660-a940-47c2-90b9-b49f640e3146"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}
