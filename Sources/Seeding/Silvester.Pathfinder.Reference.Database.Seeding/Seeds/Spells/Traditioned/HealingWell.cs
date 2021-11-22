using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HealingWell : Template
    {
        public static readonly Guid ID = Guid.Parse("87c0b43a-fc20-41f7-858a-3ced5d807fbb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Healing Well",
                Level = 5,
                Range = "30 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0a9999f-96a7-495e-94d0-cdf99ac68399"), Type = TextBlockType.Text, Text = "You call forth a well of healing that you and your allies can draw from later. The well appears as a disc of shimmering light on the ground in a square you touch. At any time during the duration, if you or an ally are adjacent to the well, that character can Interact to tap into the well�s power, recovering 4d8 Hit Points. When the well has been tapped five times, the spell ends. The well is made of insubstantial energy, allowing creatures to move through it and even end their turn in its space." };
            yield return new TextBlock { Id = Guid.Parse("3e011d5e-1cd2-459f-adb1-1d9e13e2c2cd"), Type = TextBlockType.Text, Text = "If you use an ability that increases the amount of healing this spell grants, that increase applies only to the first time someone taps the well." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3e56e30f-8039-4d66-99de-75ede7a1d7f9"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("e994675d-7f20-4388-98f2-0334e650a384"), Type = TextBlockType.Text, Text = "The healing increases by 3." }
                }
            };
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
                Id = Guid.Parse("6cc1e8df-66a8-4d93-be56-ecef4ae08532"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 110
            };
        }
    }
}
