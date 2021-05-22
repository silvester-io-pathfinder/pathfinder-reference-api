using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class FieldOfLife : Template
    {
        public static readonly Guid ID = Guid.Parse("0b3f4499-6345-4a38-8c98-b00a6f71fc2b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Field of Life",
                Level = 6,
                Range = "30 feet.",
                Area = "20-foot burst.",
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01608f5d-09ad-4203-aa86-69767650e971"), Type = TextBlockType.Text, Text = "A field of positive energy fills the area, exuding warmth and rejuvenating those within. Each living creature that starts its turn in the area regains 1d8 Hit Points, and any undead creature that starts its turn in the area takes 1d8 positive damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cb7e2b0c-c70a-4c96-bb58-248b3b018e23"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("28230a16-4681-4b9f-99d9-aa32b614bcfd"), Type = TextBlockType.Text, Text = "The healing and damage increase to 1d10." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a37453f8-3ab6-41a2-bb16-1ce4c48c1631"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5ce26eed-c1d4-4688-b125-0d6278c94147"), Type = TextBlockType.Text, Text = "The healing and damage increase to 1d12." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64ffdd0e-6047-4efd-a35b-a82d61092ab2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}
