using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EnlargeCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("8ab5854e-77ab-4fd1-a64e-096bcff92f07");

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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4fd86684-c6e1-4f32-bf0d-d1ee5442bb66"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4ff0636c-2d6f-482c-9214-48f1754945ed"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("0b39331c-ea16-4ef8-8de9-b51f4b65839d"), Traits.Instances.Ranger.ID);
            builder.Add(Guid.Parse("92eed5d9-cf91-4fac-8c21-f8e7f2a275d6"), Traits.Instances.Transmutation.ID);
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
