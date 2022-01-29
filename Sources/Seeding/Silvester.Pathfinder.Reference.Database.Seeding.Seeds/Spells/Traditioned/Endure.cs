using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Endure : Template
    {
        public static readonly Guid ID = Guid.Parse("71f2e3a1-7217-4993-a173-e436b32dbb00");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Endure",
                Level = 1,
                Range = "Touch.",
                Targets = "1 creature.",
                Duration = "1 round.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a31476c-0645-4b6e-960a-06dd2b403dea"), Type = TextBlockType.Text, Text = "You invigorate the touched creature's mind and urge it to press on. You grant the touched creature 5 temporary Hit Points." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ccb23ce4-1052-44ce-a505-10701237e2f3"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3b38900a-edaf-4c75-9a2e-a74c455df449"), Type = TextBlockType.Text, Text = "Increase the temporary Hit Points by 5." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0b66f246-63b8-4b3e-a53c-f6dc71689247"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("b067f6c0-0a70-415b-b7d3-1475d8937f2d"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bac561c9-fcf3-40db-a084-1ec9e4ac8667"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 107
            };
        }
    }
}
