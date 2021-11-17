using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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
            yield return new TextBlock { Id = Guid.Parse("03d8285b-7c02-495a-b95f-f3134ed1fecf"), Type = TextBlockType.Text, Text = "You dance at a lively tempo, speeding your allies’ movement. You and all allies in the area gain a +10-foot status bonus to all Speeds for 1 round." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
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
