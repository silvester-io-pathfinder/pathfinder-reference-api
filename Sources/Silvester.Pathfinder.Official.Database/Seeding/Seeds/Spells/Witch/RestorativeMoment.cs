using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RestorativeMoment : Template
    {
        public static readonly Guid ID = Guid.Parse("9fdfdd49-8e96-4109-85de-9e0ac59bd241");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Restorative Moment",
                Level = 5,
                Range = "30 feet.",
                Targets = "1 creature.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fdfdd49-8e96-4109-85de-9e0ac59bd241"), Type = TextBlockType.Text, Text = "You manipulate the threads of time around the target, giving them some of the benefits of a day’s passage. The target decreases the values of any doomed and drained conditions it has by 1 and can immediately attempt one saving throw against each affliction it has with a stage length of 1 day or less. The target is then temporarily immune for 1 day." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9fdfdd49-8e96-4109-85de-9e0ac59bd241"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
