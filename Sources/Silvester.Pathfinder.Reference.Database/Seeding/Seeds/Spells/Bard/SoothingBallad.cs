using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SoothingBallad : Template
    {
        public static readonly Guid ID = Guid.Parse("d1ce3fe1-464d-458c-a96a-fec58a31d4d5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Soothing Ballad",
                Level = 7,
                Range = "30 eet.",
                Targets = "You and up to 9 allies.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b52dcfc9-f612-46f5-b83e-a56a6f34dfcf"), Type = TextBlockType.Text, Text = "You draw upon your muse to soothe your allies. Choose one of the following three effects:" };
            yield return new TextBlock { Id = Guid.Parse("daeab516-76dc-4955-907d-8f0a6d455f04"), Type = TextBlockType.Enumeration, Text = "The spell attempts to counteract fear effects on the targets." };
            yield return new TextBlock { Id = Guid.Parse("469dfce2-2174-4474-a599-9a2318a35d76"), Type = TextBlockType.Enumeration, Text = "The spell attempts to counteract effects imposing paralysis on the targets." };
            yield return new TextBlock { Id = Guid.Parse("2949c592-d6fd-401b-a226-47fcf0a9ce4d"), Type = TextBlockType.Enumeration, Text = "The spell restores 7d8 Hit Points to the targets." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("644cc182-af4d-4084-9a37-200d4a4e5695"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("368c97a3-01fc-4539-8bb7-cdfbf6d4fa60"), Type = TextBlockType.Text, Text = "When used to heal, soothing ballad restores 1d8 more Hit Points." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73a20d35-c4b3-41c8-a0dd-70c505933b84"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
