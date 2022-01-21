using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AngelicHalo : Template
    {
        public static readonly Guid ID = Guid.Parse("d7ab83e4-1413-4bbb-bfdc-17eeba1b8108");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Angelic Halo",
                Level = 1,
                Area = "15-foot emanation.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81ff5de4-fb8d-4da8-8ca5-247d18a1d951"), Type = TextBlockType.Text, Text = "You gain an angelic halo with an aura that increases allies' healing from the heal spell. Allies in your halo's emanation who are healed by a heal spell gain a status bonus to Hit Points regained equal to double the heal spell's level." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("80044bf0-9581-4fc5-917d-e4d06cbd5032"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f3062881-72ee-4d7d-9de6-b25e1f7036ee"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("854c33a0-2d2f-49fa-b148-b8785060a4ba"), Traits.Instances.Good.ID);
            builder.Add(Guid.Parse("835ce632-8b90-47f2-a41b-48b0d6063123"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58947416-e0ec-400d-bc8b-38e44ba8f3bf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 402
            };
        }
    }
}
