using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
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
