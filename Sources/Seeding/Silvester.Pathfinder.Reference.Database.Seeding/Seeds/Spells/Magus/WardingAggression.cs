using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WardingAggression : Template
    {
        public static readonly Guid ID = Guid.Parse("63d27dae-afe3-4dc0-a1c4-9af90c8e979f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Warding Aggression",
                Level = 3,
                Duration = "Up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb71a722-8f62-4850-88f4-900491f6a0da"), Type = TextBlockType.Text, Text = "You channel a magical ward through your attack and attempt to plant it on a foe. This ward increases your defenses against that foe, as long as you keep attacking that foe to maintain it. Make a melee Strike with a weapon or unarmed attack against a foe. In addition to the normal effects of the Strike, it has the effects below. Warding aggression ends if the foe you attacked dies or at the end of any turn in which you didn't hit that foe with a melee Strike." };
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e88b81af-15de-445b-b99e-6b8d6e10bfc2"),
                CriticalSuccess = "You gain a +3 status bonus to AC against the foe for 1 round and a +2 status bonus to AC against the foe for the remaining duration.",
                Success = "You gain a +2 status bonus to AC against the foe.",
                Failure = "You gain a +1 status bonus to AC against the foe.",
                CriticalFailure = "You gain no additional effect."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6b29d94-8715-42d6-a629-182f9bbceb1c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 140
            };
        }
    }
}
