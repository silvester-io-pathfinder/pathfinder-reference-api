using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
            yield return new TextBlock { Id = Guid.Parse("fad31499-2398-422c-897c-2b71d0028514"), Type = TextBlockType.Text, Text = "Your symphony lifts listeners from their worldly concerns. Attempt a Performance check to counteract one of the following conditions affecting the target: grabbed, immobilized, paralyzed, restrained, slowed, or stunned. If you fail, you can't target that effect on the target for 1 day. Use the condition's source to determine the counteract DC (for example, the Escape DC for grabbed)." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c1fe61ba-0cb8-483d-93a3-6a1ce6597548"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("decc2147-dab5-4da7-a645-0a5a8f309ddf"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("c4cde0a8-1fa2-494d-b006-791ce55de032"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("c69d3d43-13f6-4d1e-9a25-a0ac9faa498b"), Traits.Instances.Composition.ID);
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
