using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Wish : Template
    {
        public static readonly Guid ID = Guid.Parse("37332c0a-aff0-44a4-abc6-eb8533161963");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wish",
                Level = 10,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37332c0a-aff0-44a4-abc6-eb8533161963"), Type = TextBlockType.Text, Text = "You state a wish, making your greatest desire come true. A wish spell can produce any one of the following effects." };
            yield return new TextBlock { Id = Guid.Parse("37332c0a-aff0-44a4-abc6-eb8533161963"), Type = TextBlockType.Enumeration, Text = "Duplicate any arcane spell of 9th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("37332c0a-aff0-44a4-abc6-eb8533161963"), Type = TextBlockType.Enumeration, Text = "Duplicate any non-arcane spell of 7th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("37332c0a-aff0-44a4-abc6-eb8533161963"), Type = TextBlockType.Enumeration, Text = "Produce any effect whose power level is in line with the above effects." };
            yield return new TextBlock { Id = Guid.Parse("37332c0a-aff0-44a4-abc6-eb8533161963"), Type = TextBlockType.Enumeration, Text = "Reverse certain effects that refer to the wish spell." };
            yield return new TextBlock { Id = Guid.Parse("37332c0a-aff0-44a4-abc6-eb8533161963"), Type = TextBlockType.Text, Text = "The GM might allow you to try using wish to produce greater effects than these, but doing so might be dangerous or the spell might have only a partial effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37332c0a-aff0-44a4-abc6-eb8533161963"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 385
            };
        }
    }
}
