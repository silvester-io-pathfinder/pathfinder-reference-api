using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TripleTime : Template
    {
        public static readonly Guid ID = Guid.Parse("e3bf6e5b-5f56-460a-a75d-0f66f784aad1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Triple Time",
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
            yield return new TextBlock { Id = Guid.Parse("03d8285b-7c02-495a-b95f-f3134ed1fecf"), Type = TextBlockType.Text, Text = "You dance at a lively tempo, speeding your allies' movement. You and all allies in the area gain a +10-foot status bonus to all Speeds for 1 round." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("08ad637b-d042-4ebd-8620-c527b5efce08"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0ed8db70-66dd-48ab-ade9-b60000ba6038"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("f79da6fe-125e-4d17-8e84-7192af79f5a2"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("79dc5953-1090-4137-9c40-94dfce7e2d04"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("b53887db-430b-49bb-855e-4bc50dc73ff7"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("1d9069b4-62d3-4434-8b31-13da7a9ee60b"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("7a4f704e-75a1-43c0-9480-271c5e32fe64"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("195c9066-3861-4d7d-9b70-d8c85b0a6e82"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
