using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class EnlargeCompanion : Template
    {
        public static readonly Guid ID = 8ab5854e-77ab-4fd1-a64e-096bcff92f07);

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Enlarge Companion",
                Level = 4,
                Range = "30 feet.",
                Targets = "Your animal companion.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d46d2901-16b4-4808-a625-4caa8629b738"), Type = TextBlockType.Text, Text = "Your animal companion grows much larger, towering over its foes in battle. Your animal companion becomes Huge, gaining the effects of a 4th-level enlarge spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Ranger.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ffa76e0-e6a2-4880-adf2-603352d6d20b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 234
            };
        }
    }
}
