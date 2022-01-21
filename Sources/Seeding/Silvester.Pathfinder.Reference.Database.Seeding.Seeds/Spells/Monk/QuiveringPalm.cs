using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class QuiveringPalm : Template
    {
        public static readonly Guid ID = Guid.Parse("a0300663-253b-4a61-a986-adfc0dd8022f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Quivering Palm",
                Level = 8,
                Duration = "1 month.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f074011-6509-415a-8296-76ed1d4317df"), Type = TextBlockType.Text, Text = "Make a melee unarmed Strike. If you hit and the target is alive, anytime during the duration, you can spend a single action, which has the auditory and concentrate traits, to speak a word of death that could instantly slay it. The target must attempt a Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("51c554c2-a641-4b7f-894f-62050e33cb99"), Type = TextBlockType.Text, Text = "If you cast quivering palm again, the effects of any quivering palm you had previously cast end." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("50413b59-c2ef-4c2d-83f7-a2c0aa68167e"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b2d00346-8099-4239-9761-4f99afc92003"), Type = TextBlockType.Text, Text = "The damage increases by 10 on a failure, or 5 on a success." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("3dc15c3d-d43c-4c69-9433-7252c704376a"),
                CriticalSuccess = "The target survives, the spell ends, and the target is then temporarily immune for 24 hours.",
                Success = "The target is stunned 1 and takes 40 damage, the spell ends, and the target is then temporarily immune for 24 hours.",
                Failure = "The target is stunned 3 and takes 80 damage. The spell's duration continues, but the target is then temporarily immune for 24 hours against being killed by quivering palm.",
                CriticalFailure = "The target dies."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d3730361-743f-42d1-900d-1e444db7498a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e439831f-5549-4ba7-afeb-654e7f1af2bc"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("0f27ab8c-47e7-484d-98a0-1b8936b938d6"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("755be7d3-ce48-46d1-9a1a-d1e4a28d1368"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("314fc282-46ae-43be-b9a5-b90511f57ae8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 401
            };
        }
    }
}
