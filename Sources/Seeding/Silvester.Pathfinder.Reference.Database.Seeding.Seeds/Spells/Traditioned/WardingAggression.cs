using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WardingAggression : Template
    {
        public static readonly Guid ID = Guid.Parse("160080c7-1405-474f-b0c5-ef6c7f2eecfe");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Warding Aggression",
                Level = 3,
                Duration = "Up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cac54ced-26a3-4d44-8e5c-ac6220869fbc"), Type = TextBlockType.Text, Text = "You channel a magical ward through your attack and attempt to plant it on a foe. This ward increases your defenses against that foe, as long as you keep attacking that foe to maintain it. Make a melee Strike with a weapon or unarmed attack against a foe. In addition to the normal effects of the Strike, it has the effects below. Warding aggression ends if the foe you attacked dies or at the end of any turn in which you didn't hit that foe with a melee Strike." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("25dacf4f-effc-4bea-9d9d-a96e9f052d39"),
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

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0caeccc9-96b5-4184-a0cf-1512b29c2655"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab5a2dfa-9800-49f8-a6fd-cb61615bc7d3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 140
            };
        }
    }
}
