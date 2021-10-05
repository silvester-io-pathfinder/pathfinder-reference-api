using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HolyCascade : Template
    {
        public static readonly Guid ID = Guid.Parse("9ced7a87-4222-49e4-8501-a2007b107199");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Holy Cascade",
                Level = 4,
                Range = "500 feet",
                Cost = "One vial of holy water (page 571 of the Core Rulebook).",
                Area = "20-foot burst.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a84479a-eedb-4129-bb27-a62406e9fa9f"), Type = TextBlockType.Text, Text = "You call upon sacred energy to amplify a vial of holy water, tossing it an incredible distance. It explodes in an enormous burst that deals 3d6 bludgeoning damage to creatures in the area from the cascade of water. The water deals an additional 6d6 positive damage to undead and 6d6 good damage to fiends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0df6e647-ec71-4e03-9023-992c826c4152"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a3a53f28-12f5-42bf-87be-385135544457"), Type = TextBlockType.Text, Text = "The bludgeoning damage increases by 1d6, and the additional positive and good damage each increase by 2d6." }
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Good.ID;
            yield return Traits.Instances.Positive.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76cef4ad-c9ee-4015-97ba-c7a46ba504c1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 344
            };
        }
    }
}
