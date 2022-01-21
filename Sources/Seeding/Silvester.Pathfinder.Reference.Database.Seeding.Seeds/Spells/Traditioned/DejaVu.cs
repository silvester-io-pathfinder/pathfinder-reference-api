using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DejaVu : Template
    {
        public static readonly Guid ID = Guid.Parse("22d38c1e-6536-4f90-8fb0-3cd0f651062b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Déjà Vu",
                Level = 1,
                Range = "100 feet.",
                Duration = "2 rounds.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("621917f5-860c-4113-aec2-9604b113e9db"), Type = TextBlockType.Text, Text = "You loop a thought process in the target's mind, forcing it to repeat the same actions over again. The target must attempt a Will save. If the target fails, whatever actions the target uses on its next turn, it must repeat on its following turn. The actions must be repeated in the same order and as close to the same specifics as possible. For example, if the target makes an attack, it must repeat the attack against the same creature, if possible, and if the target moves, it must move the same distance and direction, if possible, on its next turn." };
            yield return new TextBlock { Id = Guid.Parse("1ac2096a-6156-4919-a395-7c0ca8fcf045"), Type = TextBlockType.Text, Text = "If the target can't repeat an action, such as Casting a Spell that has been exhausted or needing to target a creature that has died, it can act as it chooses for that action but becomes stupefied 1 until the end of its turn." };
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
            builder.Add(Guid.Parse("057ed799-6145-4deb-8f34-987517c1aaa4"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("b768d5d5-b11e-4bf3-b4e5-c1faff6a9121"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("1c6e7e60-c3c9-4f30-8850-5bdba0e6aee0"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ca9b6fa-b905-41b7-ac79-a2d38a94cf38"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 218
            };
        }
    }
}
