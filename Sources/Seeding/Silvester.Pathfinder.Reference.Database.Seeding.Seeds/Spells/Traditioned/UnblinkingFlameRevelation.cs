using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnblinkingFlameRevelation : Template
    {
        public static readonly Guid ID = Guid.Parse("9da6dc5d-7557-4c0e-9f6e-4125b7c6a058");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unblinking Flame Revelation",
                Level = 3,
                Duration = "2 rounds.",
                Requirements = "Your previous action was a successful unarmed strike.",
                Targets = "The creature you hit.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4795dfaf-81e0-4051-b884-fdd26c9add95"), Type = TextBlockType.Text, Text = "You light your foe with revealing flame. The GM attempts a secret counteract check against each illusion affecting the creature; on a success, you suppress the illusion for the duration, rather than end the effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield break;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ccf484c2-a181-4841-ae3f-5315c045f961"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("284b5fc2-3fcb-455b-bfa7-4a11e470315b"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86ba4a47-c3ef-4173-b477-b7c198dcd2a1"),
                SourceId = Sources.Instances.WorldGuide.ID,
                Page = 83
            };
        }
    }
}
