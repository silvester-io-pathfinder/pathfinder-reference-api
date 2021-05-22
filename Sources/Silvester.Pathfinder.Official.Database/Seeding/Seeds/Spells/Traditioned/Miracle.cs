using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Miracle : Template
    {
        public static readonly Guid ID = Guid.Parse("10cc85a3-13bd-4f39-91cb-c08c4673300c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Miracle",
                Level = 10,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a8e6434-e450-4377-b562-edaf1b8cc953"), Type = TextBlockType.Text, Text = "You request aid directly from your divine source. Your divine source always refuses a request out of line with its nature, and it might grant a different request (potentially more powerful or better fitting its nature) than the one you asked for. A casting of miracle can do any of the following things." };
            yield return new TextBlock { Id = Guid.Parse("2a62846b-203e-4155-8a56-b3bdbe83a4f0"), Type = TextBlockType.Enumeration, Text = "Duplicate any divine spell of 9th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("7cac6eac-daf5-4680-8a0c-e3e97a72c9de"), Type = TextBlockType.Enumeration, Text = "Duplicate any non-divine spell of 7th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("9e0727f7-295d-4bd5-93d2-8f08d04e831c"), Type = TextBlockType.Enumeration, Text = "Produce any effect whose power level is in line with the above effects." };
            yield return new TextBlock { Id = Guid.Parse("dec561e9-0a6b-4813-b005-a7f5135a39e6"), Type = TextBlockType.Enumeration, Text = "Reverse certain effects that refer to the wish spell." };
            yield return new TextBlock { Id = Guid.Parse("ff4213a3-131c-46fe-89b0-111bede985aa"), Type = TextBlockType.Text, Text = "The GM might allow you to try using miracle to produce greater effects than these, but doing so may be dangerous, or the spell may have only a partial effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a6256b7-e478-4de7-9873-2d3194e6b212"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 352
            };
        }
    }
}
