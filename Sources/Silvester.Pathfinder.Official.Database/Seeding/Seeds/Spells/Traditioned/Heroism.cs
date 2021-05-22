using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Heroism : Template
    {
        public static readonly Guid ID = Guid.Parse("e8c9c276-8fac-4aa9-bb37-f41fbc66cbd1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Heroism",
                Level = 3,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("629e6bc8-2c82-41d1-a7fc-2f0bab24bb9a"), Type = TextBlockType.Text, Text = "You tap into the target’s inner heroism, granting it a +1 status bonus to attack rolls, Perception checks, saving throws, and skill checks." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d7c2b155-f6c4-422b-97b3-57d3fa2a4741"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f63e94a0-b65e-43c7-89c0-046a08ee3598"), Type = TextBlockType.Text, Text = "The status bonus increases to +2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("174103ee-a012-4259-a93b-8715b1c5d1a9"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("54a2d29a-a003-49a4-a195-05f67ecf6154"), Type = TextBlockType.Text, Text = "The status bonus increases to +3." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d53b4edc-5192-4d7a-854b-a17215782f0c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 343
            };
        }
    }
}
