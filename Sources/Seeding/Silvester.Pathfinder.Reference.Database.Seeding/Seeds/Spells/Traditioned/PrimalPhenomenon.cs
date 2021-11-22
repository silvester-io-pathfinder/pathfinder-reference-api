using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PrimalPhenomenon : Template
    {
        public static readonly Guid ID = Guid.Parse("6c4dede5-87ad-4a90-a7a8-52dd2fc5e46b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Primal Phenomenon",
                Level = 10,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d53db610-a666-4ab2-873a-9850f91cca27"), Type = TextBlockType.Text, Text = "You request a direct intercession from the natural world. Nature always refuses unnatural requests and might grant a different request (potentially more powerful or better fitting its character) than the one you asked for. A primal phenomenon spell can do any of the following things." };
            yield return new TextBlock { Id = Guid.Parse("8851196d-59a6-444d-8470-1e4c8a87d556"), Type = TextBlockType.Enumeration, Text = "Duplicate any primal spell of 9th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("78eb7243-2497-4d8c-9b10-5150bfdb0b2d"), Type = TextBlockType.Enumeration, Text = "Duplicate any non-primal spell of 7th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("09339164-3ddb-4d0f-8425-a99dbbcabef9"), Type = TextBlockType.Enumeration, Text = "Produce any effect whose power level is in line with the above effects." };
            yield return new TextBlock { Id = Guid.Parse("3adeabd6-c190-4b1e-b6b0-f0038c7b4540"), Type = TextBlockType.Enumeration, Text = "Reverse certain effects that refer to the wish spell." };
            yield return new TextBlock { Id = Guid.Parse("36dedd30-17e9-417a-b451-e2d3b1047d05"), Type = TextBlockType.Text, Text = "At the GM's discretion, you can try to use primal phenomenon to produce greater effects than these, but doing so may be dangerous, or the spell may have only a partial effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("814b5f04-3b31-48bc-9366-096115b5585c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 359
            };
        }
    }
}
