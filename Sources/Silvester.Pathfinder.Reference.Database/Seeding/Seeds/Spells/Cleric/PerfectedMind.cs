using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PerfectedMind : Template
    {
        public static readonly Guid ID = Guid.Parse("162dc2ed-c6c0-4af2-a9d3-225eac826afe");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Perfected Mind",
                Level = 1,
                DomainId = Domains.Instances.Perfection.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("024367a6-53de-4752-afae-2409c7611b70"), Type = TextBlockType.Text, Text = "You meditate upon perfection to remove all distractions from your mind. Attempt a new Will save against one mental effect currently affecting you that required a Will save. Use the result of this new save to determine the outcome of the mental effect, unless the new save would have a worse result than the original save, in which case nothing happens. You can use perfected mind against a given effect only once." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fddcde9-6215-44bc-a203-c45bacaeb554"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 394
            };
        }
    }
}
