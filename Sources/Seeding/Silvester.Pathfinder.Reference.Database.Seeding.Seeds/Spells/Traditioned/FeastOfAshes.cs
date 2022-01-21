using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FeastOfAshes : Template
    {
        public static readonly Guid ID = Guid.Parse("b8674ff4-d315-49cf-a100-dfb78a1c496d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Feast of Ashes",
                Level = 2,
                Range = "30 feet.",
                Targets = "1 living creature.",
                Duration = "1 week.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6547b19-bfd9-4220-b947-62a9a761c806"), Type = TextBlockType.Text, Text = "You curse the target with a hunger no food can sate. You can Dismiss the spell. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0e82eac5-7ad8-4d83-94d4-a1f2e7a7e0f5"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3f162a10-1887-44c1-bf79-af8b21014428"), Type = TextBlockType.Text, Text = "The hunger becomes more unbearable, increasing the damage each day by 1d4, or by 2d4 on a critical failure." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("39ba1be3-813a-4ea1-b32d-0ace3631e9e9"),
                CriticalSuccess = "The creature is unaffected and is temporarily immune for 1 hour.",
                Success = "The creature is fatigued for 1 round.",
                Failure = " The creature is immediately afflicted by hunger as if it hadn�t eaten food in days. It becomes fatigued and takes 1d4 damage each day that can�t be healed until it sates its hunger. No amount of eating can sate the creature�s hunger during the spell�s duration. After the spell�s duration, the creature takes damage from starvation.",
                CriticalFailure = "As failure but the creature takes 2d4 damage each day, twice as much as usual for hunger."
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
            builder.Add(Guid.Parse("03b855b4-e38a-4c79-8b7c-69a28c471900"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("94fb076b-c184-4903-8118-6c84f6a24de1"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77bcf6e7-d44a-4942-8c65-710fecada4df"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 107
            };
        }
    }
}
