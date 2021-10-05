using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Allegro : Template
    {
        public static readonly Guid ID = Guid.Parse("8a7a6e25-7506-4477-87e5-3bb8477f2616");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Allegro",
                Level = 7,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 ally.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a146f87-7db4-4e9b-b486-a5d02154f1ea"), Type = TextBlockType.Text, Text = "You perform rapidly, speeding up your ally. The ally becomes quickened and can use the additional action to Strike, Stride, or Step." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
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
                Id = Guid.Parse("f20455d1-3462-42ef-9bb4-aa1d4b91665a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
