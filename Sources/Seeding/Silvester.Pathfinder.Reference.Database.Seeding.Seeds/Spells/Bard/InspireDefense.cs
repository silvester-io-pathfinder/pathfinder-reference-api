using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InspireDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("41cc7828-aa79-42a3-a7de-5a64f77cc30f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Inspire Defense",
                Level = 2,
                Area = "60-foot emenation.",
                Duration = "1 round.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffe6a820-2c09-47f6-8479-e2d9d9bc6ba7"), Type = TextBlockType.Text, Text = "You inspire yourself and your allies to protect themselves more effectively. You and all allies in the area gain a +1 status bonus to AC and saving throws, as well as resistance equal to half the spell's level to physical damage." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("60a2d1c2-43e1-4d15-a787-8074179c667e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("1d64e9f0-df83-4bbd-808e-041ce90a63ef"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("47553b52-5562-4011-b78c-0391ddea73cc"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("f8f0a737-15f7-4839-8418-c4756f0189d8"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("ddff9864-48b7-4bed-969f-17e7ae47c001"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("6f8d6df5-47ef-4db1-980a-921ab63c438b"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("ecab5939-9f07-4889-bc34-86fa29f01de8"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bfc56e6-4736-4f30-8e06-7926da79ac45"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
