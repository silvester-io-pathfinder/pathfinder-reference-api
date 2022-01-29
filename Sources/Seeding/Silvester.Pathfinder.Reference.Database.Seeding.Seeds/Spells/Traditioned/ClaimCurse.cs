using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ClaimCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("c3e87186-f5cc-48e7-a6f2-b207c3c5c505");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Claim Curse",
                Level = 3,
                Range = "Touch.",
                Duration = "5 minutes.",
                Targets = "1 creature affected by a curse.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ec7b665-324a-4bc9-8c0d-f4dd2c912a6b"), Type = TextBlockType.Text, Text = "By burning threads of fate around a target and then retying sthem to yourself instead, you temporarily draw their curse to you and offer them brief succor from the worst of its effects. Choose a curse affecting the target that you don't already have. For 5 minutes, you are affected by the curse (at the same stage as the target, if applicable), and the target isn't. When the duration ends, the curse's effects return to the target as normal." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("93d02702-0093-44ef-9f0b-424897d9ddf9"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05c6aaa5-de34-4d73-ae6d-f813a111d200"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 95
            };
        }
    }
}
