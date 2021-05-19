using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PrimalPhenomenon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Primal Phenomenon",
                Level = 10,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You request a direct intercession from the natural world. Nature always refuses unnatural requests and might grant a different request (potentially more powerful or better fitting its character) than the one you asked for. A primal phenomenon spell can do any of the following things." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Duplicate any primal spell of 9th level or lower." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Duplicate any non-primal spell of 7th level or lower." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Produce any effect whose power level is in line with the above effects." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Reverse certain effects that refer to the wish spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At the GM’s discretion, you can try to use primal phenomenon to produce greater effects than these, but doing so may be dangerous, or the spell may have only a partial effect." };
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 359
            };
        }
    }
}
