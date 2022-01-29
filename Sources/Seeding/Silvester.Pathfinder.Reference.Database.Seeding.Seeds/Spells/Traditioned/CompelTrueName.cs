using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CompelTrueName : Template
    {
        public static readonly Guid ID = Guid.Parse("ff53ddbd-65ef-4366-80e2-da15dc90b95f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Compel True Name",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 creature whose true name you know.",
                Duration = "Varies",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c48dd65-8572-4c2d-a7b0-f21e090dfb87"), Type = TextBlockType.Text, Text = "You instruct the target to do something, compelling obedience by calling it by its true name. Your instructions can't be self-destructive. Though this spell has the linguistic trait, this applies only to the instructions; the creature doesn't need to know its own true name to be affected. The target must attempt a Will saving throw." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("33acf478-c3c3-4096-b4ba-4ddb36627982"),
                CriticalSuccess = "The target is unaffected, is temporarily immune to further castings of this spell by you for 1 week, and learns your true name.",
                Success = "The target is unaffected, is temporarily immune to further castings of this spell by you for 1 day, and learns a fragment of your true name (see the Fragmentary Names sidebar at right).",
                Failure = "The target does as you command. The spell has a duration of 10 minutes, or until the target has completed a finite instruction or the instructions become selfdestructive. The creature is temporarily immune to further castings of this spell by you for 1 hour.",
                CriticalFailure = "As failure, but the spell's duration is 8 hours, and the creature is not temporarily immune."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d961b442-a75e-4b31-8e23-c3bb1677d511"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("0cdbd93e-cc35-4ab0-a861-3d01da8dbdff"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("639c5550-0aaa-42f5-b427-30eefc7758ba"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("00fb23f6-c116-47a1-a855-acc6362ab8a5"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("a5eb66fd-1b75-4d03-8327-f10a9490659e"), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse("d83e2e2a-751a-4b8b-9fab-19d405d361c0"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("358ed1eb-7782-4d62-b667-c4c7c6fa2d3e"), Traits.Instances.TrueName.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc7bcd60-bfcf-4ccc-ac8b-f65ca25d180b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 247
            };
        }
    }
}