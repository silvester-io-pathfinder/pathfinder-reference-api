using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AnathematicReprisal : Template
    {
        public static readonly Guid ID = Guid.Parse("dcadfb92-e8c7-47a4-a6cc-4de6eefb7c3c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Anathematic Reprisal",
                Level = 4,
                Range = "30 feet.",
                Targets = "The triggering creature.",
                Trigger = "A creature performs an act anathema to your deity.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2732bb4-f4c8-4186-b3a5-cda174bebd7c"), Type = Utilities.Text.TextBlockType.Text, Text = "You punish a creature that transgresses against your deity, drawing upon the anguish you feel upon seeing one of your deity’s anathema committed." };
            yield return new TextBlock { Id = Guid.Parse("d4987992-bbdd-4122-8baa-db244671e460"), Type = Utilities.Text.TextBlockType.Text, Text = "You can cast this spell only when a creature actively commits a unique act of anathema. For example, if creating undead were anathema to your deity, you could use anathematic reprisal on a necromancer who had just created undead in front of you, but not on an undead creature just for existing." };
            yield return new TextBlock { Id = Guid.Parse("c4da2067-3e39-45c0-afa3-0300488a2ad4"), Type = Utilities.Text.TextBlockType.Text, Text = "You deal 4d6 mental damage to the target, but a basic Will save can reduce this damage. If it fails, it is also stupefied 1 for 1 round. The creature is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("96d6be16-ee49-4b00-aa7e-7b364bd363bc"), 
                Level = "+1", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6454be59-729b-4090-b4c6-642db9481178"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 317
            };
        }
    }
}
