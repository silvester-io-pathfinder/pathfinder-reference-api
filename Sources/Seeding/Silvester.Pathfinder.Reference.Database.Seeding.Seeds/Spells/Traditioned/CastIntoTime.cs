using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CastIntoTime : Template
    {
        public static readonly Guid ID = Guid.Parse("02ece785-4233-470d-a640-1a2f2e775b92");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cast Into Time",
                Level = 6,
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9bad2466-c608-48c8-b743-e76667df224b"), Type = TextBlockType.Text, Text = "You release a wave of temporal energy that sends creatures violently tumbling through time, scarring their thoughts with the information flowing around them. Although the journey can feel like it lasts for minutes or even days, the targets reappear instantly. Witnessing this chaotic flow of time and being bashed against objects from different times deals the targets 5d8 mental damage and 5d6 bludgeoning damage, with a Fortitude save. A creature that falls into time disappears until the end of your turn. It then reappears in the same space it left; if that space is occupied, it appears in the nearest empty space, chosen by the GM." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8dd16d34-15bd-40a4-9151-f4e232bf56d9"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("c6888abf-f69d-44fb-934a-230344d50ab4"), Type = TextBlockType.Text, Text = "The bludgeoning damage increase by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e5c421fe-75ca-42d1-858f-fb087d991701"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature falls into time. When it returns, it takes half damage.",
                Failure = "The creature falls into time. When it returns, it takes full damage and is sickened 1.",
                CriticalFailure = "The creature falls into time. When it returns, it takes double damage and is sickened 2."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d78f6274-bf6a-4b37-b11e-90be35326029"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f44fd8f-100f-48c8-9398-f9addffc54a1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 94
            };
        }
    }
}
