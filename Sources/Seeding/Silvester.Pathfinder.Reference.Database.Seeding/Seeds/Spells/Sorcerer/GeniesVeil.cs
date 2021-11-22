using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GeniesVeil : Template
    {
        public static readonly Guid ID = Guid.Parse("96f8d568-d477-42dc-ac59-0ac64b7ee25e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Genie's Veil",
                Level = 1,
                Range = "30 feet.",
                Trigger = "A creature within range is attacked.",
                Targets = "1 willing creature.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b7f86a9-5332-47ab-a209-f59bde3b053f"), Type = TextBlockType.Text, Text = "With a flourish, you fulfill a creature's wish for protection, bending reality to keep them from harm. The target vanishes in a burst of brightly colored smoke and sparkles, reappearing an instant later. They become concealed against the triggering attack and until the end of the current creature's turn." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c94d984-5f4b-4f4d-a94c-580fa558c5fa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 236
            };
        }
    }
}
