using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Wish : Template
    {
        public static readonly Guid ID = Guid.Parse("98b4f7a4-5a66-4fee-bc6e-74c2b32fe49f");

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
            yield return new TextBlock { Id = Guid.Parse("c0daf1c4-85bb-4110-a1fe-fe28b2c6638c"), Type = TextBlockType.Text, Text = "You state a wish, making your greatest desire come true. A wish spell can produce any one of the following effects." };
            yield return new TextBlock { Id = Guid.Parse("44d05e01-6aa2-401c-b17a-201c70989be0"), Type = TextBlockType.Enumeration, Text = "Duplicate any arcane spell of 9th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("63419a2b-fe11-45ad-ad14-9dcb4442c96a"), Type = TextBlockType.Enumeration, Text = "Duplicate any non-arcane spell of 7th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("1a6beafa-11c0-45c1-ae50-eee35869af29"), Type = TextBlockType.Enumeration, Text = "Produce any effect whose power level is in line with the above effects." };
            yield return new TextBlock { Id = Guid.Parse("6b057c6e-e0c7-47cc-875d-1737d61512b0"), Type = TextBlockType.Enumeration, Text = "Reverse certain effects that refer to the wish spell." };
            yield return new TextBlock { Id = Guid.Parse("7cfd35a8-58d6-4c26-b9c2-e110209769ac"), Type = TextBlockType.Text, Text = "The GM might allow you to try using wish to produce greater effects than these, but doing so might be dangerous or the spell might have only a partial effect." };
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
                Id = Guid.Parse("0e4b1ba2-6f64-498e-a056-f1b17326e2a5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 385
            };
        }
    }
}
