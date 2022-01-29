using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UntwistingIronBuffer : Template
    {
        public static readonly Guid ID = Guid.Parse("656366d8-c499-40ff-a38d-a553c1c7de91");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Untwisting Iron Buffer",
                Level = 3,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("435e22d5-51a4-4805-ae35-c98b002f7ad8"), Type = TextBlockType.Text, Text = "You send currents of protective ki to the surface of your body that protect you from harm, at least until your enemies dissipate them. You gain 15 temporary Hit Points, which last for up to 3 rounds." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield break;
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7c0759cd-c49f-460a-807c-012a9d23ed2f"),
                Level = "+1",
                Details = new TextBlockBuilder()
                    .Text(Guid.Parse("b11ec178-1bce-452f-ad39-db5721b63cc4"), "The temporary Hit Points increase by 5.")
                    .Build()
            };
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("eb5e1747-064e-4476-8d48-ae32371f9317"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7e3b73a7-4c64-4355-83d5-72392a2ee7d1"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d007246-874f-4b06-9933-c1470cbf6d07"),
                SourceId = Sources.Instances.WorldGuide.ID,
                Page = 83
            };
        }
    }
}
