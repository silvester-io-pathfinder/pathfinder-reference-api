using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SymphonyOfTheUnfetteredHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("db9e969f-0a3e-43a9-bac9-b2a672751a30");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Symphony of the Unfettered Heart",
                Level = 5,
                Range = "30 feet.",
                Targets = "You or 1 ally.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fad31499-2398-422c-897c-2b71d0028514"), Type = TextBlockType.Text, Text = "Your symphony lifts listeners from their worldly concerns. Attempt a Performance check to counteract one of the following conditions affecting the target: grabbed, immobilized, paralyzed, restrained, slowed, or stunned. If you fail, you can’t target that effect on the target for 1 day. Use the condition’s source to determine the counteract DC (for example, the Escape DC for grabbed)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("75b45df1-7e80-48fd-8ce1-b7980336683d"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("48f5d4bb-6b81-4662-91c2-be66a0764393"), Type = TextBlockType.Text, Text = "You can target up to four creatures." }
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
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Composition.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90dfce73-f37c-4e63-9e75-4dab93933868"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 228
            };
        }
    }
}
