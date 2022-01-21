using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GluttonsJaw : Template
    {
        public static readonly Guid ID = Guid.Parse("d176fc28-4eab-4064-bc8b-c6966642e362");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Glutton's Jaw",
                Level = 1,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1231c6c1-f32a-4bd6-99f5-2fd3edd61a39"), Type = TextBlockType.Text, Text = "Your mouth transforms into a shadowy maw bristling with pointed teeth. These jaws are an unarmed attack with the forceful trait dealing 1d8 piercing damage. If you hit with your jaws and deal damage, you gain 1d6 temporary Hit Points." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("31673095-71eb-408d-b77d-ca8654ee6794"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4409c616-7281-42eb-a963-f2d178906443"), Type = TextBlockType.Text, Text = "The temporary Hit Points increase by 1d6." }
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
            builder.Add(Guid.Parse("246fed56-bf91-4a3f-aabe-0523ef29f08d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0571f53e-6ca9-4481-8b38-46babd95068d"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("2f352f83-1845-4ee7-ac3f-7b4fd16123e5"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("fed4ccae-87ec-41bb-bf73-4262ae79f39b"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab9366df-7fb8-47c4-a2a8-deaa6528b16c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
