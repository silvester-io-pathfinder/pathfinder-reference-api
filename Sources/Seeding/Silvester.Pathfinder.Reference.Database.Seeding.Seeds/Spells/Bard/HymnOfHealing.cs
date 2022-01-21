using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HymnOfHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("912602ab-1cb3-4388-bb9f-c43b234f9359");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hymn of Healing",
                Level = 1,
                Range = "30 feet.",
                Targets = "You or 1 ally.",
                IsDismissable = true,
                Duration = "Sustained up to 4 rounds.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("16ae0af7-99af-4be4-8334-79dc5f11cacf"), Type = TextBlockType.Text, Text = "Your divine singing mends wounds and provides a temporary respite from harm. The target gains fast healing 2. When you Cast the Spell and each time you Sustain the Spell, the target gains 2 temporary Hit Points, which last for 1 round." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b4e5192e-a1c5-4977-9448-fa9e8525fae1"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4c4a7a5a-be78-4841-8123-1ce84e6d9468"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("756a376b-1667-40cd-9e92-bc041e794c87"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("7bfc5a79-91fb-4d04-bc0e-7ef36ed0d07e"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("12e49097-2793-435a-850e-1773a8723efd"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("931475e7-574f-4f70-98e9-04938820fb49"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9eb1b1ce-7453-45e3-84f5-b6a2ede811c0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 228
            };
        }
    }
}
