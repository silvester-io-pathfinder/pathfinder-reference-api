using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AncestralMemories : Template
    {
        public static readonly Guid ID = Guid.Parse("ecb524f1-68fc-418e-9239-19d7fddc7284");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ancestral Memories",
                Level = 1,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4dc0ac21-cf43-4744-9247-b4fffabf54ba"), Type = TextBlockType.Text, Text = "The memories of long-dead spellcasters grant you knowledge in a specific skill. Choose any non-Lore skill, or a Lore skill related to the ancient empire from which your bloodline sprang. You temporarily become trained in that skill and might gain other memories associated with an ancestor who was trained in that skill. If you attempt a task or activity that lasts beyond this spell's duration, use the lower proficiency modifier." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a9298b36-cd16-4461-8463-913330268370"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bbac3a60-db6e-41d2-ac4c-eeac9f649dd8"), Type = TextBlockType.Text, Text = "You temporarily become an expert in the skill you choose." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("741fa497-f76b-43f1-9209-ebce2f96d787"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 402
            };
        }
    }
}
