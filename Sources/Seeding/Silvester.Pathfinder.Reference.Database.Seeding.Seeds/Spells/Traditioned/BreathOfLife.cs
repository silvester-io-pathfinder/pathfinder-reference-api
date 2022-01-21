using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BreathOfLife : Template
    {
        public static readonly Guid ID = Guid.Parse("27b176c3-a4ac-425b-b7f1-9e6b7c25063f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Breath of Life",
                Level = 5,
                Range = "60 feet.",
                Targets = "The triggering creature.",
                Trigger = "A living creature within range would die.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dad7233b-d058-464a-a3b2-94820cc93d6d"), Type = Utilities.Text.TextBlockType.Text, Text = "Your blessing revives a creature at the moment of its death. You prevent the target from dying and restore Hit Points to the target equal to 4d8 plus your spellcasting ability modifier. You can't use breath of life if the triggering effect was disintegrate or a death effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b438aad8-32dc-4d03-af96-75a8ec415f4e"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("80c4053f-9566-4007-bc53-5eb21f26955c"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("3c1856be-e25e-46fb-a4f7-5fa7a8785894"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab1b0e3c-a16a-4adc-9519-ce02da305765"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 322
            };
        }
    }
}
