using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElectrifiedCrystalWard : Template
    {
        public static readonly Guid ID = Guid.Parse("b9d36cbc-9088-4e21-9b5b-b756f9e45673");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Electrified Crystal Ward",
                Level = 3,
                Range = "Touch.",
                Targets = "1 hinge or latch.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08dd3018-710f-469a-a181-dc3705de5648"), Type = TextBlockType.Text, Text = "You create an electric latch rune hazard on the target, creating a special crystalline lock on the object. You can also substitute your spell DC for any of the hazard's listed DCs. You can have only one such hazard active at a time, and if you cast this spell while a previous electric latch rune is active, the older hazard discharges harmlessly." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9e114eed-6f20-4de6-b6c5-d481dc3af298"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("80a9fa64-c73c-44ba-af86-b1b8db244fc0"), Type = TextBlockType.Text, Text = "The hazard's damage increases by 1d12." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("832470a8-688d-4689-a371-326d628ca01b"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("beb1071d-87d8-42b5-8b12-11bb48d4423b"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 75
            };
        }
    }
}
